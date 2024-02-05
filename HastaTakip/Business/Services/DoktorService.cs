using Business.Models;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Results;
using DataAccess.Results.Bases;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{
    public interface IDoktorService
    {
        IQueryable<DoktorModel> Query();
        Result Add(DoktorModel model);
        Result Update(DoktorModel model);
        Result Delete(int id);
    }

    public class DoktorService : IDoktorService
    {
        private readonly Db db;

        public DoktorService(Db db)
        {
            this.db = db;
        }

        public IQueryable<DoktorModel> Query()
        {
            return db.Doktorlar.OrderByDescending(d => d.UzmanMi).ThenBy(d => d.Adi).ThenBy(d => d.Soyadi).Select(d => new DoktorModel()
            {
                #region Entity Özellikleri
                Adi = d.Adi,
                Soyadi = d.Soyadi,
                BransId = d.BransId,
                KlinikId = d.KlinikId,
                UzmanMi = d.UzmanMi,
                Guid = d.Guid,
                Id = d.Id,
                #endregion

                #region Ekstra Özellikler
                AdiSoyadiOutput = d.Adi + " " + d.Soyadi,
                UzmanMiOutput = d.UzmanMi ? "Uzman" : "Uzman Değil",

                KlinikOutput = d.Klinik.Adi, // 1 to many
                BransOutput = d.Brans.Adi, // 1 to many

                // many to many
                HastalarOutput = string.Join("<br />", d.DoktorHastalar.OrderBy(dh => dh.Hasta.Adi).ThenBy(dh => dh.Hasta.Soyadi)
                    .Select(dh => dh.Hasta.Adi + " " + dh.Hasta.Soyadi)),
                HastaIdleriInput = d.DoktorHastalar.Select(dh => dh.HastaId).ToList()
                #endregion
            });
        }

        public Result Add(DoktorModel model)
        {
            if (db.Doktorlar.Any(d => d.Adi.ToLower() == model.Adi.ToLower().Trim() && d.Soyadi.ToLower() == model.Soyadi.ToLower().Trim()))
                return new ErrorResult("Girilen ad ve soyada sahip doktor bulunmaktadır!");

            Doktor entity = new Doktor()
            {
                Adi = model.Adi.Trim(),
                Soyadi = model.Soyadi.Trim(),
                UzmanMi = model.UzmanMi,

                KlinikId = model.KlinikId, // 1 to many

                // 1 to many
                // 1. yöntem:
                //BransId = model.BransId.Value,
                // 2. yöntem:
                BransId = model.BransId ?? 0,

                // many to many: doktor eklerken veya güncellerken hasta seçmek mantıksız
                // çünkü zaten hasta ekleme ve güncelleme işlemlerinde doktor seçimi yapıyoruz,
                // sadece many to many örneği olması için doktor ekleme ve güncelleme işlemleri üzerinden
                // hasta seçimini gerçekleştireceğiz.
                DoktorHastalar = model.HastaIdleriInput?.Select(hastaId => new DoktorHasta()
                {
                    HastaId = hastaId,
                }).ToList()
            };

            db.Add(entity);
            db.SaveChanges();

            model.Id = entity.Id;

            return new SuccessResult("Doktor başarıyla eklendi.");
        }

        public Result Update(DoktorModel model)
        {
            if (db.Doktorlar.Any(d => d.Adi.ToLower() == model.Adi.ToLower().Trim() && d.Soyadi.ToLower() == model.Soyadi.ToLower().Trim()
                && d.Id != model.Id))
            {
                return new ErrorResult("Girilen ad ve soyada sahip doktor bulunmaktadır!");
            }

            Doktor entity = db.Doktorlar.Include(d => d.DoktorHastalar).SingleOrDefault(d => d.Id == model.Id);
            if (entity is null)
                return new ErrorResult("Doktor bulunamadı!");

            // ilişkili many to many kayıtların silinmesi
            if (entity.DoktorHastalar.Any())
                db.RemoveRange(entity.DoktorHastalar);

            entity.Adi = model.Adi.Trim();
            entity.Soyadi = model.Soyadi.Trim();
            entity.UzmanMi = model.UzmanMi;
            entity.KlinikId = model.KlinikId; // 1 to many
            entity.BransId = model.BransId ?? 0; // 1 to many

            // ilişkili many to many kayıtların oluşturulması
            entity.DoktorHastalar = model.HastaIdleriInput?.Select(hastaId => new DoktorHasta() // many to many
            {
                HastaId = hastaId,
            }).ToList();

            db.Update(entity);
            db.SaveChanges();

            return new SuccessResult("Doktor başarıyla güncellendi.");
        }

        public Result Delete(int id)
        {
            Doktor entity = db.Doktorlar.Include(d => d.DoktorHastalar).SingleOrDefault(d => d.Id == id);
            if (entity is null)
                return new ErrorResult("Doktor bulunamadı!");

            // ilişkili many to many kayıtların silinmesi
            if (entity.DoktorHastalar.Any())
                db.RemoveRange(entity.DoktorHastalar);

            db.Remove(entity);
            db.SaveChanges();

            return new SuccessResult("Doktor başarıyla silindi.");
        }
    }
}