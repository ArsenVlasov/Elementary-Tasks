using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisys_envelop
{
    class Envelop
    {
        private float sideOne;
        private float sideTwo;
        public Envelop(float _sideOne, float _sideTwo)
        {
            sideOne = _sideOne;
            sideTwo = _sideTwo;
        }

        public string areCanNested(Envelop otherEnvelop)
        {
            if (otherEnvelop.sideOne > sideOne && otherEnvelop.sideTwo > sideTwo)
                return "Можно вложить первый контейнер в другой!";
            else
                return "Нельзя вложить первый контейнер в другой!";
        }

        public static void inputError()
        {
            Console.WriteLine("Неправильный ввод!");
        }

        public static void condition()
        {
            Console.Write("Есть два конверта со сторонами (a,b) и (c,d) определить,\n" +
            " можно ли один конверт вложить в другой. Программа должна обрабатывать\n" +
            " ввод чисел с плавающей точкой. Программа спрашивает у пользователя\n" +
            " размеры конвертов по одному параметру за раз. После каждого подсчёта\n" +
            " программа спрашивает у пользователя хочет ли он продолжить. Если \n" +
            "пользователь ответит “y” или “yes” (без учёта регистра), программа \n" +
            " продолжает работу сначала, в противном случае – завершает выполнение.\n");
        }
    }
}
