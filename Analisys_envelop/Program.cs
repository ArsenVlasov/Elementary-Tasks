using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisys_envelop
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            link:
                float a, b;
                Console.Write("Введите сторону А первого конверта: ");
                bool resultA = float.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите сторону B первого конверта: ");
                bool resultB = float.TryParse(Console.ReadLine(), out b);
                if (resultA && resultB)
                {
                    float c, d;
                    Console.Write("Введите сторону C второго конверта: ");
                    bool resultC = float.TryParse(Console.ReadLine(), out c);
                    Console.Write("Введите сторону D второго конверта: ");
                    bool resultD = float.TryParse(Console.ReadLine(), out d);
                    if (resultC && resultD)
                    {
                        Envelop firstEvelop = new Envelop(a, b);
                        Envelop secondEvelop = new Envelop(c, d);
                        Console.WriteLine(firstEvelop.areCanNested(secondEvelop));
                    }
                }
                else
                    throw new FormatException();

                Console.WriteLine("Если хотите продолжить - напишите в \"yes\" или \"y\" :");
                string str = Convert.ToString(Console.ReadLine());
                if (str == "yes" || str == "y")
                {
                    Console.Clear();
                    goto link;

                }
            }
            catch (FormatException ex)
            {
                Envelop.inputError();
                Console.ReadKey();

                Envelop.condition();
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
