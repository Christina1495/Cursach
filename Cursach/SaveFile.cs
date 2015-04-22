using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursach
{
    class SaveFile
    {
        public void SaveAll(string path, string info)
        {
            FileStream f2 = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(f2);
            sw.WriteLine(info);
            sw.Close();
            f2.Close();
        }
    }
}
