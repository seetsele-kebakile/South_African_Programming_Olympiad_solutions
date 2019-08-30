using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_olympyiad
{
    class right_trucatableprime
    {

      static  bool isrighttucatable(string value)
        {
            int divisor, cyclednum, counter;
            int numdigits, numprimedigits = 0;
            string num;
            bool isprime;
            counter = 0;
            num = value;
            numdigits = num.Length;
            counter = 0;
            while (counter < numdigits)
            {
                divisor = 2;
                isprime = true;
                cyclednum = int.Parse(num);
                while (isprime == true && cyclednum > divisor)
                {
                    if (cyclednum % divisor == 0)
                    {
                        isprime = false;
                    }
                    divisor++;
                }
                if(num == "1")
                {
                    isprime = false;
                }
                if (isprime == true)
                {
                    numprimedigits++;
                  
                }
                num = num.Remove(num.Length - 1);
               
                counter++;

            }
            if (numdigits == numprimedigits)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
      static void Main(string[] args)
        {
            int nthterm;
            bool istaskdone;
            int numrightrucatableprimes = 0;
            string cyclednum = "2";
            istaskdone = false;
            string result = "";
            Console.WriteLine("enter the nth term");
            nthterm = int.Parse(Console.ReadLine());
            while (!istaskdone)
            {
                if (isrighttucatable(cyclednum))
                {
                    numrightrucatableprimes++;
                 
                }
                if(numrightrucatableprimes == nthterm)
                {
                    result = cyclednum;
                    istaskdone = true;
                }
                cyclednum = (int.Parse(cyclednum) + 1).ToString();
            }
            Console.WriteLine( result);

           
            Console.ReadKey();
        }
     
    }
}
