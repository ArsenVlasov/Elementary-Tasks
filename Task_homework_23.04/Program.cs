using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_homework_23._04
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                UInt32 height, width;
                Console.Write("Введите высоту шахматной доски: ");
                bool resultHeight = UInt32.TryParse(Console.ReadLine(), out height);
                Console.Write("Введите ширину шахматной доски: ");
                bool resultWidth = UInt32.TryParse(Console.ReadLine(), out width);
                if (resultHeight && resultWidth)
                {
                    ChessBoard board = new ChessBoard(height, width);
                    board.outputBoard();
                    Console.ReadKey();
                }
                else
                    throw new FormatException();

          
            }
            catch (FormatException ex)
            {
                ChessBoard.inputError();
                Console.ReadKey();

                ChessBoard.condition();
                Console.ReadKey();
                Console.Clear();

            }


        }
    }
}
