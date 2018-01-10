using System.Collections.Generic;

namespace Lab2LINQ.BL.Services
{
    // ReSharper disable once InconsistentNaming
    public interface IStorageIO<T>
    {
        IEnumerable<T> ReadAll();

        void WriteAll(IEnumerable<T> source);
    }
}