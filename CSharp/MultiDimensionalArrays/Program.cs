namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bolgeler = { "Marmara", "İç Anadolu", "Ege" };
            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };

            for(int i = 0; i <  bolgeler.Length; i++)
            {
                Console.WriteLine("Bölge: " + bolgeler[i] + " -> Şehir: " + sehirler[i] );
            }

            //string[,] bolgelerVeSehirler = new string[3, 2];
            //bolgelerVeSehirler[0,0] = "Marmara";
            //bolgelerVeSehirler[0,1] = "İstanbul";
            //bolgelerVeSehirler[1,0] = "İç Anadolu";
            //bolgelerVeSehirler[1,1] = "Ankara";
            //bolgelerVeSehirler[2,0] = "Ege";
            //bolgelerVeSehirler[2,1] = "İzmir";
            string[,] bolgelerVeSehirler = new string[3, 2]
            {
                { "Marmara", "İstanbul"},
                { "İç Anadolu", "Ankara" },
                { "Ege", "İzmir" },
            };
            Console.WriteLine($"Bölge: {bolgelerVeSehirler[1,0]} -> Şehir: {bolgelerVeSehirler[1,1]}");

            for(int satir = 0;satir <= bolgelerVeSehirler.GetUpperBound(0);satir++)
            {
                Console.Write("Bölge ve Şehir: ");
                for (int sutun = 0;sutun <= bolgelerVeSehirler.GetUpperBound(1); sutun++)
                {
                    Console.Write($"{bolgelerVeSehirler[satir,sutun]} ");
                }
                Console.WriteLine();
            }

            /*
            1. başla
            2. kullanıcı adı alınır
            3. şifre alınır
            4. iki boyutlu diziyi tarayarak girilen kullanıcı adı ve şifreli satır var mı bakılır
            5. eğer varsa hoşgeldin kullanıcı yazdırılır
            6. yoksa kullanıcı adı veya şifre hatalı yazdırılır
            7. bitir
            */

        }
    }
}
