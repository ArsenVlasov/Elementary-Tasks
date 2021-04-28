using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace File_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UInt32 variant;
                Console.WriteLine("Выберите один из двух режимов файлового парсера: \n(1 - Считать количество вхождений строки в текстовом файле,\n 2 - Делать замену строки на другую в указанном файле)");
                bool resultVariant = UInt32.TryParse(Console.ReadLine(), out variant);
                if (resultVariant)
                {
                    switch (variant)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите аргументу по приципу: <путь к файлу> <строка для подсчёта>");
                                string[] str = Console.ReadLine().Split(' ');
                                string fileName = str[0] + ".txt";
                                string entry=str[1];
                                if(!File.Exists(fileName))
                                    throw new IOException();
                                bool isStringExist = FileParser.isStringsExist(fileName, entry);
                                if (!isStringExist && str.Length > 2)
                                    throw new FormatException();
                                else if (!isStringExist)
                                    Console.WriteLine("Ответ: {0}", 0);
                                else
                                {
                                    Console.WriteLine("Ответ: {0}", FileParser.numberOccurrences(fileName, entry));
                                }
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Введите аргументу по приципу: <путь к файлу> <строка для поиска> <строка для замены>");
                                string[] str = Console.ReadLine().Split(' ');
                                string fileName = str[0] + ".txt";
                                string searchString = str[1];
                                string replaceString = str[2];

                                if (!File.Exists(fileName))
                                    throw new IOException();
                                if (!FileParser.isStringsExist(fileName, searchString) || str.Length > 3)
                                    throw new FormatException();
                                Console.WriteLine("\nПроизводим замену:\n");
                                FileParser.replaceSpecString(fileName, searchString, replaceString);

                                Console.ReadKey();
                            }
                            break;
                        default:
                            throw new FormatException();
                    }
                }
                else throw new FormatException();

            }
            catch (IOException)
            {
                Console.WriteLine("Путь файла не найден!");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные введены неверно!\n");
                Console.WriteLine("Нужно написать программу, которая будет иметь два режима:\n" +
                    "1. Считать количество вхождений строки в текстовом файле./n"+
                    "2. Делать замену строки на другую в указанном файле./n" +
                    "Программа должна принимать аргументы на вход при запуске:\n" +
                    "1. <путь к файлу> <строка для подсчёта>\n" +
                    "2. <путь к файлу> <строка для поиска> <строка для замены>\n");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
