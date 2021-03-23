using System;

namespace ExampleAdapter
{
    public class Memory : IStorageMemory
    {
        public void AccessMemory(string posicao)
        {
            Console.WriteLine($"Acessando a posição {posicao} da memória!");
        }
    }
}