using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UInt32 n;
                double m;
                Console.WriteLine("Введите длину числового ряда: ");
                bool resultN = UInt32.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Введите значение минимального квадрата: ");
                bool resultM = double.TryParse(Console.ReadLine(), out m);
                if (resultN && resultM)
                {
                    string answer = null;
                    for (UInt32 i = (UInt32)Math.Sqrt(m); i < (UInt32)Math.Sqrt(m) + n; i++)
                    {
                        if (i == (UInt32)Math.Sqrt(m) + n - 1)
                        {
                            answer += i;
                            continue;
                        }
                        answer += i + ", ";
                    }
                    Console.WriteLine("Ответ: " + answer);
                    Console.ReadKey();
                }
                else
                    throw new FormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неправильный ввод!");
                Console.WriteLine("Вывести через запятую ряд длиной n, состоящий из натуральных чисел, квадрат которых не меньше заданного m.\n");
                Console.WriteLine("Входные параметры: длина и значение минимального квадрата\n");
                Console.WriteLine("Выход: строка с рядом чисел");


                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
