using System;
using Lab3WPF.ViewModels;

namespace Lab3WPF.Services
{
    public interface ISortStudentsForm
    {
        event EventHandler<SortStudentsEventArgs> SearchSubmitted;


        void EnableDisableSubmit(bool enable);
    }
}