using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static decimal Add(decimal num1, decimal num2) 
        {
            return num1 + num2;
        } 

        public static string Add(int num1, int num2, bool isTrue)
        {

            int sum = num1 + num2;

            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isTrue && sum == 0)
            {
                return $"{sum} dollars";
            }

            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }

            else if (isTrue && sum < 0)
                return sum.ToString();

            return sum.ToString();
        }
    }
}
