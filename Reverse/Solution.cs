using System;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Solution
    {
        public static int Reverse(int x)
        {
            if (x >= int.MaxValue)
                return 0;

            char[] numArrChar = new StringBuilder().Append(x).ToString().Replace("-", "").ToCharArray().Reverse().ToArray();

            var numStr = string.Concat(numArrChar);
            if (decimal.Parse(numStr) >= int.MaxValue)
                return 0;

            int num = int.Parse(string.Concat(numArrChar));

            return x < 0 ? num * -1 : num;
        }
    }
}
