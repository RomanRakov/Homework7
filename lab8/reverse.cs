using System;
namespace lab8
{
    internal class Reverse
    {
        public static string reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
