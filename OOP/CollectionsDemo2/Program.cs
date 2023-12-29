namespace CollectionsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            string giris, bulunanIsim = "";

            Console.Write("Eklenecek isim: (ç: çıkış) ");
            giris = Console.ReadLine();

            while(giris != "ç")
            {
                isimler.Add(giris);
                Console.Write("Eklenecek isim: (ç: çıkış) ");
                giris = Console.ReadLine();
            }

            if(isimler.Count > 0)
            {
                Console.Write("Arama işlemi: (t: tam isim, p: isim parçası, ç: çıkış) ");
                giris = Console.ReadLine();

                // ali, Veli, Ayşe - Ali
                while (giris != "ç")
                {
                    if (giris == "t" || giris == "p")
                    {
                        bulunanIsim = string.Empty;
                        if (giris == "t")
                        {
                            Console.Write("Aranacak isim: ");
                            giris = Console.ReadLine();

                            //1. yöntem
                            //foreach(string isim in isimler)
                            //{
                            //    if(isim == giris)
                            //    {
                            //        bulunanIsim = isim;
                            //        Console.WriteLine("İsim bulundu");
                            //        break;
                            //    }
                            //}
                            // 2. yöntem: 
                            int bulunanIsimIndex = isimler.IndexOf(giris);
                            if (bulunanIsimIndex != -1)
                                bulunanIsim = isimler[bulunanIsimIndex];

                        }
                        else
                        {
                            Console.Write("Aranacak isimin parçasını gir: ");
                            giris = Console.ReadLine();
                            foreach (string isim in isimler)
                            {
                                if (isim.Contains(giris))
                                {
                                    bulunanIsim = isim;
                                    break;
                                }
                            }
                        }

                        // 1. yöntem
                        if (bulunanIsim == string.Empty)
                            Console.WriteLine("aranan isim bulunamadı!");
                        else
                            Console.WriteLine($"Aranan isim bulundu: \"{bulunanIsim}\" ");
                    }


                    Console.Write("Arama işlemi: (t: tam isim, p: isim parçası, ç: çıkış) ");
                    giris = Console.ReadLine();
                }

            }


        }
    }
}
