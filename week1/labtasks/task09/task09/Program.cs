using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOP\\week1\\labtasks\\newfile.txt";
            if(File.Exists(path))
            {
                StreamWriter variable = new StreamWriter(path , true);

                string data = Console.ReadLine();
                variable.WriteLine(data);
                variable.Flush();
                variable.Close();
                Console.Read();

            }
        }
    }
}
