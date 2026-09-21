using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOP\\week1\\labtasks\\newfile.txt";
            if (File.Exists(path))
            {
                StreamReader variable = new StreamReader(path);
                string record;
                while ((record = variable.ReadLine()) != null)
                {

                    Console.WriteLine(record);
                }
                variable.Close();
                Console.Read();
            }
        }
    }
}
