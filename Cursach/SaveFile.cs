using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursach
{
    /// <summary>
    /// Класс для сохранения в файл форматом .txt и .docx
    /// </summary>
    class SaveFile
    {
        /// <summary>
        /// сохранения в файл форматом .txt и .docx
        /// </summary>
        /// <param name="path"></param>
        /// <param name="info"></param>
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
