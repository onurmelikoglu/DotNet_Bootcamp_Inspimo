namespace UserValidationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. başla
            2. kullanıcı adı alınır
            3. şifre alınır
            4. iki boyutlu diziyi tarayarak girilen kullanıcı adı ve şifreli satır var mı bakılır
            5. eğer varsa hoşgeldin kullanıcı yazdırılır
            6. yoksa kullanıcı adı veya şifre hatalı yazdırılır
            7. bitir
            */

            bool userFound = false;
            string[,] userList = new string[3,2]
            {
                { "onur", "123qwe"},
                { "ali", "123123" },
                { "veli", "qwe321" },
            };

            Console.Write("Kullanıcı Adı:");
            string username = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            for (int row = 0; row <= userList.GetUpperBound(0); row++)
            {
                if (username == userList[row,0] && password == userList[row, 1]) 
                {
                    userFound = true; break;
                }
            }

            if(userFound)
            {
                Console.WriteLine($"Hoşgeldin {username.ToUpper()}");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }


        }
    }
}
