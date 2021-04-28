using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    class FibonacciSeries
    {

        public void rangeSpec(UInt32 lowRange, UInt32 upRange)
        {
            Console.Write("Ответ: ");
            UInt32 a = 0, b = 1, c;
            while (a < upRange)
            {
                if (a > lowRange)
                    Console.Write("{0} ", a);
                c = a + b;
                a = b;
                b = c;
            }
        }

     

        public void lengthSpec(UInt32 lengthNumber)
        {
            Console.Write("Ответ: ");
            UInt32 a = 0, b = 1, c, counter=0;
            while (lengthNumber >= counter)
            {
                counter++;
                Console.Write("{0} ", a);
                c = a + b;
                a = b;
                b = c;
            } 
        }

        public static void inputError()
        {
            Console.WriteLine("Неправильный ввод!");
        }

        public static void condition()
        {
            Console.Write("Вывести все числа Фибоначчи, которые удовлетворяют переданному в функцию\n ограничению: находятся в указанном диапазоне, либо имеют указанную длину.");
        }

    }
}
