using system;


namespace ConsoleMission2._2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Title=("Programm calculator");
         Console.WriteLine("only a plus and minus");
         Console.WriteLine("Write numbers");
         int a;
         Console.Write("");
         a = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Write numbers");
         int b;
         Console.Write("");
         b = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Write action");
         string c;
         Console.Write("");
         c = Console.ReadLine();
         int over = 0;
         switch (c)
         {
           case "+":
                    over = a + b;
                       break;
           case "-":
                    over = a - b;
                       break;
         }
         Console.WriteLine(over);
         return;
        }     
    }
    
 }   
