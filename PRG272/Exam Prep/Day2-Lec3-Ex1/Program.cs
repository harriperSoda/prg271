using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2_Lec3_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day2-Lec3-Ex1\infor.txt"; //specify file path

            try
            {
                if (File.Exists(path))
                {
                    string[] words = File.ReadAllLines(path); //read each line from the file into a string array

                    Console.WriteLine("Origindal data");
                    Console.WriteLine("============");

                    foreach (string line in words) //Each line is an element in the array
                    {
                        Console.WriteLine(line);

                    }
                    Console.WriteLine("============");

                    Console.WriteLine("Formated Data");
                    Console.WriteLine("============");

                    foreach (string line in words)
                    {
                        List<string> list = line.Split(',').ToList();

                        Console.WriteLine($"First Name: {list[0]} | Last Name: {list[1]} | Job: {list[2]}");
                    }

                    //Write to new text file
                    string newPATH = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day2-Lec3-Ex1\NewWords.txt";

                    using (StreamWriter writer = new StreamWriter(newPATH))
                    {
                        foreach (string line in words)
                        {
                            List<string> list = line.Split(',').ToList();

                            writer.WriteLine($"First Name: {list[0]} | Last Name: {list[1]} | Job: {list[2]}");

                           

                        }
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
