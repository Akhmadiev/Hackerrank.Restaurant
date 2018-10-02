using System;

namespace Hackerrank.Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(restaurant(391, 567));
        }

        static int restaurant(int l, int b)
        {
            var square = l * b;

            for (var i = l; i > 0; i--)
            {
                if (l % i == 0)
                {
                    if (b % i == 0)
                    {
                        return square / (i * i);
                    }
                }
            }

            return square;
        }
    }
}
