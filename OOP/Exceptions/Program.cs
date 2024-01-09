namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] ogrenciler = new string[3];
                ogrenciler[0] = "Çağıl";
                ogrenciler[1] = "Leo";
                ogrenciler[2] = "Luna";

                // ogrenciler[3] = "Lassie";
                foreach(var ogrenci in ogrenciler)
                {
                    Console.WriteLine(ogrenci);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hata");
            }

            try
            {
                int s1 = 13;
                int s2 = 0;
                int sonuc = s1 / s2;
                Console.WriteLine(sonuc);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                if(e.InnerException is not null)
                {
                    Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                }
            }
        }
    }
}
