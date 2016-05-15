using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> Alphabet = new List<char>();
            List<string> Message = new List<string>();
            for (int i = 65; i < 91; i++)
            {
                Alphabet.Add((char)i);
            }
            var stroke = Console.ReadLine().ToString();
            foreach (var letter in stroke)
            {
                if (Alphabet[Alphabet.Count - 1] == letter)
                {
                    Message.Add((66.ToString()));
                }
                if (Alphabet[Alphabet.Count - 2] == letter)
                {
                    Message.Add((65.ToString()));
                }
                if (Convert.ToChar(" ") == letter)
                {
                    Message.Add(" ");
                }
                foreach (var item in Alphabet)
                {
                    
                    if (item == letter && letter != Alphabet[Alphabet.Count -1] && letter != Alphabet[Alphabet.Count - 2])
                    {
                        Message.Add((item + 2).ToString());
                    }
                }
            }
            foreach (var item in Message)
            {
                if (item != " ")
                {
                    Console.Write(Convert.ToChar(Convert.ToInt16(item)));
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ReadLine();
        }
    }
}
