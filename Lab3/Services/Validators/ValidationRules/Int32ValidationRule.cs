﻿namespace Lab3WPF.Services.Validators.ValidationRules
{
    public class Int32ValidationRule : ValidationRuleBase<int>
    {
        public Int32ValidationRule(string propertyName, string errorMessage)
            : base(propertyName, errorMessage)
        {
        }
    }
}