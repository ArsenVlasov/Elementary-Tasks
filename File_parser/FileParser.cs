using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_parser
{
    class FileParser
    {
        public static int numberOccurrences(string fileName, string entry)
        {

            using (StreamReader file = new StreamReader(fileName))
            {
                string ln;
                int counter = 0;
                while ((ln = file.ReadLine()) != null)
                {
                    if (ln == entry)
                        counter++;
                }
                file.Close();
                return counter;
            }
        }


        public static void replaceSpecString(string fileName, string searchString, string replaceString)
        {
            string[] lines = File.ReadAllLines(fileName);
            using (StreamReader file = new StreamReader(fileName))
            {
                for (int currentLine = 0; currentLine < lines.Length; currentLine++)
                {
                    if (lines[currentLine] == searchString)
                    {
                        //writer.WriteLine(replaceString);
                        lines[currentLine] = replaceString;
                        Console.WriteLine(replaceString);
                    }
                    else
                    {
                        //writer.WriteLine(lines[currentLine]);
                        Console.WriteLine(lines[currentLine]);
                    }
                }
                file.Close();
            }
            File.WriteAllLines(fileName, lines);


        }

        public static bool isStringsExist(string fileName, params string[] entries)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                bool[] isEntryStrings = new bool[entries.Length];
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    int index = 0;
                    foreach (string entry in entries)
                    {
                        if (entry == ln)
                        {
                            isEntryStrings[index]=true;
                        }
                        index++;
                    }
                }
                file.Close();
                foreach (bool isEntry in isEntryStrings)
                {
                    if (!isEntry)
                        return false;
                }
                return true;
            }
        }

       
    }
}
