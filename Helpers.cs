using System.Text;

namespace Hex
{
    internal static class Helpers
    {
        public static string Reverse(this string str)
        {
            StringBuilder strB = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
                strB.Append(str[i]);

            return strB.ToString();
        }
    }
}
