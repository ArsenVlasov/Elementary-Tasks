using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_homework_23._04
{
    class ChessBoard
    {
        private UInt32 Height;
        private UInt32 Width;
        public ChessBoard(UInt32 height, UInt32 width)
        {
            Height = height;
            Width = width;

        }

        public void outputBoard()
        {
            for (int i = 1; i <= Height; i++)
            {
                if (i % 2 == 0)
                    Console.Write(" ");
                for (int j = 1; j <= Width; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
        public static void inputError()
        {
            Console.WriteLine("Неправильный ввод!");
        }

        public static void condition()
        {
            Console.Write("Вывести шахматную доску с заданными размерами высоты и ширины, по принципу:\n\n" +
                          "*  *  *  *  *  *\n" +
                          "  *  *  *  *  *  *\n" +
                          "*  *  *  *  *  *\n" +
                          "  *  *  *  *  *  *\n\n" +
                          "Программа запускается через вызов главного класса с параметрами.\n\n");
        }


    }
}
