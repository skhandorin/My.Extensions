using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Advanced.Demo5
{
    public static class DecimalExtensions
    {
        public static string ToString(this decimal input)
        {
            return Math.Round(input, 1).ToString();
        }
        
        public static string ToStringRounded(this decimal input)
        {
            return Math.Round(input, 1).ToString();
        }
        
        public static string ToStringRounded(this IComparable input)
        {
            return "called IComparable extensions";
        }

        public static string ToStringRounded(this IComparable<decimal> input)
        {
            return "called IComparable<decimal> extensions";
        }
    }
}
