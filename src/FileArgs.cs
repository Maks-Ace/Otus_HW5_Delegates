using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HW5_Delegates
{
    public class FileArgs : EventArgs
    {
        public FileArgs(string filePath)
        {
            FilePath = Path.GetFullPath(filePath);
            FileName = Path.GetFileName(filePath);
        }
     
        public string FilePath { get; }
        public string FileName { get; }
    }
}
