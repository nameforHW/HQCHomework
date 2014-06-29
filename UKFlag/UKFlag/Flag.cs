using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task descriptiion in a separate file. In a nutshell: print the UK Flag with lines according to the input odd number n.

namespace UKFlag
{
    class Flag
    {
        static void Main(string[] args)
        {
               int n = int.Parse(Console.ReadLine());

        int dots1 = n / 2 - 1;
        int dots2 = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dots2));
            Console.Write('\\');
            Console.Write(new string('.', dots1));
            Console.Write('|');
            Console.Write(new string('.', dots1));
            Console.Write('/');
            Console.Write(new string('.', dots2));


            Console.WriteLine();

            dots2++;
            dots1--;
        }

        Console.Write(new string('-', n / 2));
        Console.Write('*');
        Console.WriteLine(new string('-', n / 2));

        dots2 = n / 2 - 1;
        dots1 = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', dots2));
            Console.Write('/');
            Console.Write(new string('.', dots1));
            Console.Write('|');
            Console.Write(new string('.', dots1));
            Console.Write('\\');
            Console.Write(new string('.', dots2));


            Console.WriteLine();

            dots2--;
            dots1++;
        }

        }
    }
}
