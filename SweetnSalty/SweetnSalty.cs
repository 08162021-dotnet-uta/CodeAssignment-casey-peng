using System;

namespace SweetAndSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSweet = 0;
            int countSalty = 0;
            int countSweetNSalty = 0;
           
          
                for(int i = 1; i <= 1000; i++)
                {

                    if(i%3 == 0 && i % 5 == 0)
                    {
                        Console.Write("sweet’nSalty ");
                        countSweetNSalty++;
                    }else if (i %3 == 0)
                    {
                        Console.Write("sweet ");
                        countSweet++;
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("salty ");
                        countSalty++;
                    }else 
                {
                    Console.Write(i);
                }
                    if(i%10==0)
                {
                    Console.WriteLine();
                }
            
                }
               
            
            Console.WriteLine($"TOTAL NUM OF SWEET AND SALTY{countSweetNSalty}");
            Console.WriteLine($"TOTAL NUM OF SWEET {countSweet}");
            Console.WriteLine($"TOTAL NUM OF  SALTY{countSalty}");
        }
    }
}
