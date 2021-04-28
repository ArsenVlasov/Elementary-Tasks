using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UInt32 variant;
                Console.WriteLine("Числа Фибоначчи. Виберите функцию\n(1 - указать диапазон чисел, 2 - указать длину чисел)");
                bool resultVariant = UInt32.TryParse(Console.ReadLine(), out variant);
                if (resultVariant)
                {
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    switch (variant)
                    {
                        case 1:
                            {
                                UInt32 lowRange, upRange;
                                Console.WriteLine("Введите первое значение диапазона: ");
                                bool resultLowRange = UInt32.TryParse(Console.ReadLine(), out lowRange);
                                Console.WriteLine("Введите последнее значения диапазона: ");
                                bool resultUpRange = UInt32.TryParse(Console.ReadLine(), out upRange);
                                if (resultLowRange && resultUpRange && upRange > lowRange)
                                {
                                    fibonacciSeries.rangeSpec(lowRange, upRange);
                                    Console.ReadKey();
                                }
                                else throw new FormatException();
                            }
                            break;
                        case 2:
                            {
                                UInt32 lengthNumber;
                                Console.WriteLine("Введите длину диапазона: ");
                                bool resultLengthNumber = UInt32.TryParse(Console.ReadLine(), out lengthNumber);
                                if (resultLengthNumber)
                                {
                                    fibonacciSeries.lengthSpec(lengthNumber);
                                    Console.ReadKey();
                                }
                                else throw new FormatException();
                            }
                            break;
                        default:
                             throw new FormatException();
                    }

                }
                else throw new FormatException();

            }
            catch (FormatException)
            {
                FibonacciSeries.inputError();
                FibonacciSeries.condition();
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
