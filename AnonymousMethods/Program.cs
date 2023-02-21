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
            Mass mass = Maxt(array => array.Max());
            Console.WriteLine(mass);



        }
        private static bool DayProgram(int a, Mydel mydel3)
        {
            return true;
        }
        private static int Maxt(Mass mydel3)
        {
            return mydel3.Max();
        }
    }
}
