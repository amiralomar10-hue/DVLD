using System;

namespace DVLD
{
    // 1. شرط الحقل المطلوب (Required)
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }

        public RequiredAttribute(string errorMessage = "This is Required Field.")
        {
            ErrorMessage = errorMessage;
        }
    }

    // 2. شرط طول النص (Min & Max Length)
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class StringLengthAttribute : Attribute
    {
        public int Min { get; }
        public int Max { get; }
        public string ErrorMessage { get; set; }

        public StringLengthAttribute(int min, int max, string errorMessage = "")
        {
            Min = min;
            Max = max;
            ErrorMessage = string.IsNullOrEmpty(errorMessage)
                ? $"The length Should be between {min} and {max}."
                : errorMessage;
        }
    }

    // 3. شرط التعبير النمطي (Regex - للبريد الإلكتروني، الهاتف، إلخ)
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RegularExpressionAttribute : Attribute
    {
        public string Pattern { get; }
        public string ErrorMessage { get; set; }

        public RegularExpressionAttribute(string pattern, string errorMessage = "Invalid Format.")
        {
            Pattern = pattern;
            ErrorMessage = errorMessage;
        }
    }
}

