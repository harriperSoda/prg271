using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lec5_Ex1
{
    internal class Read
    {
        public List<string> ReadFromFile(string filepath)// we want a list returned from this method, so we specify List<string> as the return type. The method takes a string parameter for the filepath.
        {
            List<string> data = File.ReadAllLines(filepath).ToList(); //read all lines from the file at the specified filepath and convert it to a list of strings
            return data;
        }
    }
}
