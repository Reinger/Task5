using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static int ReadInt(string s)
        {
            int k;
            bool ok;

            do
            {
                Console.Write("{0}",s);
                ok = Int32.TryParse(Console.ReadLine(), out k);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!ok);

            return k;
        }

        static void Main(string[] args)
        {
            int n = ReadInt("n=");
            while (n < 2)
            {
                Console.WriteLine("Ошибка ввода. n должно быть >=2");
                Console.ReadLine();
                Console.Clear();
                n = ReadInt("n=");
            }

            Console.Clear();

            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                m[i, j] = ReadInt("m["+i+","+j+"]=");
                Console.Clear();
            }
        }
    }
}
