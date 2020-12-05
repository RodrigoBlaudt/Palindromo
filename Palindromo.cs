using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            do
            {
                Console.WriteLine("Type a string with four characters: ");
                i = Console.ReadLine();

            } while(i.Length != 4);

            if ((i[3] == i[0]) || (i[1] == i[2]))
            {
                Console.WriteLine("The typed string it's a palindrome");
            }
            else
            {
                Console.WriteLine("The typed string it's not a palindrome");
            }
        }
    }
}