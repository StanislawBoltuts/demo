using System.Collections.Generic;

namespace Lab3WPF.Services.Validators
{
    public interface IValidator
    {
        IEnumerable<string> Validate(string propertyName);

        bool CheckIfAllValid();
    }
}