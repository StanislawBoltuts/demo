using Lab3WPF.Services;
using Lab3WPF.ViewModels;

namespace Lab3WPF.Views
{
    public partial class StorageWorkerView
    {
        public StorageWorkerView()
        {
            InitializeComponent();

            var addStudentFormViewModel = new AddStudentFormViewModel();
            var sortStudentsFormViewModel = new SortStudentsFormViewModel();

            sortStudentsFormView.DataContext = sortStudentsFormViewModel;
            addStudentFormView.DataContext = addStudentFormViewModel;
            DataContext = new StorageWorkerViewModel(new StorageFactory(), sortStudentsFormViewModel, addStudentFormViewModel);
        }
    }
}