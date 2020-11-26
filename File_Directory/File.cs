using System;
using System.Collections.Generic;
using System.Text;

namespace File_Directory
{
    public class File : FileAstratto
    {
        public long dimensione;

        public File(string nome, Directory directory) : base(nome, directory) { }

        public override long GetDimensione()
        {
            return dimensione;
        }

        public void SetDimensione(long dimensione)
        {
            this.dimensione = dimensione;
        }
    }
}
