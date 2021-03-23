namespace ExampleAdapter
{
    public class MemoryAdapter : IStorageDisk
    {
        private readonly IStorageMemory _memory;

        public MemoryAdapter(IStorageMemory memory) => _memory = memory; 

        public void AccessDisk(string path) => _memory.AccessMemory(path);
    }
}