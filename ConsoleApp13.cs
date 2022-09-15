using System;

namespace ConsoleProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bb, c;
            string a, b;
            Console.Title = ("Автозаполняющий паспорт");
            Console.WriteLine("Как вас зовут");
            Console.Write("");
            a = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет");
            Console.Write("");
            b = Console.ReadLine();
            if (b == "") 
            {
                Console.WriteLine("Ты не написал сколько тебе лет программа закрыта");
                return;
            }
            bb = Int32.Parse(b);
            if (bb < 200000)
            {
                Console.WriteLine("В каком году ты родился");
                Console.Write("");
                c = Int32.Parse(Console.ReadLine());
                if (c <= 4000 | c <= -1) 
                {
                    Console.WriteLine("Вас зовут " + a + "\nВам " + b + " лет \nВы родились в " + c + " году");
                    Console.WriteLine("Разработчик - Rebbit");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Программа выдала ошибку программа закрыта");
                    return;
                }
            }
            else 
            {
                Console.WriteLine("Программа выдала ошибку программа закрыта");
                return;
            }
        }
    }
}
