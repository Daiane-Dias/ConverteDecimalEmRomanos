using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteDecimalEmRomanos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>() { 1, 2, 3, 4 };
            var num2 = 2;
            var romanos = ConverteEmRomanos(num2);
            Console.WriteLine($"numeros Romandos de {num2} é {romanos}");

        }

        private static string ConverteEmRomanos(int n)
        {
            string[] roman_symbol = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] int_value = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var roman_numerals = new StringBuilder();
            var index_num = 0;

            while (n != 0)
            {
                if (n >= int_value[index_num])
                {
                    n -= int_value[index_num];
                    roman_numerals.Append(roman_symbol[index_num]);
                    return roman_symbol[index_num].ToString();
                }
                else
                {
                    index_num++;
                }

            }
            return null;
        }
    }

}
