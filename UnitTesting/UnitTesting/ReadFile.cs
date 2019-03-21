using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace UnitTesting
{
    class ReadFile
    {
        public static string readFile()
        {
            StreamReader sr = new StreamReader("CasosPrueba.txt");
            string line = sr.ReadToEnd();
            return line;
        }
    }
}
