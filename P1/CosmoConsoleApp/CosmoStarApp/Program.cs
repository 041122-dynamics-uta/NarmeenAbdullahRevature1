using System;
using System.Collections.Generic;
using CosmoStarDomain;
using CosmoStarModel;
using CosmoStarRepo;
using System.Data.SqlClient;
using System.Data;


namespace CosmoStarApp
{
  class Program
    {
        static void Main(string[] args)
        {
            //instantiation
            //simulate dependency injection
            //creating instance to communicate with repo class 
            CosmoRepoClass crc = new CosmoRepoClass();
            //creating instance to communicate with domain(Business) class
            //in Domainclass there is constructor takes 1 argument (r)
            DomainClass dc = new DomainClass(crc);

            string cName="";
            string cNumber="";
            string cAddress="";
            string cEmail="";
            

            //start the program here!
            Console.WriteLine("Would you like to see a list of all the members?");
            string answer = Console.ReadLine();

            bool Continue = false;
            while (Continue == false){
                
                //write a Welcome string and make a loop for register/login

                Console.WriteLine("Hello Valued Customer!");
                Console.WriteLine("please Enter your Choice /n Enter 1 to Login /n Enter 2 to Register");
                string choice = Console.ReadLine();

                switch(answer){
                case "1":
                Console.WriteLine("Please Enter your Prefered User Name:");
                String PuserName = Console.ReadLine();
                Console.WriteLine("Please Enter Prefered Password:");
                String Ppassword = Console.ReadLine();
                Continue = true;
                break;

                case "2":
                Console.WriteLine("Please Enter User Name:");
                String userName = Console.ReadLine();
                Console.WriteLine("Please Enter Password:");
                String Password = Console.ReadLine();
                Continue = true;
                Member newMember = dc.newMember(cName, cNumber, cAddress, cEmail);
                break;

                default:
                
                Console.WriteLine("Invalid Choice");
                break;




            }

            }

            // choose a store loop



            // on choosing a store correctly, you query the Db for the products of th at store,. 




            //fill your cart loop
            // Dictionary<Product>
            //present them with the products
            // they choose a product and the quantity the way
            // over and over
            // make don't choose more product that there are in inventory 
            // once the y choose to check out, break out of loop





            //add up the total.
            // insert the ordered products in to the Db.
            // make sure to decrement the inventory or each rproduct in the stores inventory.



            // ask if they would like to continue shopping. if yes.. loop back to the top.
            // if no, log them out and loop back to the very very tip top () login .


            

            if (answer.CompareTo("yes") == 0)
            {
                // create the member class
                List<Member> members = dc.MembersList();

                foreach (Member m in members)
                {
                    Console.WriteLine($"The members data is cName-{m.cName}.....");
                }

            }

        }
    }
}
