using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day2_Lec4_Ex1
{
    internal class DataHandler
    {

        public void AddText()
        {
            string file = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day2-Lec4-Ex1\Text.txt";
            
            string[] numbers = {"2", "11", "100", "121", "55", "53"};

            File.WriteAllLines(file, numbers);
                             
        }

        public List<int> ReadData()
        {
            List<int> RetrievedNumbers = new List<int>();
             string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day2-Lec4-Ex1\Text.txt";

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {

                       string line;
                       while ((line = reader.ReadLine()) != null)
                        {
                            RetrievedNumbers.Add(int.Parse(line));
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }

                return RetrievedNumbers;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return RetrievedNumbers;
            }
        }

        public List<int> DisplayData()
        {
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day2-Lec4-Ex1\Text.txt";
            List<int> RetrievedNumbers = new List<int>(); 
            //vs delcariong list here
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    if (File.Exists(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            RetrievedNumbers.Add(int.Parse(line));
                        }
                        RetrievedNumbers.Sort();
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                catch(FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    return RetrievedNumbers;
                }
                return RetrievedNumbers;
            }
        }
      

       
    }
}
