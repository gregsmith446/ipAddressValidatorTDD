using System;

namespace ipAddressValidatorClass
{
    public class Validator
    {
        public bool ValidateIpv4Address(string address)
        {
            string[] digits = address.Split(".");

            if (digits.Length != 4)
            {
                return false;
            }
            else if (digits.Length == 4 && digits[3] == "255")
            {
                return false;
            }
            else if (digits.Length == 4 && digits[3] == "0")
            {
                return false;
            }
            return true;
        }
    }
}
