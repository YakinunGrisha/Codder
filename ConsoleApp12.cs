using System;

namespace ConsoleApp10
{
    class MyProgram
    {
        static void Main(string[] args)
        {  
         string aa, bb, cc, dd, ff, gg, hh;
         int a =  1356, b = 4813, c = 9075, d = 3272, f = 6390, g = 15684, h = 53206;
         aa = (a % 3 == 0) ? "Делится" : "Не делится";
         bb = (b % 3 == 0) ? "Делится" : "Не делится";
         cc = (c % 3 == 0) ? "Делится" : "Не делится";
         dd = (d % 3 == 0) ? "Делится" : "Не делится";
         ff = (f % 3 == 0) ? "Делится" : "Не делится";
         gg = (g % 3 == 0) ? "Делится" : "Не делится";
         hh = (h % 3 == 0) ? "Делится" : "Не делится";
         Console.WriteLine(aa);
         Console.WriteLine(bb);
         Console.WriteLine(cc);
         Console.WriteLine(dd);
         Console.WriteLine(ff);
         Console.WriteLine(gg);
         Console.WriteLine(hh);
        }
    }
}
