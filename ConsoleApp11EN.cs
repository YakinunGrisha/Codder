using System;

namespace ConsoleApp10
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            int b;
            // I created a new int b
            string a;
            // I created a replacement string a
            Console.WriteLine("Привет \nНапиши число");
            // the console displays a message
            Console.Write("");
            // enter into the console
            a = Console.ReadLine();
            // a equates to console line reading
            b = Int32.Parse(a);
            // b is equated to int 32 bit and parsim hey
            if (b >= 5) 
            {
                Console.Clear();
                Console.WriteLine("Вы ввели неизвестное число программе");
                return;
            }
            // I create an if and if checks the b is greater than or equal to five and then the console is cleaned and a message is issued and the program closes
            switch(a) 
            {
                case "1":
                    a = "однёрку";
                    break;
                case "2":
                    a = "двойку";
                    break;
                case "3":
                    a = "тройку";
                    break;
                case "4":
                    a = "четвёрку";
                    break;
            }
            // a switch a is created and in cases I write numbers from one to four and at the same time it goes from a digit in text form to a letter form
            Console.Clear();
            // the console is being cleaned
            Console.WriteLine("Вы ввели " +a);
            // the console displays the message You have entered the letter number that is indicated in the switch and if the if is equal to the tru then it outputs a message
            // You have entered an unknown number to the program
        }
    }
}
