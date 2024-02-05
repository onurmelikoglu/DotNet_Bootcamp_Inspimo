
using Business.Models;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Results.Bases;
using DataAccess.Results;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{

    public interface IBransService
    {
        IQueryable<BransModel> Query();

        Result Add(BransModel model);
        Result Update(BransModel model);
        Result Delete(int id);
    }
    public class BransService : IBransService
    {
        // Branş (1) ile doktor (*, m) arasında 1 to many ilişki bulunaktadır genelde 1 to many ilişkiler  1 olan taraf üzerinden yönetilmez. Many olan taraf (Doktor) üzerinden yönetilir

        private readonly Db db;

        public BransService(Db db)
        {
            this.db = db;
        }
        public IQueryable<BransModel> Query()
        {
            return db.Branslar.Include(b => b.Doktorlar).OrderByDescending(b => b.Doktorlar.Count).ThenBy(b => b.Adi)
                 .Select(b => new BransModel()
                 {
                     // entity özellikleri
                     Adi = b.Adi,
                     Guid = b.Guid,
                     Id = b.Id,

                     // ekstra 1 to many ilişki özellikleri
                     DoktorlarOutput = string.Join("<br />", b.Doktorlar.OrderBy(b => b.Adi).ThenBy(b => b.Soyadi).Select(b => b.Adi + " " + b.Soyadi)),
                     DoktorlarInput = b.Doktorlar.Select(d => d.Id).ToList()
                 });
        }

        public Result Add(BransModel model)
        {
            if (db.Branslar.Any(b => b.Adi.ToLower() == model.Adi.ToLower().Trim()))
                return new ErrorResult("Girilen branş adına sahip branş bulunmaktadır!");

            var entity = new Brans()
            {
                // entity özellikleri
                Adi = model.Adi.Trim(),
                Guid = Guid.NewGuid().ToString(),

                // entity 1 to many ilişki özellikleri
                Doktorlar = db.Doktorlar.Where(d => model.DoktorlarInput.Contains(d.Id)).ToList()
            };

            db.Branslar.Add(entity);
            db.SaveChanges();

            return new SuccessResult("Branş başarıyla eklendi.");
        }

        public Result Update(BransModel model)
        {
            if (db.Branslar.Any(b => b.Adi.ToLower() == model.Adi.ToLower().Trim() && b.Id != model.Id))
                return new ErrorResult("Girilen branş adına sahip branş bulunmaktadır!");

            var entity = db.Branslar.SingleOrDefault(b => b.Id == model.Id);
            if (entity is null)
                return new ErrorResult("Branş bulunamadı!");

            // entity özellikleri
            entity.Adi = model.Adi.Trim();

            // entity 1 to many ilişki özellikleri
            entity.Doktorlar = db.Doktorlar.Where(d => model.DoktorlarInput.Contains(d.Id)).ToList();

            db.Branslar.Update(entity);
            db.SaveChanges();

            return new SuccessResult("Branş başarıyla güncellendi.");
        }

        public Result Delete(int id)
        {
            var entity = db.Branslar.Include(b => b.Doktorlar).SingleOrDefault(b => b.Id == id);
            if (entity is null)
                return new ErrorResult("Branş bulunamadı!");

            if (entity.Doktorlar.Any())
                return new ErrorResult("Branşın ilişkili doktorları bulunmaktadır!");

            db.Branslar.Remove(entity);
            db.SaveChanges();

            return new SuccessResult("Branş başarıyla silindi.");
        }
    }
}
