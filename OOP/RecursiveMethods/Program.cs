

namespace RecursiveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display(1, 10);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            int? found = Find(list, 3);

            if(found.HasValue) // found is not null, found != null
            {
                Console.WriteLine(found.Value + " bulundu.");
            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }
        }

        private static int? Find(List<int> list, int itemToBeFound, int? result = null) // Nullable<int> result = null
        {
            if (list[0] == itemToBeFound)
            {
                result = list[0];
            }
            else
            {
                list.RemoveAt(0);
                if (list.Count > 0)
                    result = Find(list, itemToBeFound);
            }
            return result;
        }

        static void Display(int start, int end, int increment = 1)
        {
            if (start > end)
            {
                return;
            }
            Console.WriteLine(start);
            start += increment;
            Display(start, end, increment);
        }


    }
}
