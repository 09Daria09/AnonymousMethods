using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        delegate bool Mydel(int x);
        delegate double DelPow(int x);
        delegate int Mass(int[] x);
        delegate void ArrInt(int[] arr);
        static void Main(string[] args)
        {
            //1
            Mydel mydel = delegate (int a)
            {
                return a % 2 == 0;
            };
            Console.WriteLine(mydel(12));
            //2
            DelPow mydel1 = delegate (int a)
            {
                return Math.Pow(a, 2);
            };
            Console.WriteLine(mydel1(12));
            //3
            DelPow mydel2 = a => Math.Pow(a, 3);
            Console.WriteLine(mydel2(12));
            //4
            int b = 5;
            bool res = DayProgram(b, x => x == 256);
            Console.WriteLine(res);
            //5
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            Mass Max = array1 => array1.Max();
            Console.WriteLine(Max(array));
            //6
            Mass Min = array1 => array1.Min();
            Console.WriteLine(Min(array));
            //7
            ArrInt Odd = array4 =>
            {
                for (int i = 0; i < array4.Length; i++)
                {
                    if (array[i] % 2 != 0) Console.Write(array4[i] + "\t");
                }
            };
            Odd(array);
        }
        private static bool DayProgram(int a, Mydel mydel3)
        {
            return true;
        }
       
    }
}
