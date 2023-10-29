using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Helpers
{
    internal static class Extension
    {
        public static bool CheckEmail(this string email)
        {
            int count = 0;
            foreach(var item in email)
            {
                if (item == '@')
                {
                    count++;
                }
                if(count == 2)
                {
                    break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }

        public static bool CheckTrimEmail(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static string GetFullName(this Person person)
        {
            return $"{person.Name}-{person.Surname}";
        }

        public static int GetMultiplyArray(this int[] arr)
        {
            int multiply = 1;
            foreach(int num in arr)
            {
                multiply *= num;
            }
            return multiply;
        }
    }
}
