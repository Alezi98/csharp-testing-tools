using System;

namespace UserApp.src.Model
{
    class UserValidations
    {

        public static bool IsCpfValid(string cpf)
        {
           // removing mask characters, leaving only cpf numbers
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            // if there are more than 11 characters, cpf is not valid
            if (cpf.Length == 11)
            {
                string hasCpf = cpf.Substring(0, 9);
                int sum1 = 0;

                // using digits in cpf to calculate validation digit
                int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 9; i++)
                {
                    sum1 += int.Parse(hasCpf[i].ToString()) * multiplier1[i];
                }
                int rest = sum1 % 11;
                if (rest < 2)
                {
                    rest = 0;
                }
                else
                {
                    rest = 11 - rest;
                }

                string digit = rest.ToString();
                hasCpf = hasCpf + digit;

                int sum2 = 0;
                int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 10; i++)
                {
                    sum2 += int.Parse(hasCpf[i].ToString()) * multiplier2[i];
                }
                rest = sum2 % 11;
                if (rest < 2)
                {
                    rest = 0;
                }
                else
                {
                    rest = 11 - rest;
                }

                
                digit = digit + rest.ToString();
                return cpf.EndsWith(digit);
            }
            else
            {
                return false;
            }

        }

        internal static bool IsBirthDateValid(DateTime value)
        {
            // if value given is before now, compare will return value greater than zero 
            if (DateTime.Compare(DateTime.Now, value) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
