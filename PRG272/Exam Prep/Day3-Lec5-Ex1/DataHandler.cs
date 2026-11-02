using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day3_Lec5_Ex1
{
    internal class DataHandler
    {

        public static void SaveToFile(List<Person> people )
        {


            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day3-Lec5-Ex1\People.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Person person in people)
                {
                    string human = $"{person.Name}, {person.Surname}, {person.Job}";
                    writer.WriteLine(human);
                }
            }
        }

        public static List<string> ReadFromFile()
        {
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day3-Lec5-Ex1\People.txt";
            List<string> lines = new List<string>();
            
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    return lines;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return lines;
            }
            return lines;
        }
    }
}
