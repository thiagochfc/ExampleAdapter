using System;

namespace ExampleAdapter 
{
    public class Disk : IStorageDisk
    {
        public void AccessDisk(string path)
        {
            Console.WriteLine($"Acessando o caminho {path} do disco!");
        }
    }
}