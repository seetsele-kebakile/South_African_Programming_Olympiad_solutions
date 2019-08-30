using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_olympyiad
{
    class primenumber
    {
        
        static void Main(string[] args)
        {
            int nthterm;
            int cyclednum = 2;
            bool istaskdone = false;
            int divisor;
            int numprimesfound = 0;
            int result = 0;
            bool isprime;
            Console.WriteLine("enter the prime number's nth term");
            nthterm = int.Parse(Console.ReadLine());

            while(istaskdone == false)
            {
                isprime = true;
                divisor = 2;
                while(cyclednum > divisor && isprime == true )
                {
                    if(cyclednum % divisor == 0)
                    {
                        isprime = false;
                    }
                    divisor++;
                }

                if(isprime == true)
                {
                    numprimesfound++;
                }
                if(numprimesfound == nthterm)
                {
                    result = cyclednum;
                    istaskdone = true;
                }
                cyclednum++;
            }
            Console.WriteLine( result);
            Console.ReadKey();
        }
    }
}
