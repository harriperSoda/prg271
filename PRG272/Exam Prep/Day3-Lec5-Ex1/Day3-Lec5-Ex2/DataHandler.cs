using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day3_Lec5_Ex2
{
    internal class DataHandler
    {
        public static void AddToFile(List<Person> people)
        {
            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day3-Lec5-Ex1\myDetails.txt";

            
           
                if (people.Count == 0)
                {
                    throw new InvalidOperationException("You cant save to the list because there is nothing in it");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        foreach (Person human in people)
                        {
                            string person = $"{human.Name}; {human.Surname}; {human.DOB}";
                            writer.WriteLine(person);
                        }
                    }
                }
            
           
            
        }
        public static List<string> ReadData()
        {

            string path = @"C:\Users\VMothie\Documents\prg271\PRG272\Exam Prep\Day3-Lec5-Ex1\myDetails.txt";
            List<string> RetrievedPerson = new List<string>();

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reade = new StreamReader(path))
                    {
                        string line;
                        while ((line = reade.ReadLine()) != null)
                        {
                            RetrievedPerson.Add(line);
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return RetrievedPerson;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message); //i did this cas i dont know how to handle the messageb box. if the file aint found how do we preent the error?
                return RetrievedPerson;
            }
        }
    }
}


