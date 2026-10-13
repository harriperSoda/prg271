using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lec3_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\VMothie\Documents\prg271\PRG272\Lec3-Ex1\Lec3-Ex1\words.txt";
            //string filecontent = File.ReadAllText(filepath);
            //Console.WriteLine(filecontent);

            try
            {
                if (File.Exists(filepath)) //try catch for file path verification
                {
                    string[] fileContent = File.ReadAllLines(filepath); // reads all lines of the file into an array of strings

                    foreach (string line in fileContent)
                    {
                        List<string> item = line.Split(',').ToList(); //Take this line, split it into pieces wherever there is a comma, convert those pieces into a List<string>, and store that list in item
                        Console.WriteLine(
                            $"First Name: {item[0].Trim()} " +
                            $"Last Name: {item[1].Trim()} " +
                            $"Job: {item[2].Trim()} "
                            );
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
