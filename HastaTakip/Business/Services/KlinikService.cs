
using Business.Models;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Results;
using DataAccess.Results.Bases;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{
    public interface IKlinikService
    {
        IQueryable<KlinikModel> Query();

        Result Add(KlinikModel model);
        Result Update(KlinikModel model);
        Result Delete(int id);

        KlinikModel GetItem(int id);
        List<KlinikModel> GetList();
    }
    public class KlinikService : IKlinikService
    {
        private readonly Db db;

        public KlinikService(Db db)
        {
            this.db = db;
        }

        public IQueryable<KlinikModel> Query()
        {
            return db.Klinikler.OrderBy(klinik => klinik.Adi).Select(klinik => new KlinikModel
            {
                // entity özellikleri
                Id = klinik.Id,
                Adi = klinik.Adi,
                Aciklamasi = klinik.Aciklamasi,
                Guid = klinik.Guid,

                // ekstra özellikler
                DoktorSayisiOutput = klinik.Doktorlar.Count,

                DoktorlarOutput = string.Join("<br/>", klinik.Doktorlar.Select(doktor => doktor.Adi + " " + doktor.Soyadi))
        }); // klinik : her bir klinik eleman delegesi
        }

        //public KlinikModel GetItem(int id)
        //{
        //    // 1. yöntem
        //    // Klinik entity = db.Klinikler.Find(id);
        //    // 2. yöntem
        //    // Klinik entity = db.Klinikler.Include("Doktorlar").SingleOrDefault(k => k.Id == id);

        //    Klinik entity = db.Klinikler.Include(k => k.Doktorlar).SingleOrDefault(k => k.Id == id);


        //    if (entity is null)
        //    {
        //        return null;
        //    }

        //    // 1. yöntem
        //    //string doktorlar = string.Empty; // ""
        //    //foreach(Doktor doktor in entity.Doktorlar)
        //    //{
        //    //    doktorlar += doktor.Adi + " " + doktor.Soyadi + "<br/>";
        //    //}
        //    //doktorlar = doktorlar.TrimEnd("<br/>".ToCharArray());

        //    // 2. yöntem
        //    string doktorlar = string.Join("<br/>", entity.Doktorlar.Select(doktor => doktor.Adi + " " + doktor.Soyadi));

        //    KlinikModel model = new KlinikModel()
        //    {
        //        Aciklamasi = entity.Aciklamasi,
        //        Adi = entity.Adi,
        //        Guid = entity.Guid,
        //        Id = entity.Id,
        //        DoktorSayisiOutput = entity.Doktorlar.Count,
        //        DoktorlarOutput = doktorlar
        //    };
        //    return model;

        //}

        // 2. yöntem
        public KlinikModel GetItem(int id) => Query().SingleOrDefault(q => q.Id == id);

        public List<KlinikModel> GetList() => Query().ToList();

        public Result Add(KlinikModel model)
        {
            // 1.yöntem:
            //Klinik mevcutKlinik = db.Klinikler.SingleOrDefault(k => k.Adi.ToUpper() == model.Adi.ToUpper());

            //if(mevcutKlinik is not null)
            //{
            //    return new ErrorResult("Girilen klinik adına sahip klinik bulunmaktadır.");
            //}

            if (db.Klinikler.Any(k => k.Adi.ToLower() == model.Adi.ToLower()))
            {
                return new ErrorResult("Girilen klinik adına sahip klinik bulunmaktadır.");
            }

            Klinik entity = new Klinik()
            {
                Aciklamasi = model.Aciklamasi?.Trim(),
                Adi = model.Adi.Trim(),
                Guid = Guid.NewGuid().ToString(),

            };

            // 1. yöntem
            // db.Klinikler.Add(entity);

            // 2. yöntem
            db.Add(entity);
            db.SaveChanges();

            model.Id = entity.Id;

            return new SuccessResult("Klinik Başarıyla eklendi.");
        }

        public Result Update(KlinikModel model)
        {
            if (db.Klinikler.Any(k => k.Id != model.Id && k.Adi.ToLower() == model.Adi.ToLower()))
            {
                return new ErrorResult("Girilen ada sahip kayıt bulunmaktadır");
            }
            Klinik mevcutKlinik = db.Klinikler.SingleOrDefault(k => k.Id == model.Id);
            if(mevcutKlinik is null)
            {
                return new ErrorResult("Klinik bulunamadı");
            }
            mevcutKlinik.Aciklamasi = model.Aciklamasi?.Trim();
            mevcutKlinik.Adi = model.Adi.Trim();

            db.Update(mevcutKlinik);
            db.SaveChanges();

            return new SuccessResult("Klinik başarıyla güncellendi");
        }

        public Result Delete(int id)
        {
            Klinik mevcutKlinik = db.Klinikler.Include(k => k.Doktorlar).SingleOrDefault(k => k.Id == id);

            if(mevcutKlinik is null)
            {
                return new ErrorResult("Klinik bulunamadı");
            }

            if(mevcutKlinik.Doktorlar.Any())
            {
                return new ErrorResult("Kliniğin ilişkili doktorları bulunmaktadır");
            }

            db.Remove(mevcutKlinik);
            db.SaveChanges();

            return new SuccessResult("Klinik Silindi");
        }
    }
}
