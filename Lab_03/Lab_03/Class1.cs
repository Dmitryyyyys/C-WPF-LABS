using System;
using System.ComponentModel.DataAnnotations;

public class UdcValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
            return true; 

        string udc = value.ToString();
        foreach (char c in udc)
        {
            if (!char.IsDigit(c))
                return false;
            int digit = int.Parse(c.ToString());
            if (digit < 1 || digit > 7)
                return false; 
        }
        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return "УДК должен содержать только цифры от 1 до 7.";
    }
}
