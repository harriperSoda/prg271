using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lec5_Ex1
{
    internal class Write
    {

        public void SaveToFile(List<Person> people, string filepath)//a method that will save the list of people to a file. Takes the list and filepath as a parameter.
        {
            List<string> dataList = new List<string>(); //create a temp list to store the string representation of each person
            foreach (Person person in people)
            {
                dataList.Add(person.ToString()); //convert the person object to string and add it to the temp list
            }
            string[] data = dataList.ToArray(); //convert the temp list to an array of strings
            File.WriteAllLines(filepath, data); //write the array of strings to the file at the specified filepath
        }
    }
}
