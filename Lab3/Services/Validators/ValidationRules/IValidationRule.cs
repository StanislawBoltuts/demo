namespace Lab3WPF.Services.Validators.ValidationRules
{
    public interface IValidationRule
    {
        string ErrorMessage { get; }

        string PropertyName { get; }


        bool Validate(object value);
    }
}