using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UInt32 minNumber, maxNumber;
                Console.WriteLine("Введите минимальный номер билета: ");
                bool resultMinNumber = UInt32.TryParse(Console.ReadLine(), out minNumber);
                Console.WriteLine("Введите максимальный номер билета: ");
                bool resultMaxNumber = UInt32.TryParse(Console.ReadLine(), out maxNumber);
                if (resultMaxNumber && resultMinNumber)
                {
                    UInt32 counterOfSimple = SearchingTicket.simpleHappyTicket(minNumber, maxNumber);
                    UInt32 counterOfHard = SearchingTicket.hardHappyTicket(minNumber, maxNumber);
                    Console.WriteLine("Простых счастливых билетов на этом интервале: {0}", counterOfSimple);
                    Console.WriteLine("Cложных счастливых билетов на этом интервале: {0}", counterOfHard);
                    if (counterOfSimple > counterOfHard)
                        Console.WriteLine("Счастливых билетов оказалось больше согласно ПРОСТОМУ варианту подсчетов");
                    else if (counterOfSimple < counterOfHard)
                        Console.WriteLine("Счастливых билетов оказалось больше согласно СЛОЖНОМУ варианту подсчетов");
                    else
                        Console.WriteLine("Вышло одинаково согласно двум способам");

                    Console.ReadKey();
                }
                else
                    throw new FormatException();
            }
            catch (FormatException ex)
            {
                SearchingTicket.inputError();
                SearchingTicket.condition();
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
