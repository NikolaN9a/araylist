using System.Collections;

namespace araylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ArrayList list = new ArrayList() { "Anna", 25, "Boris", 18, "Maria", 32, "Ivan" };

            // 1. Извежда само имената
            Console.WriteLine("Имена:");
            foreach (object item in list)
            {
                if (item is string)
                {
                    Console.WriteLine(item);
                }
            }

            // 2, 3 и 4: сума, максимум и брой имена (само с променливи, без втори списък)
            int sum = 0;
            int max = int.MinValue;
            int nameCount = 0;

            foreach (object item in list)
            {
                if (item is int number)
                {
                    sum += number;
                    if (number > max)
                    {
                        max = number;
                    }
                }
                else if (item is string)
                {
                    nameCount++;
                }
            }

            Console.WriteLine("Сума на числата: " + sum);
            Console.WriteLine("Най-голямо число: " + max);
            Console.WriteLine("Брой имена: " + nameCount);
        }
    }
}
