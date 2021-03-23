using System;

namespace ExampleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var disk = new Disk();
            var memory = new Memory();
            var memoryAdapter = new MemoryAdapter(memory);

            AcessarStorage(disk, @"C:\");
            AcessarStorage(memoryAdapter, "196754");
        }

        static void AcessarStorage(IStorageDisk disk, string storage) => disk.AccessDisk($"\"{storage}\"");
    }
}
