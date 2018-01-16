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
                Console.Write("{0}", s);
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

        static int[,] VvDvumMasRan(int n)
        {
            int[,] b = new int[n, n];
            int i, j;
            Random r = new Random();
            for (i = 0; i < n; i++)
            for (j = 0; j < n; j++) b[i, j] = r.Next(11);
            return b;
        }

        static int[,] VvDvumMasVr(int n)
        {
            int i, j = 0, i1 = 0, j1 = 0, i2 = 0, k;
            int[,] b = new int[n, n];

            for (k = 1; k <= n * n; k++)
            {
                Console.Clear();
                Console.WriteLine("Массив: ");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++) if (i < i2 || i == i2 && j < j1) Console.Write("{0} ", b[i, j]);
                        else if (i == i2 && j == j1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("0 ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else Console.Write("0 ");
                    Console.WriteLine();
                }
                b[i1, j1] = ReadInt("Введите целое число: ");
                if (j1 < n - 1) j1++;
                else
                {
                    i1++;
                    j1 = 0;
                    i2++;
                }
            }
            return b;
        }

        static void OutMas(int[,] b, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++) Console.Write("{0} ", b[i, j]);
                Console.WriteLine();
            }
        }

        static void OutMas(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++) Console.Write("{0} ", a[i]);
        }

        static int[] Func(int[,] m, int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool ok = false;
                int j = 0;
                while (j < n - 1 && m[i,j]<m[i,j+1])
                {
                    j++;
                }

                while (j < n - 1 && m[i, j] > m[i, j + 1])
                {
                    j++;
                    ok = true;
                }

                if (j==n-1 && ok) b[i] = 1;
                else b[i] = 0;
            }
            return b;
        }

        static void Main(string[] args)
        {
            int n = ReadInt("n="), v;
            while (n < 2)
            {
                Console.WriteLine("Ошибка ввода. n должно быть >=2");
                Console.ReadLine();
                Console.Clear();
                n = ReadInt("n=");
            }

            Console.Clear();

            int[,] m = new int[n, n];
            int[] b = new int[n];

            do
            {
                v = ReadInt("Массив заполнить автоматически?\n1. Да\n2. Нет\nВвод: ");
                if (v < 1 || v > 2)
                {
                    Console.WriteLine("Ошибка ввода. Ожидался ввод 1 или 2. Нажмите любуй кнопку и повторите ввод.");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (v < 1 || v > 2);
            if (v == 1) m = VvDvumMasRan(n);
            else m = VvDvumMasVr(n);
            Console.Clear();

            b=Func(m, b, n);

            OutMas(m,n);
            Console.WriteLine();
            Console.Write("Последовательность b: ");
            OutMas(b,n);
            

            Console.ReadLine();
        }
    }
}
