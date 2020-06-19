/* implicit convertion works

csharp> int myI = 8;   
csharp> double otroD = myI;
csharp> otroD
8

*/

/* explicit conversion
double a = 3.2;
int x = (int)a;
*/
using System;

namespace ConversionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fave Number? ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}