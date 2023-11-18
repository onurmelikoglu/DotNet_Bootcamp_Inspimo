namespace ForLoopDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(char i = 'A';  i <= 'z';  i++)
            {
                if(i <= 'Z')
                {
                    Console.Write((char)i + " ");
                }
                else if(i >= 'a')
                {
                    Console.Write((char)i + " ");
                }
                
            }

            for (char c = 'A'; c <= 'z'; c++)
            {
                //1. çözüm:
                if (c <= 'Z' || c >= 'a')
                {
                    Console.Write(c + " ");
                }

                //2. çözüm:

            }
        }
    }
}
