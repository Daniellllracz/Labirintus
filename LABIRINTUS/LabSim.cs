using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labirintus
{
    internal class LabSim
    {
        private List<string> adatsorok;
        private char[,] lab;

        public void AdaatsorokBeolvasasa(string forras)
        {
            using StreamReader sr = new(forras);
            while (!sr.EndOfStream) adatsorok.Add(sr.ReadLine());
        }
        public LabSim(string fileName)
        {
            using StreamReader sr = new($@"..\..\..\src\{fileName}");

        }
    }
}
