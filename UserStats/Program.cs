using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStats
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            User[] arr;
            arr = new User[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = new User();

                Console.Write("First Name: ");
                arr[i].FirstName = Console.ReadLine();
                Console.Write("First Name: ");
                arr[i].LastName = Console.ReadLine();
                Console.Write("First Name: ");
                arr[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("First Name: ");
                arr[i].City = Console.ReadLine();
            }
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                if (arr[i].Age > 18)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            double avrg = 0;
            for (int i = 0; i < a; i++)
            {
                avrg += arr[i].Age;
            }
            Console.WriteLine($"Average age is {Math.Round(avrg/a,3)}");
        }
    }
}
