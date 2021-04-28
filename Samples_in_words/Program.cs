using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples_in_words
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите целое натуральное число: ");
                UInt64 number;
                bool resultNumber = UInt64.TryParse(Console.ReadLine(), out number);
                if (resultNumber)
                {
                    int[] numbers = new int[4];
                    string[,] uppercaseNumbers = new string[4, 3] {
                                { " миллиард", " миллиарда", " миллиардов" },
                                { " миллион", " миллиона", " миллионов" },
                                { " тысяча", " тысячи", " тысяч" },
                                { "", "", "" }};

                    numbers[0] = (int)((number - (number % Math.Pow(10, 9))) / Math.Pow(10, 6));
                    numbers[1] = (int)(((number % Math.Pow(10, 9)) - (number % Math.Pow(10, 6))) / Math.Pow(10, 6));
                    numbers[2] = (int)(((number % Math.Pow(10, 6)) - (number % Math.Pow(10, 3))) / Math.Pow(10, 3));
                    numbers[3] = (int)(number % Math.Pow(10, 3));

                    Console.WriteLine(numbers[0]);
                    Console.WriteLine(numbers[1]);
                    Console.WriteLine(numbers[2]);
                    Console.WriteLine(numbers[3]);

                    string result = "";

                    if (number == 0) result = "ноль";
                    else for (int i = 0; i < 4; i++)
                        {
                            if (numbers[i] != 0)
                            {
                                if (((numbers[i] - (numbers[i] % 100)) / 100) != 0)
                                    switch (((numbers[i] - (numbers[i] % 100)) / 100))
                                    {
                                        case 1: result += " сто"; break;
                                        case 2: result += " двести"; break;
                                        case 3: result += " триста"; break;
                                        case 4: result += " четыреста"; break;
                                        case 5: result += " пятьсот"; break;
                                        case 6: result += " шестьсот"; break;
                                        case 7: result += " семьсот"; break;
                                        case 8: result += " восемьсот"; break;
                                        case 9: result += " девятьсот"; break;
                                    }
                                if (((numbers[i] % 100) - ((numbers[i] % 100) % 10)) / 10 != 1)
                                {
                                    switch (((numbers[i] % 100) - ((numbers[i] % 100) % 10)) / 10)
                                    {
                                        case 2: result += " двадцать"; break;
                                        case 3: result += " тридцать"; break;
                                        case 4: result += " сорок"; break;
                                        case 5: result += " пятьдесят"; break;
                                        case 6: result += " шестьдесят"; break;
                                        case 7: result += " семьдесят"; break;
                                        case 8: result += " восемьдесят"; break;
                                        case 9: result += " девяносто"; break;
                                    }
                                    switch (numbers[i] % 10)
                                    {
                                        case 1: if (i == 2) result += " одна"; else result += " один"; break;
                                        case 2: if (i == 2) result += " две"; else result += " два"; break;
                                        case 3: result += " три"; break;
                                        case 4: result += " четыре"; break;
                                        case 5: result += " пять"; break;
                                        case 6: result += " шесть"; break;
                                        case 7: result += " семь"; break;
                                        case 8: result += " восемь"; break;
                                        case 9: result += " девять"; break;
                                    }
                                }
                                else switch (numbers[i] % 100)
                                    {
                                        case 10: result += " десять"; break;
                                        case 11: result += " одиннадцать"; break;
                                        case 12: result += " двенадцать"; break;
                                        case 13: result += " тринадцать"; break;
                                        case 14: result += " четырнадцать"; break;
                                        case 15: result += " пятнадцать"; break;
                                        case 16: result += " шестнадцать"; break;
                                        case 17: result += " семнадцать"; break;
                                        case 18: result += " восемнадцать"; break;
                                        case 19: result += " девятнадцать"; break;
                                    }
                                if (numbers[i] % 100 >= 10 && numbers[i] % 100 <= 19) result += uppercaseNumbers[i, 2];
                                else switch (numbers[i] % 10)
                                    {
                                        case 1: result += uppercaseNumbers[i, 0]; break;
                                        case 2:
                                        case 3:
                                        case 4: result += uppercaseNumbers[i, 1]; break;
                                        case 5:
                                        case 6:
                                        case 7:
                                        case 8:
                                        case 9:
                                        case 0: result += uppercaseNumbers[i, 2]; break;
                                    }
                            }
                        }
                    result = result.TrimStart(' ');
                    Console.WriteLine("Полученная прописная форма числа: ");
                    Console.WriteLine(result);
                    Console.ReadKey();
                }
                else
                    throw new FormatException();

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неправильный ввод!");
                Console.Write("\tНужно преобразовать целое число в прописной вариант: 12 – двенадцать.\n " +
                    "\tПрограмма запускается через вызов главного класса с параметрами.");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
