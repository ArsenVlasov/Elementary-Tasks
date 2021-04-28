using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_sorting
{
    public class Triangle : IComparable<Triangle>
    {
        private string name;
        private double a;
        private double b;
        private double c;

        private double AreaByGerone()
        {
            double p = (a + b + c) / 3;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }


        public double area;

        public Triangle(string _name, double _a, double _b, double _c)
        {
            name = _name;
            a = _a;
            b = -b;
            c = _c;
            area = AreaByGerone();
        }

        //public double GetArea { get { return area; } }

        public static void inputError()
        {
            Console.WriteLine("Неправильный ввод!");
        }

        public override string ToString()
        {
            return "[Triangle " + name + "]: " + Math.Round(area, 2) + " сm";
        }
        public static void condition()
        {
            Console.Write("Разработать консольную программу, выполняющую вывод треугольников \n" +
                "в порядке убывания их площади. После добавления каждого нового треугольника программа\n" +
                " спрашивает, хочет ли пользователь добавить ещё один. Если пользователь ответит “y” или “yes”\n" +
                " (без учёта регистра), программа попросит ввести данные для ещё одного треугольника,\n" +
                " в противном случае – выводит результат в консоль.");
        }

        public int CompareTo(Triangle other)
        {
            return this.area.CompareTo(other.area);
        }
    }
}
