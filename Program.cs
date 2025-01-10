using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DOTNET
{
    public class Program
    {
        public static void hoanvi(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        public static void A(out int c){
            c = 5;
        }
        public static void Main()
        {
            int m, n, t;
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            hoanvi(ref m, ref n);
            Console.WriteLine("m = {0}, n = {1}", m, n);
            A(out t);
            Console.WriteLine("t = {0}", t);
        }
    }
}