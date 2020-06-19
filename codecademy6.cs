using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b      = false;
            string s    = Convert.ToString(b);
            Console.WriteLine(s);
            char[] c    = { s[1], s[0], s[2], s[3], s[4]};
            Console.WriteLine(c);
            var date1 = new DateTime(1981,08,16,10,34,15);
            Console.WriteLine(Convert.ToString(date1));
        }
    }
}