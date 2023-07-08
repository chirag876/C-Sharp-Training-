using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Interface
    {
        interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
    }
}

