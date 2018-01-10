using System.Collections.Specialized;
using Lab2LINQ.BL.Services;

namespace Lab3WPF.Models
{
    public class StorageViewModel<T> : Storage<T>, INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;


        public StorageViewModel(IStorageIO<T> storageIo)
            : base(storageIo)
        {

        }


        public override void Add(T data)
        {
            base.Add(data);

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, data));
        }
    }
}