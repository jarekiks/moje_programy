using System;

namespace ConsoleApp1
{
    class Program
    {        
        public static int CharToNumber(string c)
        {
            int l_result = 0;

            if (c == "a" || c == "b" || c == "c")
            {
                l_result = 2;
            }
            else if (c == "d" || c == "e" || c == "f")
            {
                l_result = 3;
            }
            else if (c == "g" || c == "h" || c == "i")
            {
                l_result = 4;
            }
            else if (c == "j" || c == "k" || c == "l")
            {
                l_result = 5;
            }
            else if (c == "m" || c == "n" || c == "o")
            {
                l_result = 6;
            }
            else if (c == "p" || c == "q" || c == "r" || c == "s")
            {
                l_result = 7;
            }
            else if (c == "t" || c == "u" || c == "v")
            {
                l_result = 8;
            }
            else if (c == "w" || c == "x" || c == "y" || c == "z")
            {
                l_result = 9;
            }
            else if (c == " ")
            {
                l_result = 0;
            }
            return l_result;
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj ciąg liter bądź słów: "); 
            var str = Console.ReadLine();

            for (var i = 0; i < str.Length; i++)
            {
                int x = CharToNumber(str[i].ToString());
                if (str[i] == 'a' || str[i] == 'd' || str[i] == 'g' || str[i] == 'j' || str[i] == 'm' || str[i] == 'p' || str[i] == 't' || str[i] == 'w' || str[i] == ' ')
                {
                    Console.WriteLine(x);
                }
                else if (str[i] == 'b' || str[i] == 'e' || str[i] == 'h' || str[i] == 'k' || str[i] == 'n' || str[i] == 'q' || str[i] == 'u' || str[i] == 'x')
                {
                    Console.WriteLine(x + " " + x);
                }
                else if (str[i] == 'c' || str[i] == 'f' || str[i] == 'i' || str[i] == 'l' || str[i] == 'o' || str[i] == 'r' || str[i] == 'v' || str[i] == 'y')
                {
                    Console.WriteLine(x + " " + x + " " + x);
                }
                else
                    Console.WriteLine(x + " " + x + " " + x + " " + x);
            }
        }
    }
}
