﻿using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MVC.Controllers
{
    public class DbController : Controller
    {
        //Db db = new Db(); // DbContext tipindeki gibi objeler new'lenmez, sınıfa (controller) enjekte edilir

        private readonly Db db;

        public DbController(Db db)
        {
            this.db = db;
        }

        // ~/Db/Seed
        public IActionResult Seed()
        {
            #region Verilerin Silinmesi
            db.DoktorHastalar.RemoveRange(db.DoktorHastalar.ToList());
            db.Hastalar.RemoveRange(db.Hastalar.ToList());
            db.Doktorlar.RemoveRange(db.Doktorlar.ToList());
            db.Klinikler.RemoveRange(db.Klinikler.ToList());

            var branslar = db.Branslar.ToList();

            // 1. yöntem:
            //foreach (var brans in branslar)
            //{
            //    db.Branslar.Remove(brans);
            //}
            // 2. yöntem:
            db.Branslar.RemoveRange(branslar);

            db.Kullanicilar.RemoveRange(db.Kullanicilar.ToList());

            if (db.Roller.Count() > 0)
            {
                db.Roller.RemoveRange(db.Roller.ToList());
                db.Database.ExecuteSqlRaw("dbcc CHECKIDENT ('Roller', RESEED, 0)");
            }

            db.Sehirler.RemoveRange(db.Sehirler.ToList());
            db.Ulkeler.RemoveRange(db.Ulkeler.ToList());
            #endregion

            #region Verilerin Eklenmesi
            db.Branslar.Add(new Brans()
            {
                Adi = "Cerrahi",
                Guid = Guid.NewGuid().ToString()
            });
            db.Branslar.Add(new Brans()
            {
                Adi = "Psikiyatri",
                Guid = Guid.NewGuid().ToString()
            });

            db.Ulkeler.Add(new Ulke()
            {
                Adi = "Türkiye",
                Sehirler = new List<Sehir>()
                {
                    new Sehir()
                    {
                        Adi = "İstanbul"
                    },
                    new Sehir()
                    {
                        Adi = "İzmir"
                    },
                    new Sehir()
                    {
                        Adi = "Ankara"
                    }
                }
            });
            db.Ulkeler.Add(new Ulke()
            {
                Adi = "Amerika Birleşik Devletleri",
                Sehirler = new List<Sehir>()
                {
                    new Sehir()
                    {
                        Adi = "Los Angeles"
                    },
                    new Sehir()
                    {
                        Adi = "New York"
                    }
                }
            });

            db.Hastalar.Add(new Hasta()
            {
                Adi = "Çağıl",
                Boyu = 1.75m,
                Cinsiyeti = Cinsiyetler.Erkek,
                DogumTarihi = DateTime.Parse("01.05.1980", new CultureInfo("tr-TR")),
                Guid = Guid.NewGuid().ToString(),
                Kilosu = 55,
                KimlikNo = "12345678901",
                Soyadi = "Alsaç"
            });
            db.Hastalar.Add(new Hasta()
            {
                Adi = "Leo",
                Boyu = 0.4M,
                Cinsiyeti = Cinsiyetler.Erkek,
                DogumTarihi = new DateTime(2014, 5, 29),
                Guid = Guid.NewGuid().ToString(),
                Kilosu = 10,
                Soyadi = "Alsaç"
            });
            db.Hastalar.Add(new Hasta()
            {
                Adi = "Luna",
                Boyu = 0.5M,
                Cinsiyeti = Cinsiyetler.Kadın,
                DogumTarihi = DateTime.Parse("09/20/2022", new CultureInfo("en-US")),
                Guid = Guid.NewGuid().ToString(),
                Kilosu = 11,
                Soyadi = "Alsaç"
            });

            db.SaveChanges(); // unit of work

            db.Klinikler.Add(new Klinik()
            {
                Aciklamasi = "Ankara Çankaya'da özel bir poliklinik.",
                Adi = "Özel Çankaya Polikliniği",
                Guid = Guid.NewGuid().ToString(),
                Doktorlar = new List<Doktor>()
                {
                    new Doktor()
                    {
                        Guid = Guid.NewGuid().ToString(),
                        Adi = "Ali",
                        Soyadi = "Vefa",
                        //UzmanMi = false, // default false

                        // 1. yöntem:
                        //Brans = db.Branslar.SingleOrDefault(brans => brans.Adi == "Cerrahi"),
                        // 2. yöntem:
                        BransId = db.Branslar.SingleOrDefault(brans => brans.Adi == "Cerrahi").Id,

                        DoktorHastalar = new List<DoktorHasta>()
                        {
                            new DoktorHasta()
                            {
                                HastaId = db.Hastalar.SingleOrDefault(hasta => hasta.Adi == "Çağıl" && hasta.Soyadi == "Alsaç").Id
                            },
                            new DoktorHasta()
                            {
                                HastaId = db.Hastalar.SingleOrDefault(hasta => hasta.Adi == "Leo" && hasta.Soyadi == "Alsaç").Id
                            }
                        },

                        UlkeId = db.Ulkeler.SingleOrDefault(u => u.Adi == "Türkiye").Id,
                        SehirId = db.Sehirler.SingleOrDefault(s => s.Adi == "İstanbul").Id
                    },
                    new Doktor()
                    {
                        Guid = Guid.NewGuid().ToString(),
                        Adi = "Ferman",
                        Soyadi = "Eryiğit",
                        UzmanMi = true,
                        BransId = db.Branslar.SingleOrDefault(brans => brans.Adi == "Cerrahi").Id,
                        DoktorHastalar = new List<DoktorHasta>()
                        {
                            new DoktorHasta()
                            {
                                HastaId = db.Hastalar.SingleOrDefault(hasta => hasta.Adi == "Luna" && hasta.Soyadi == "Alsaç").Id
                            },
                            new DoktorHasta()
                            {
                                HastaId = db.Hastalar.SingleOrDefault(hasta => hasta.Adi == "Leo" && hasta.Soyadi == "Alsaç").Id
                            }
                        },
                        UlkeId = db.Ulkeler.SingleOrDefault(u => u.Adi == "Türkiye").Id,
                        SehirId = db.Sehirler.SingleOrDefault(s => s.Adi == "İstanbul").Id
                    },
                    new Doktor()
                    {
                        Guid = Guid.NewGuid().ToString(),
                        Adi = "Gülseren",
                        Soyadi = "Budayıcıoğlu",
                        UzmanMi = true,
                        BransId = db.Branslar.SingleOrDefault(brans => brans.Adi == "Psikiyatri").Id,
                        UlkeId = db.Ulkeler.SingleOrDefault(u => u.Adi == "Amerika Birleşik Devletleri").Id,
                        SehirId = db.Sehirler.SingleOrDefault(s => s.Adi == "Los Angeles").Id
                    }
                }
            });

            db.Roller.Add(new Rol()
            {
                Adi = "admin",
                Guid = Guid.NewGuid().ToString(),
                Kullanicilar = new List<Kullanici>()
                {
                    new Kullanici()
                    {
                        AktifMi = true,
                        Guid = Guid.NewGuid().ToString(),
                        KullaniciAdi = "cagil",
                        Sifre = "cagil"
                    }
                }
            });
            db.Roller.Add(new Rol()
            {
                Adi = "kullanıcı",
                Guid = Guid.NewGuid().ToString(),
                Kullanicilar = new List<Kullanici>()
                {
                    new Kullanici()
                    {
                        AktifMi = true,
                        Guid = Guid.NewGuid().ToString(),
                        KullaniciAdi = "leo",
                        Sifre = "leo"
                    }
                }
            });

            db.SaveChanges();
            #endregion

            return Content("<label style=\"color:red;\">Database seed successful.</label>", "text/html");
        }
    }
}