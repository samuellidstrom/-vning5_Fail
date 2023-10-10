using System.Drawing;

namespace Uppgift5_Garage
{
    public class VisualHandler
    {
        public static void PrintMessage()
        {
            MsgClear();
            Console.SetCursorPosition(2, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void CursorPositionUserInput()
        {
            Console.SetCursorPosition(13, 9);
        }
        public static void CursorPositionGarage()
        {
            Console.SetCursorPosition(1, 14);
        }
        public static void ColorsDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ColorsInfo()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void ColorsMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void MenuClear()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                ");
            }
        }
        public static void MsgClear()
        {
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                                          ");
        }
        public static void GarageClear()
        {
            for (int i = 14; i < 18; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                ");
            }
        }
    }
}