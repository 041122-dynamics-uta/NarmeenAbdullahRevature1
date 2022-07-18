using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetconsole_SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //This Program prompts user to enter start number, stop number
             // also prompt user to enter the quantity of numbers to be printed print per line
             //if the numbers is a multiple of 3, the program will print "Sweet" (instead of the number) to the
             //console; and "Salt" if the number is a multiple of 5; if numbers are multiples of both
             //3 and 5, it prints "SweetnSalty" to the console (instead of the number).
             //then it prints to the console on 3 separate lines:
             // how many "Sweet",
             // how many "Salty", and
             // how many "Sweet’nSalty"



             //Getting the start and stop numbers (the range) form user and the numbers printed per line 
             
            Console.WriteLine("Hello, Let's Play SweetnSalty");
            Console.WriteLine("Enter The Start Number");
            int start = Convert.ToInt32(Console.ReadLine());  //converting string to int
            Console.WriteLine("Enter The Stop Number");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Qty of Numbers to be printed per line");
            int qty = Convert.ToInt32(Console.ReadLine()); // int qty >>>> is the quantity of numbers printed per line


            int rangeOfNumbers = stop - start;  //finding the range  - Thanks to Alec and Cameron

            //using Enumerable allowing the use of a numbers range method
            IEnumerable<int> collection = Enumerable.Range(start, rangeOfNumbers);
            //collection is list of numbers taken from user as range from start to stop

            int counter = 0; //the counter for processed sweet , salt, or sweetnsalt

            // intiating variables values
            int sweet = 0; 
            int salty = 0;
            int SweetnSalty = 0;

            foreach(int number in collection)
            {
                
                //defining sweetnsalty "numbers divisible by 3 & 5"
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("SweetnSalty");
                    SweetnSalty++; //increasing SweetnSalty variable to give the total later in console to the user
                } 


                //defining sweet "numbers divisible by 3"
                else if ( number % 3 == 0)
                {
                    Console.WriteLine("Sweet");
                    sweet++; //increasing sweet variable to give the total later in console to the user
                }


                //defining salty "numbers divisible by 5"
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Salty");
                salty++; //increasing salty variable to give the total later in console to the user
                }  


                else
                {
                Console.WriteLine($"{number}"); // printing the actual numbers
                }
                counter++;   


                //if there's no range (no sart to stop range) if start = stop means no range
                if(counter == qty) 
                {
                    Console.WriteLine();
                    counter = 0;
                }              
            }

            //printing to console
            Console.WriteLine();
            Console.WriteLine($"The Number of Sweets is {sweet}");
            Console.WriteLine($"The Number of Saltys is {salty}");
            Console.WriteLine($"The Number of SweetnSalty is {SweetnSalty}");
            Console.WriteLine();
        }
    }
}
