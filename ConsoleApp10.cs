using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Как тебя зовут");
            Console.Write("");
            name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Программа закрыта потому что ты пидор");
                return;
            }
            else
            {
                Console.WriteLine(name);
                return;
            }
        }
    }
}
