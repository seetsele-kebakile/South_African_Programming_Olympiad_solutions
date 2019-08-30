using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_olympyiad
{
    class triangletagger
    {
        static void Main(string[] args)
        {
            int numangles = 3;
            int[] angles = new int[numangles];
            int sumangles = 0;
            int numequalangles = 0;
            int counter2 = 0;
            for(int counter = 0;counter<numangles;counter++)
            {
                Console.WriteLine("please enter angle " + counter);
                angles[counter] = int.Parse(Console.ReadLine());
                sumangles += angles[counter];
            }

            if (sumangles != 180)
            {
                Console.WriteLine("IMPOSSIBLE");
            }
            else
            {
                for (int counter = 0; counter < numangles; counter++)
                {
                    counter2 = counter + 1;
                     while(counter2 < numangles)
                     {
                        if(angles[counter] == angles[counter2])
                        {
                            numequalangles++;
                        }
                        counter2++;
                     }
                }
                if (numequalangles == 3)
            {
                Console.WriteLine("EQUILATERAL");
            }
            else if(numequalangles == 1)
            {
                Console.WriteLine("ISCOCELES");
            }
            else if(numequalangles == 0)
            {
                Console.WriteLine("SCALENE");
            }

            }
          

            Console.ReadKey();
        }
    }
  }
