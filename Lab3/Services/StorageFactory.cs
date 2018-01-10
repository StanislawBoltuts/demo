using Lab2LINQ.BL.Services;
using Lab3WPF.Models;

namespace Lab3WPF.Services
{
    public class StorageFactory : IStorageFactory
    {
        public IStorage<T> CreateFileStorageViewModel<T>(string filePath)
            where T : new()
        {
            return new Storage<T>(new FileStorageIO<T>(filePath));
        }
    }
}