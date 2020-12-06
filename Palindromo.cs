using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {

            int min;
            int max;
            int range;
            int[] cont = new int[0];
            string[] s_array = new string[1000];
            int j = 0;

            Console.WriteLine("Type the minimum value with four characters: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the maximum value with four characters: ");
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

                if ((n[3] == n[0]) && (n[1] == n[2]))
                {
                    Console.WriteLine($"The value: {n} it's a palindrome");
                }
                else
                {
                    Console.WriteLine($"The value: {n} it's not a palindrome");
                }
            }
        }
    }
}