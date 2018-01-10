using Lab2LINQ.BL.Services;

namespace Lab3WPF.Services
{
    public interface IStorageFactory
    {
        IStorage<T> CreateFileStorageViewModel<T>(string filePath) where T : new();
    }
}