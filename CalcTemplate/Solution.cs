using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTemplate
{
    static class Solution
    {
        public static string Result(string first, string second, string action)
        {

            switch (action)
            {
                case "+":
                   return Addition(first, second);
                case "-":
                    return Substraction(first, second);
                case "*":
                    return Multiplication(first, second);
                case "/":
                    return Division(first, second);
                default:
                    break;
            }

            return "error";
        }

        public static string Addition(string first, string second)
        {
            return (Convert.ToInt32(first) + Convert.ToInt32(second)).ToString();
        }
        public static string Substraction(string first, string second)
        {
            return (Convert.ToInt32(first) - Convert.ToInt32(second)).ToString();
        }
        public static string Multiplication(string first, string second)
        {
            return (Convert.ToInt32(first) * Convert.ToInt32(second)).ToString();
        }
        public static string Division(string first, string second)
        {
            if (Convert.ToInt32(second) != 0)
            {
                return (Convert.ToInt32(first) / Convert.ToInt32(second)).ToString();
            }
            else
            {
                return "Divide by zero";
            }
        }
    }
}
