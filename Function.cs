using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab._1
{
    class Function
    {
        public static string Factorial(int n)
        {
            int resault = 1;
            string nothing = "Не допустиме чісло!!";
            if (n > 1 && n <= 9)
            {
                for (int i = 1; i <= n; i++)
                {
                    resault *= i;
                }
                return Convert.ToString(resault); ;
            }
            else
            {
                return nothing;
            }
            
        } 
    }
 }

