using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Destructor
    {
        private StreamReader? stream;
        private string? textLine;

        public Destructor()
        {
            stream = new("textDoc.txt");
        }

        public void PrintFile() 
        {
            while ((textLine = stream.ReadLine()) != null)
            {
                Console.WriteLine(textLine);
            }
        }

        ~Destructor()
        {
            stream.Close();
        }
    }
}
