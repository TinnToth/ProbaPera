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
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Menu_Method();
            Console.ReadLine();
        }


        static void Menu_Method()
        {
            Console.ForegroundColor = ConsoleColor.Black;

            WriteString("                                        ", 20, 0);
            WriteString("           ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄         ", 20, 1);
            WriteString("         ▄▀            ▄       ▀▄       ", 20, 2);
            WriteString("         █  ▄    ▄              █       ", 20, 3);
            WriteString("         █            ▄█▄▄  ▄   █ ▄▄▄   ", 20, 4);
            WriteString("  ▄▄▄▄▄  █      ▀    ▀█  ▀▄     █▀▀ ██  ", 20, 5);
            WriteString("  ██▄▀██▄█   ▄       ██    ▀▀▀▀▀    ██  ", 20, 6);
            WriteString("   ▀██▄▀██        ▀ ██▀             ▀██ ", 20, 7);
            WriteString("     ▀████ ▀    ▄   ██   ▄█    ▄ ▄█  ██ ", 20, 8);
            WriteString("        ▀█    ▄     ██    ▄   ▄  ▄   ██ ", 20, 9);
            WriteString("        ▄█▄           ▀▄  ▀▀▀▀▀▀▀▀  ▄▀  ", 20, 10);
            WriteString("       █▀▀█████████▀▀▀▀████████████▀    ", 20, 11);
            WriteString("       ████▀  ███▀      ▀███  ▀██▀      ", 20, 12);
            WriteString("                                        ", 20, 13);
            WriteString("                                        ", 20, 14);

            
            Console.BackgroundColor = ConsoleColor.DarkGray;

            WriteString("█  ▀", 43, 5);
            WriteString("█▀▀ ", 52, 5);
            WriteString("    ▀▀▀▀▀    ", 43, 6);
            WriteString("█▄▀█", 23, 6);
            WriteString("▀             ▀", 42, 7);
            WriteString("█▄▀██", 24, 7);
            WriteString("   ▄█    ▄ ▄█  ", 42, 8);
            WriteString("    ▄   ▄  ▄   ", 42, 9);
            WriteString("▄  ▀▀▀▀▀▀▀▀  ▄", 43, 10);
            WriteString("█▀▀", 27, 11);

            Console.BackgroundColor = ConsoleColor.Magenta;

            
            WriteString("█  ▄    ▄              ", 29, 3);
            WriteString("█            ▄█▄▄  ▄   ", 29, 4);
            WriteString("█      ▀    ▀", 29, 5);
            WriteString("▄     ", 46, 5);
            WriteString("█   ▄       ", 29, 6);
            WriteString("        ▀ ", 30, 7);
            WriteString(" ▀    ▄   ", 30, 8);
            WriteString("    ▄     ", 30, 9);
            WriteString(" ", 55, 9);
            WriteString(" ", 44, 9);
            WriteString("▄           ▀", 30, 10);

            Console.BackgroundColor = ConsoleColor.Yellow;

            WriteString("▀                    ▀", 30, 2);
            WriteString("  ", 30, 3); WriteString("  ", 50, 3);
            WriteString(" ", 30, 4); WriteString(" ", 51, 4);
            WriteString(" ", 30, 5); WriteString(" ", 51, 5);
            WriteString(" ", 30, 6);
            WriteString(" ", 30, 7);
            WriteString(" ", 30, 8);
            WriteString("  ", 30, 9);
            WriteString("▄           ▀", 30, 10);

            Console.BackgroundColor = ConsoleColor.White;
        }


        static void WriteString(string Text, int x, int y)
        {
            Console.SetCursorPosition(x , y);
            Console.WriteLine(Text);
        }
    }
}
