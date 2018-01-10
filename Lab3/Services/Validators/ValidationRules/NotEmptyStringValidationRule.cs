using System;

namespace Lab3WPF.Services.Validators.ValidationRules
{
    public class NotEmptyStringValidationRule : ValidationRuleBase<string>
    {
        public NotEmptyStringValidationRule(string propertyName, string errorMessage)
            : base(propertyName, errorMessage)
        {
        }


        protected override bool ValidateValue(string value)
        {
            return !String.IsNullOrEmpty(value);
        }
    }
}