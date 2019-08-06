using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace interview_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAsc(100);
            Console.WriteLine("------------------");
            PrintDesc(100);
            Console.WriteLine("------------------");
            Console.Write("Enter the n value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Total value is: ");
            Console.WriteLine(Sum(n).ToString());

            Console.Write("Total value is (Sum_A): ");
            Console.WriteLine(Sum_A(n).ToString());
            Console.Write("Total value is (Sum_B): ");
            Console.WriteLine(Sum_B(n).ToString());

            Console.ReadKey();
            

        }

        //1.2 method ascending order

        static void PrintAsc(int n) {
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(i.ToString());
            }

        }

        //1.3 method descending order

        static void PrintDesc(int n)
        {            
            while(n>0)
            {
                Console.WriteLine(n.ToString());
                n--;
            }

        }

        //1.4 method sum of numbers from 1 to n

        static int Sum(int n)
        {
            int total = 0;
            for (int i=1; i<=n; i++)
            {
                total += i;
                
            }
            return total;
        }

        //1.5.1 method sum of numbers from 1 to n by LİNQ

        static int Sum_A(int n)
        {
            return Enumerable.Range(1, n).Sum();
        }

        //1.5.2 method sum of numbers from 1 to n by O(1)

        static int Sum_B(int n)
        {
            return n * (n + 1) / 2;
        }


    }


}
