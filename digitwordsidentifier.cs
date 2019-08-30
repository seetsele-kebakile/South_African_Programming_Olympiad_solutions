using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_olympyiad
{
    class digitwordsidentifier
    {
        static void Main(string[] args)
        {
            string[] digitwords = { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
            int[] charsfound = new int[digitwords.Length];
            string result = "NONE";
            string word;
            Console.WriteLine("enter a word");
            word = Console.ReadLine();
            
            foreach (char c in word)
            {
                for(int counter = 0; counter < 9;counter++)
                {
                    var digitword = digitwords[counter];
                    var numcharsfound = charsfound[counter];

                    if(numcharsfound < digitword.Length)
                    {
                        if(digitword[numcharsfound] == c)
                        {
                            charsfound[counter]++;
                        }
                    }
                }
            }

            for(int counter = 0;counter<9;counter++)
            {
                if(digitwords[counter].Length == charsfound[counter])
                {
                    result = digitwords[counter];
                    break;
                }
            }


            Console.WriteLine( result);
            Console.ReadKey();
        }

    }
}
