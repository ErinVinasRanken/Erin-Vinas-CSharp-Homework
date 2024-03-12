using System;

namespace Homework12_05
{
    public class Validator
    {
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = $"{name} must be a valid integer value.";
            }

            return msg;
        }
    }
}
