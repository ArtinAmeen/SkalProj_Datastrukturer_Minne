using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            List<string> stringList = new List<string>();
            string input = Console.ReadLine();

            char[] str = new char[input.Length - 1];

            if (input[0] == '+')
            {
                for (int i = 1; i < input.Length; i++)
                {
                    str[i - 1] = input[i];
                }
                // string newElement = string.Join(str);
            }

            else if (input[0] == '-')
            {
            }
        }

    }

        public void ExamineList()
        {
        }
    }
}
