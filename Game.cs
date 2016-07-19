using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static bool GameExit;

        static ConsoleKey k;

        static int y = 15;

        static string[] MenuVar = new string[4];

        static string[] LevelHip = new string[3];

        static byte CurrentMenuVar = 0, CurrentLevelVar = 0;

        static void Main(string[] args)
        {
            LevelHip[0] = "Легко";
            LevelHip[1] = "Нормально";
            LevelHip[2] = "Сложно";

            MenuVar[0] = "           ИГРАТЬ         ";
            MenuVar[1] = String.Format("УРОВЕНЬ СЛОЖНОСТИ:  {0} ", LevelHip[CurrentLevelVar]);
            MenuVar[2] = "           АВТОРЫ         ";
            MenuVar[3] = "       ВЫЙТИ ИЗ ИГРЫ      ";

            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.White;

            MenuCursor();

        }



        static void MenuCursor()
        {
            GameExit = false;

            MenuPic();
            MenuChoices();

            while (GameExit == false)
            {
                int Pre_y = y;
                k = Console.ReadKey(true).Key;

                if (k == ConsoleKey.S || k == ConsoleKey.DownArrow)
                {
                    y += 2;

                    if (y > 21)
                    {
                        y = 15;

                    }
                    ChoiceString(y, Pre_y);
                }

                else if (k == ConsoleKey.W || k == ConsoleKey.UpArrow)
                {
                    y -= 2;
                    if (y < 15)
                    {
                        y = 21;
                    }
                    ChoiceString(y, Pre_y);
                }

                else if (k == ConsoleKey.Enter)
                {
                    switch (CurrentMenuVar)
                    {
                        case (0):

                            break;

                        case (1):

                            break;

                        case (2):
                            Autors();
                            break;

                        default:
                            GameExit = true;
                            break;
                    }
                }


            }
        }

        static void ChoiceString(int method_y, int Pre_y)
        {
            if (k == ConsoleKey.S || k == ConsoleKey.DownArrow)
            {
                if (Pre_y < method_y)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28, Pre_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);

                    CurrentMenuVar++;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, method_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28, Pre_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);

                    CurrentMenuVar = 0;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, method_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);
                }
            }
            else
            {
                if (Pre_y > method_y)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28, Pre_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);

                    CurrentMenuVar--;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, method_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28, Pre_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);

                    CurrentMenuVar = 3;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, method_y);
                    Console.WriteLine(MenuVar[CurrentMenuVar]);
                }
            }

            if (CurrentMenuVar == 1)
            {
                Level(k);
            }
        }

        static void MenuChoices()
        {
            Window();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(28, 15);
            Console.WriteLine(MenuVar[0]);

            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(28, 17);
            Console.WriteLine(MenuVar[1]);

            Console.SetCursorPosition(28, 19);
            Console.WriteLine(MenuVar[2]);

            Console.SetCursorPosition(28, 21);
            Console.WriteLine(MenuVar[3]);

            Console.SetCursorPosition(40, y);
        }

        static void Window()
        {
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Black;

            int DrawY = 15;

            Console.SetCursorPosition(23, DrawY - 1);
            Console.WriteLine(" ╔═════════════════════════════════╗ ");

            while (DrawY < 22)
            {
                Console.SetCursorPosition(23, DrawY);
                Console.WriteLine(" ║                                 ║ ");
                DrawY++;
            }

            Console.SetCursorPosition(23, DrawY);
            Console.WriteLine(" ╚═════════════════════════════════╝ ");
        }

        static void MenuPic()
        {
            Console.Clear();
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
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Text);
        }

        static void Level(ConsoleKey k)
        {
            if (k == ConsoleKey.A || k == ConsoleKey.LeftArrow)
            {
                CurrentLevelVar--;

                if (CurrentLevelVar < 0)
                {
                    CurrentLevelVar = 2;
                }
            }

            else if (k == ConsoleKey.D || k == ConsoleKey.RightArrow || k == ConsoleKey.Enter)
            {
                CurrentLevelVar++;

                if (CurrentLevelVar > 2)
                {
                    CurrentLevelVar = 0;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(28, 17);
            Console.WriteLine(MenuVar[1]);
        }

        static void Autors()
        {
            do
            {
                MenuPic();
                Window();
                WriteString("РАЗРАБОТЧИКИ", 35, 15);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                WriteString("АСЛАНИДИ КОНСТАНТИН", 32, 17);
                Console.ForegroundColor = ConsoleColor.Green;
                WriteString("ЕМЕЛЬЯНОВ МАКСИМ", 33, 19);
                Console.ForegroundColor = ConsoleColor.Black;
                WriteString("СПАСИБО ЗА ВНИМАНИЕ :)", 31, 21);

                k = Console.ReadKey(true).Key;

                if (k == ConsoleKey.Escape || k == ConsoleKey.Enter)
                {
                    MenuPic();
                    MenuChoices();

                    CurrentMenuVar = 0;

                    y = 15;

                    break;
                }
                
            }
            while (true);
        }

    }
}
