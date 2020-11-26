using System;
using System.Collections.Generic;
using System.Text;

namespace File_Directory
{
    public class Directory : FileAstratto
    {
        List<File> files = new List<File>();
        public Directory(string nome, Directory directory) : base(nome, directory) { }

        public void AddFile(File file)
        {
            files.Add(file);
        }

        public List<File> GetFiles()
        {
            return files;
        }

        public override long GetDimensione()
        {
            long somma = 0;
            foreach(File f in files)
            {
                somma += f.GetDimensione();
            }
            return somma;
        }
    }
}
