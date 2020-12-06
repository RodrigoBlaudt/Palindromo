using System;
using System.Linq;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {

            int min, max, range;
            int[] cont = new int[0];
            int j = 0;

            Console.WriteLine("Type the minimum value: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            
            range = max-min;
            cont = new int[range];

            for (int i = min; i < max; i++) 
            {
                cont[j] = i;
                cont[j]++;
                j++;
            }
        
            foreach(var item in cont)
            {
                string n = item.ToString();
                string n_reverse = new string(n.Reverse().ToArray());

                if (n == n_reverse)
                {
                    Console.WriteLine($"The value: {n} it's a palindrome.");
                }
            }
        }
    }
}