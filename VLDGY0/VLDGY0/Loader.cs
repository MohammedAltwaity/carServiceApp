using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLDGY0
{
    internal class Loader
    {

        private  Parser parser;


        //we will pass a parser instance to the loader calss in the constructor
        public Loader(Parser parser)
        {
            this.parser = parser;
        }

        
        public List<Work> LoadFile(string filePath)
        {
            List<Work> works = new List<Work>();



            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] columns = line.Split(';');
                    works.Add(parser.Parse(columns));
                }

            } catch(Exception ex) 
            {
                Console.WriteLine("Error happened while trying to read the file " +ex.Message);
            }

            return works;
        }
    }
}
