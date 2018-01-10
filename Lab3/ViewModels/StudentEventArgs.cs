using System;
using Lab2LINQ.BL.Models;

namespace Lab3WPF.ViewModels
{
    public class StudentEventArgs : EventArgs
    {
        public StudentModel Student { get; }


        public StudentEventArgs(StudentModel student)
        {
            Student = student;
        }
    }
}