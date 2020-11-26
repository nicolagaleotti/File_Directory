using System;

namespace File_Directory
{
    public abstract class FileAstratto
    {
        public string Nome { get; private set; }

        public FileAstratto(string nome, Directory directory)
        {
            Nome = nome;
        }

        public abstract long GetDimensione();

        public string Stampa()
        {

        }
    }
}
