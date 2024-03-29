﻿using System.Text.RegularExpressions;
using System;

namespace Coure_API_Assesment.Helpers.InputOperations
{
    public static class SanitizeInputs
    {
        public static void ProcessObjectAgainstInputThreats(object inputToValidate)
        {
            try
            {
                if (inputToValidate == null)
                {
                    return;
                }

                //Clear all Inputs from possible threats
                foreach (var property in inputToValidate.GetType().GetProperties())
                {
                    if (property.PropertyType == typeof(string))
                    {
                        var value = (string)property.GetValue(inputToValidate);
                        if (!string.IsNullOrEmpty(value))
                        {
                            //XML Injection and other Sanitization Checks
                            string pattern = @"[<>&'$=]|(\bOR\b)";
                            if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase))
                            {
                                value = Regex.Replace(value, pattern, string.Empty);
                            }

                            property.SetValue(inputToValidate, value);
                        }
                    }
                    //else if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                    //{
                    //    ProcessObjectAgainstInputThreats(property.GetValue(inputToValidate));
                    //}
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
