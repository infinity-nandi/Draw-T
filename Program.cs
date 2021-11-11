using System;

namespace _1_zh
{
    class Program
    {
        static void Main(string[] args)
        {
            int xMax = Console.WindowWidth;
            int yMax = Console.WindowHeight;
            int x;
            int y;
            int nagysag;

            Console.Write("Kérem adja meg az X pozicióját: ");
            x = int.Parse(Console.ReadLine());
            while (x>xMax-10)
            {
                Console.Write("Túl nagy a megadott szám!\nKérem adjon meg egy kisebb számot: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.Write("Kérem adja meg az Y pozicióját: ");
            y = int.Parse(Console.ReadLine());
            while (y > yMax - 10)
            {
                Console.Write("Túl nagy a megadott szám!\nKérem adjon meg egy kisebb számot: "); 
                y = int.Parse(Console.ReadLine());
            }

            Console.Write("Kérem adja meg 4 és 10 között, hogy hányszor hányas legyen az alakzat (páros számmal):");
            nagysag = int.Parse(Console.ReadLine());
            while (nagysag > 10 || nagysag < 4 || nagysag%2 !=0 )
            {
                Console.Write("Túl nagy/kicsi vagy nem páros a szám! \nKérem adjon meg egy másikat: ");
                nagysag = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nagysag; i++)
            {
                Console.SetCursorPosition(x+i, y);
                Console.Write("*");
            }
            for (int i = 0; i < nagysag; i++)
            {
                Console.SetCursorPosition(x+(nagysag/2), y+i);
                Console.Write("*");
            }


            Console.ReadKey();
        }
    }
}
