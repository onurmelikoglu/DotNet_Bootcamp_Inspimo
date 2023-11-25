using System.Globalization;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sehir1 = "Ankara";
            //Console.WriteLine(sehir1[0]); // A

            //foreach (char c in sehir1)
            //{
            //    Console.WriteLine(c);
            //}

            //string word = "YAZILIM";
            //string reversed = "";

            //for(int i = 6; i >= 0; i--)
            //{
            //    reversed += word[i];
            //}

            //Console.WriteLine(reversed);

            //string sehir2 = "İstanbul";
            //string sehir3 = sehir1 + " " + sehir2; // concatenation: Ankara İstanbul
            // Console.WriteLine(sehir3);

            //string sehir4 = string.Format("{0} {1}", sehir2, sehir1);
            //Console.WriteLine(sehir4);

            //string sehir5 = "İzmir";
            //Console.WriteLine($"Egenin incisi: {sehir5}");

            //string isim1 = "Çağıl Alsaç";
            //int isimlength = isim1.Length;
            //Console.WriteLine(isimlength);

            //string isim2 = isim1.Replace("Çağıl","Leo");
            //Console.WriteLine(isim2);

            // "Leo".Equals("Leo", StringComparison.OrdinalIgnoreCase);
            //if ("leo" == "Leo")
            //    Console.WriteLine("eşit");
            //else
            //    Console.WriteLine("Eşit Değil");

            //string isim3 = "Bill Gates";
            //if(isim3.StartsWith("Bill"))
            //    Console.WriteLine("Evet");
            //else
            //    Console.WriteLine("Yok");

            //if(isim3.Contains("ga", StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("isim ga içeriyor");
            //else
            //    Console.WriteLine("içermiyor");

            //if(isim3.EndsWith("ate"))
            //    Console.WriteLine("isim ate ile bitiyor");

            // metinsel veri girişi, tekil olup olmadığı kontrol edilecek harf
            // eğer harf kelime tekil ise kontrol tekil, tekil değil ise konsola tekil değil
            // harf kelimede yoksa konsola bulunamadı
            //Console.Write("Kelime: "); // baba
            //string kelime = Console.ReadLine();
            //Console.Write("Harf: ");
            //string harf = Console.ReadLine();

            // 1. yöntem: 
            //int harfSayisi = 0;
            //foreach(char h in kelime)
            //{
            //    if(h.ToString() == harf)
            //    {
            //        harfSayisi++;
            //        if (harfSayisi > 1) break;
            //    }
            //}

            //if(harfSayisi == 0)
            //{
            //    Console.WriteLine("Harf Bulunamadı");
            //}else if(harfSayisi == 1)
            //{
            //    Console.WriteLine("Harf tekildir");
            //}
            //else
            //{
            //    Console.WriteLine("Harf tekil değildir");
            //}

            // 2. yöntem

            //int harfIndex = kelime.IndexOf(harf); // 0, 1
            //int harfLastIndex = kelime.LastIndexOf(harf); // 2,3

            //if(harf == "")
            //{
            //    Console.WriteLine("Harf girmediniz");
            //}
            //else
            //{
            //    if (harfIndex == -1)
            //    {
            //        Console.WriteLine("Harf tekil değildir");
            //    }
            //    else if (harfIndex == harfLastIndex)
            //    {
            //        Console.WriteLine("Harf tekildir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Harf bulunamadı");
            //    }
            //}

            string mesaj = "Dünya";
            mesaj = mesaj.Insert(5, "!"); // Dünya!
            // mesaj = mesaj.Insert(0, "Merhaba"); // Merhaba Dünya!
            mesaj = "Merhaba " + mesaj;
            mesaj = mesaj.Insert(8, "Güzel "); // Merhaba Güzel Dünya!
            Console.WriteLine(mesaj);

            mesaj = mesaj.Remove(8, 6); // Merhaba Dünya!
            mesaj = mesaj.Remove(13); // Merhaba Dünya
            Console.WriteLine(mesaj);

            // A123456-7, A : bireysel, B: kurumsal, C: ..., 123456: Bina no, 7: Daire No
            string aboneNo, aboneTipi, binaNo, daireNo;
            Console.Write("Abone No: (ç: çıkış)");
            aboneNo = Console.ReadLine().ToUpper();

            while(aboneNo != "Ç")
            {
                // aboneTipi = aboneNo[0] == 'A' ? "Bireysel" : "kurumsal";
                // aboneTipi = aboneNo.StartsWith('A') ? "Bireysel" : "kurumsal";
                aboneTipi = aboneNo.Substring(0, 1) == "A" ? "Bireysel" : "kurumsal";
                binaNo = aboneNo.Substring(1, 6);
                // daireNo = aboneNo.Substring(8, aboneNo.Length - 8);
                daireNo = aboneNo.Substring(8);
                Console.WriteLine($"Tipi: {aboneTipi}, Bina No: {binaNo}, Daire No: {daireNo}");
                Console.Write("Abone No: (ç: çıkış)");
                aboneNo = Console.ReadLine().ToUpper();

            }

            string ulke = "Türkiye";
            Console.WriteLine("Küçük harf: " + ulke.ToLower() + ", buyuk harf: " + ulke.ToUpper());

            //string cumle;
            //int index, ilkIndex, kelimeIndex;
            //int count;
            //string[] kelimeler;
            //bool boslukBulundu;
            //Console.Write("Cümle: (Ç: çıkış) ");
            //cumle = Console.ReadLine();

            // kelimeleri buldukça arraye ekle sonra cumleden remove et
            // Indexofu cok rahat kullanabilirsin


            //while (cumle.ToUpper() != "Ç")
            //{
            //    if (cumle != "")
            //    {
            //        count = 1;
            //        for (index = 0; index < cumle.Length; index++)
            //        {
            //            if (cumle[index] == ' ')
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine("Kelime sayısı: " + count);
            //        kelimeler = new string[count];
            //        kelimeIndex = 0;
            //        ilkIndex = 0;
            //        for(index = 0; index < cumle.Length; index++)
            //        {
            //            boslukBulundu = false;
            //            if (cumle[index] == ' ')
            //            {
            //                boslukBulundu = true;
                            
            //            }
            //            if (boslukBulundu)
            //            {
            //                kelimeler[kelimeIndex] = cumle.Substring(ilkIndex, index - ilkIndex);
            //                kelimeIndex++;
            //                ilkIndex = index + 1;
            //            }
            //            else
            //            {
            //                kelimeler[kelimeIndex] = cumle.Substring(ilkIndex);
            //            }
            //        }

            //        foreach(string k in kelimeler)
            //        {
            //            Console.WriteLine(k);
            //        }
            //    }
            //    Console.Write("Cümle: (Ç: çıkış) ");
            //    cumle = Console.ReadLine();
            //}

            //Console.Write("Cümle (Ç: çıkış)");
            //string yenicumle = Console.ReadLine();
            //string[] yenikelimeler;
            //while (yenicumle.ToLower() != "ç")
            //{
            //    yenikelimeler = yenicumle.Split(' ');
            //    foreach(string k in yenikelimeler)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    Console.Write("Cümle (Ç: çıkış)");
            //    yenicumle = Console.ReadLine();
            //}

            string ad = "Çağıl";
            string soyad = "Alsaç";
            string sonuc = "\"Çağıl\""; // "Çağıl"
            sonuc = "\"" + ad + "\"";
            Console.WriteLine(sonuc);

            sonuc = ad + "\n" + soyad;
            Console.WriteLine(sonuc);

            sonuc = ad + "\r\n" + soyad;

            string dosyaYolu = "C:\\Documents\\cagil.txt";
            Console.WriteLine(dosyaYolu); // C:\Documents\cagil.txt

            dosyaYolu = @"C:\Documents\cagil.txt";
            Console.WriteLine(dosyaYolu); // C:\Documents\cagil.txt

            char c = '\'';
            Console.WriteLine(c); // '


            string tamAd = " Çağıl Alsaç ";
            Console.WriteLine("\"" + tamAd + "\"");
            Console.WriteLine("\"" + tamAd.Trim() + "\""); // TÜm boşlukları temizler
            Console.WriteLine("\"" + tamAd.TrimStart() + "\""); // Baştaki boşlukları temizler
            Console.WriteLine("\"" + tamAd.TrimEnd() + "\""); // Sondaki boşlukları temizler

            string diller = "C#, Java, Python, ";
            string trimlenmisDiller = diller.Trim(',',' ');
            Console.WriteLine(trimlenmisDiller);

            int ogrenciNo = 123456;
            string ogrenciNoYazi = ogrenciNo.ToString();
            Console.WriteLine(ogrenciNo);

            bool dogruMu = true;
            Console.WriteLine(dogruMu.ToString()); // True

            int[] sayilar = { 1, 2, 3 };
            Console.WriteLine(sayilar.ToString()); // System.Int32[]

            int gun = 5;
            int ay = 11;
            int yil = 2023;
            Console.WriteLine("Tarih: " + gun + "." + ay + "." + yil); // 5.11.2023
            Console.WriteLine($"Formatlanmış Tarih: {TarihGetir(gun, ay, yil)}");

            Console.WriteLine($"Formatlanmış Tarih: {gun.ToString().PadLeft(2,'0')}." +
                $"{ay.ToString().PadLeft(2,'0')}." +
                $"{yil}");

            string message = "To be continued";
            Console.WriteLine(message.PadRight(18,'.'));

            double sayi1 = 12.34;
            string forSayi1;
            forSayi1 = sayi1.ToString(); // "12,34"
            forSayi1 = sayi1.ToString("N0", new CultureInfo("tr-TR"));
            Console.WriteLine(forSayi1);

            forSayi1 = sayi1.ToString("C1", new CultureInfo("en-US")); // $12.3

            Console.WriteLine(forSayi1);

            double sayi2 = 123.456;
            string forSayi2 = string.Format(new CultureInfo("tr-TR"), "{0,7:N1}", sayi2);
            Console.WriteLine(forSayi2);

            forSayi2 = string.Format(new CultureInfo("en-US"), "{0:C2}", sayi2);
            Console.WriteLine(forSayi2);

            // TC kimlik doğrulama algoritmasını yap

        }

        static string TarihGetir(int gun, int ay, int yil)
        {
            string tarih;
            string gunString = gun.ToString();
            string ayString = ay.ToString();

            if (gunString.Length == 1)
                gunString = "0" + gunString;
            if (ayString.Length == 1)
                ayString = "0" + ayString;
            tarih = gunString + "." + ayString + "." + yil;
            return tarih;
        }

    }
   
}
