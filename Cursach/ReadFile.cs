using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cursach
{
    class ReadFile
    {

        public string text(string path)
        {
            string text = "";
            string line;

            StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                text += line;
            }

            file.Close();
            return text;
        }
        int counter;

        public string[] mass_text(string path)
        {
            string[] masList = new string[1];
            counter = 0;
            string line;

            StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                masList[counter] = line;

                counter++;
                Array.Resize(ref masList, counter + 1);
            }

            Array.Resize(ref masList, counter);
            file.Close();
            return masList;
        }
        
    }
}
