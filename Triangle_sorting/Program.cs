using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_sorting
{
    class Program
    {

        public static bool Check(double a, double b, double c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            List<Triangle> listOfTrinagle = new List<Triangle>();
            string name;
            double a, b, c;
            bool isAddingTrinagle = true;
            try
            {
                link:
                while (isAddingTrinagle)
                {
                    Console.WriteLine("Введите данные треугольника:");
                    Console.WriteLine("Формат ввода (разделитель - запятая): < имя >, < длина стороны >, < длина стороны >, < длина стороны >");
                    string[] str = Console.ReadLine().Split(',');
                    name = Convert.ToString(str[0]);
                    bool resultA = double.TryParse(str[1], out a);
                    bool resultB = double.TryParse(str[2], out b);
                    bool resultC = double.TryParse(str[3], out c);
                    if (resultA && resultB && resultC)
                    {
                        if (Check(a, b, c))
                        {
                            listOfTrinagle.Add(new Triangle(name, a, b, c));

                            Console.WriteLine("Если хотите продолжить - напишите в \"yes\" или \"y\" :");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "yes" || answer == "y")
                            {
                                continue;
                            }
                            else
                                isAddingTrinagle = false;
                        }
                        else
                        {
                            Console.WriteLine("Cогласно вашим данным, треугольника не существует! Введите данные заново");
                            Console.ReadKey();
                            Console.Clear();
                            goto link;
                        }
                    }
                    else
                        throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                Triangle.inputError();
                Console.ReadKey();

                Triangle.condition();
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Triangle.inputError();
                Console.ReadKey();


            }
            Console.Clear();

            listOfTrinagle.Sort();
            listOfTrinagle.Reverse();
            foreach (Triangle trinagle in listOfTrinagle)
            {
                Console.WriteLine(trinagle.ToString());
            }
            Console.ReadKey();

        }
    }
}
