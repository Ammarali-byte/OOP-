using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOP\\week1\\quiz1practice\\newfile.txt";
            StreamReader file = new StreamReader(path);
            int vowel = 0;
            int consonants = 0;
            String record;
            while ((record = file.ReadLine()) != null)
            {
               
                for(int i = 0; i < record.Length ; i++)
                {
                    char ch = record[i];

                    if (char.IsLetter(ch))
                    {
                        if ("aeiouAEIOU".Contains(ch))
                        {
                            vowel++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                }
               
            }
            file.Close();
            Console.WriteLine("The vowels in the files are {0}", vowel);
            Console.WriteLine("The consonants in the files are {0}", consonants);
        }
    }
}
