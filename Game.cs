using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ReadLine();
        }
        static string Centr()
        {
            string BackGround = "лала ";



            int left = Console.WindowWidth / 2 - (BackGround.Length / 2);

            return BackGround.PadLeft(left + BackGround.Length).PadRight(Console.WindowWidth);
                  
        }   
    }
}
