using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static int ReadInt()
        {
            int k;
            bool ok;

            do
            {
                Console.Write("n=");
                ok = Int32.TryParse(Console.ReadLine(), out k);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (k < 2)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число >=2");
                    Console.ReadLine();
                    Console.Clear();
                    ok = false;
                }
            } while (!ok);

            return k;
        }

        static void Main(string[] args)
        {
            int n = ReadInt();
        }
    }
}
