using System;
using Lab3WPF.ViewModels;

namespace Lab3WPF.Services
{
    public interface IStudentForm
    {
        event EventHandler<StudentEventArgs> StudentSubmitted;


        void EnableDisableSubmit(bool enable);
    }
}