using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day1_2Revision
{
    internal class DataHandler
    {
        public void AddData()
        {
            int[] givenMarks = { 78, 42, 91, 65, 37, 84, 56, 73 };

            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Practice Exercises\Day1-2Revision\Marks.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (int number in givenMarks)
                {
                    writer.WriteLine(number);
                }
            }
        }

        public List<int> ReadData()
        {
            List<int> RetrievedMarks = new List<int>();
            string filepath = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Practice Exercises\Day1-2Revision\Marks.txt";

            try
            {
                if (File.Exists(filepath))
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string mark;
                        while ((mark = reader.ReadLine()) != null)
                        {
                            RetrievedMarks.Add(int.Parse(mark));
                        }
                    }
                }

                else
                {
                    throw new FileNotFoundException();
                    
                }
                return RetrievedMarks;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return RetrievedMarks;
            }
        }

        public List<int> SortAsc()
        {
            List<int> toBeAsc = new List<int>();
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Practice Exercises\Day1-2Revision\Marks.txt";

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            toBeAsc.Add(int.Parse(line));
                        }
                        toBeAsc.Sort();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return toBeAsc;
               
               
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return toBeAsc;
            }
        }

        public List<int> SortDesc()
        {
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Practice Exercises\Day1-2Revision\Marks.txt";
            List<int> toBeDesc = new List<int>();

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string number;
                        while ((number = reader.ReadLine()) != null)
                        {
                            toBeDesc.Add(int.Parse(number));
                        }
                        toBeDesc.Sort();
                        toBeDesc.Reverse();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return toBeDesc;
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return toBeDesc;
            }

        }
    }
}
