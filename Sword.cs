using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword
{
    class Sword
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            string topRow = new string('#', n - 1) + '/' + '^' + '\\' + new string('#', n - 1);
            Console.WriteLine(topRow);

            int sharps = n - 3;
            for (int row = 1; row <= n / 2; row++, sharps--)
            {
                Console.WriteLine(new string('#', sharps) + '.' + new string(' ', width - 2 * sharps - 2) + '.' + new string('#', sharps));
            }
            sharps++;

            for (int row = 1; row <= 4; row++)
            {
                switch (row)
                {
                    case 1: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'S' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' +new string('#', sharps)); break;
                    case 2: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'O' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    case 3: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'F' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    case 4: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'T' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    default: break;
                }
            }

            if ((n == 4) || (n == 5))
            {
                Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + ' ' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps));
            }
            else 
            {
                for (int row = 1; row <= n - 4; row++)
                {
                    Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + ' ' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps));
                } 
            }
            
            


            


            for (int row = 1; row <= 3; row++)
            {
                switch (row)
                {
                    case 1: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'U' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    case 2: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'N' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    case 3: Console.WriteLine(new string('#', sharps) + '|' + new string(' ', (width - 2 * sharps - 3) / 2) + 'I' + new string(' ', (width - 2 * sharps - 3) / 2) + '|' + new string('#', sharps)); break;
                    default: break;
                }
            }

            Console.WriteLine('@' + new string('=', width - 2) + '@');

            sharps += 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine(new string('#', sharps) + '|' + new string(' ', width - 2 * sharps - 2) + '|' + new string('#', sharps));
            }

            Console.WriteLine(new string('#', sharps) + '\\' + new string('.', width - 2 * sharps - 2) + '/' + new string('#', sharps));
        }
    }
}
