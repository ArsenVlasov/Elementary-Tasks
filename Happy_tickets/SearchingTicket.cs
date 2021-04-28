using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_tickets
{
    static class SearchingTicket
    {
        public static void inputError()
        {
            Console.WriteLine("Неправильный ввод!");
        }

        public static void condition()
        {
            Console.Write("Есть 2 способа подсчёта счастливых билетов:\n" +
                "1. Простой — если на билете напечатано шестизначное число, и сумма первых \n"+
                "трёх цифр равна сумме последних трёх, то этот билет считается счастливым.\n"+
                "2. Сложный — если сумма чётных цифр билета равна сумме нечётных цифр\n" +
                "билета, то билет считается счастливым.\n" +
                "Определить программно какой вариант подсчёта счастливых билетов даст их \n" +
                "большее количество на заданном интервале. \n\n" +
                "Входные параметры: min и max номер билета\n" +
                "Выход: информация о победившем методе и количестве счастливых билетов для каждого способа подсчёта. \n");
        }


        public static UInt32 simpleHappyTicket( UInt32 minNumbers,  UInt32 maxNumbers)
        {
            UInt32 counter=0;
            for (UInt32 i = minNumbers; i <= maxNumbers; i++)
            {
                string iToString = i.ToString();
                if (iToString.Length==6  )
                {
                    UInt32 a = (UInt32)(iToString[0]+ iToString[1]+ iToString[2]);
                    UInt32 b = (UInt32)(iToString[3] + iToString[4] + iToString[5]);
                    if (a == b)
                        counter++;
                }
            }
            return counter;
        }

        public static UInt32 hardHappyTicket(UInt32 minNumbers, UInt32 maxNumbers)
        {
            UInt32 counter = 0;

            for (UInt32 i = minNumbers; i <= maxNumbers; i++)
            {
                UInt32 evenCounter = 0;
                UInt32 oddCounter = 0;
                UInt32 curr = i;
                while (curr >0)
                {
                    if ((curr % 10) % 2 == 0)
                        evenCounter += curr % 10;
                    else
                        oddCounter += curr % 10;
                    curr = curr / 10;
                }
                if (evenCounter == oddCounter)
                    counter++;
            }
            return counter;
        }
    }
}
