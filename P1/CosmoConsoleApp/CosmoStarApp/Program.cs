using System;
using System.Collections.Generic;
using CosmoStarDomain;
using CosmoStarModel;
using CosmoStarRepo;


namespace CosmoStarApp
{
  class Program
    {
        static void Main(string[] args)
        {
            
            //Get the Customer's Information to setup Login or register  
            Console.WriteLine("                                                        ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><<><><><><><><><><><><><><><>");
            Console.WriteLine("                                                        ");
            Console.WriteLine("Welcome, Have a good time Shopping with CosmoStar Cosmetics");   
            Console.WriteLine("                                                        ");   
            Console.WriteLine("<><><><><><><><><><><><><><><><><<><><><><><><><><><><><><><>");
            Console.WriteLine("                                                        ");
            Console.WriteLine("Please Enter \n 1 to Register \n 2 to Login ");
            
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice) 
            {

            case 1:

                Console.WriteLine("                                             ");
                Console.WriteLine("Registration Requirements:");
                Console.WriteLine("Enter First Name Please");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name Please");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Your Email Please");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter Your password Please");
                string MySecret = Console.ReadLine();
                
                CosmoRepoClass CRC = new CosmoRepoClass();
                DomainClass DC = new DomainClass(CRC);
                List<CosmoCustomer> NewCustomersRegistration = DC.MembersList(FirstName, LastName, Email, MySecret) ;
                break;


            case 2:

            Console.WriteLine("Hello Valued Client, please do the following to Login:-");
            Console.WriteLine("Enter your Registered Email");
            string RegEmail = Console.ReadLine();
            Console.WriteLine("Enter your Registered Password");
            string RegPass = Console.ReadLine();


            //sends variables to the repo and domain classes for verification
            //if its verfiied do while loop store options for shopping
         
            CosmoRepoClass CRC1 = new CosmoRepoClass();
            DomainClass DC1 = new DomainClass(CRC1);
            List<CosmoCustomer> ExistingCustomers = DC1.uNamePwordExists(RegEmail, RegPass) ;

            break;

            default:

            Console.WriteLine("Invalid informations, Please Try Again");
            break;
            }

            

            bool  Looping = true;
            while (Looping)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("<><><><><><><><><><><><><><><><><<><><><><><><><><><><><><><>");
                Console.WriteLine("Greetings Valued Client, You are now Registered");
                Console.WriteLine("                                                 ");
                Console.WriteLine("Enter 1 to Choose Your Store Location");
                Console.WriteLine("Enter 2 To View All Products");
                Console.WriteLine("Enter 3 To Order");
                
                
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                switch (UserChoice)
                {
                case 1:

                    
                    Console.WriteLine("Please Select One of CosmoStar Cosmetics Shop Locations");
                    Console.WriteLine("                                                        ");
                    CosmoRepoClass CRC2 = new CosmoRepoClass();
                    DomainClass DC2 = new DomainClass(CRC2);
                    List<StoreLocations> SL = DC2.StoreLocationsList();
                    foreach(StoreLocations SL2 in SL)
                    {
                        Console.WriteLine($"City >>> [{SL2.City}]");
                        Console.WriteLine("                          ");
                        //string LocationSelected = Convert.ToString(Console.ReadLine()); 

                         }
                    Looping = true;
                    string LocationSelected = Convert.ToString(Console.ReadLine());
                    break;

                case 2:
                    CosmoRepoClass MRC3 = new CosmoRepoClass();
                    DomainClass SADC3 = new DomainClass(MRC3);
                    List<Inventory> SI = SADC3.InventoryList();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("Here is the list of Products :");
                    foreach(Inventory SI2 in SI)
                    {
                        
                        Console.WriteLine("             ");
                        Console.WriteLine($"Item Name >>> [{SI2.ItemName}]");
                        Console.WriteLine($"Item Price >>> [{SI2.ItemPrice}]");
                        Console.WriteLine($"Item Description >>> [{SI2.ItemDescription}]");
                        Console.WriteLine($"Item Quantity >>> [{SI2.ItemQuantity}]");
                        Console.WriteLine("             ");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");
                        //
                        int ItemPrice = SI2.ItemPrice;
                        string ItemDescription = SI2.ItemDescription;
                        
                    }
                    
                        Console.WriteLine("Whats your Item Name");
                        string ItemName= Console.ReadLine();
                        Console.WriteLine("Whats The Quantity");
                        int ItemQuantity = Convert.ToInt32(Console.ReadLine());
                    Looping = true;
                    break;

                case 3:
                    CosmoRepoClass CRC4 = new CosmoRepoClass();
                    DomainClass DC4 = new DomainClass(CRC4);
                    List<OrderHistory> OH = DC4.OrderHistoryList();
                    Console.WriteLine("Start to Order Here:");
                    foreach(OrderHistory OH2 in OH)
                    {
                        Console.WriteLine($"Item Name >>> [{OH2.ItemName}]");
                        Console.WriteLine($"Item Price >>> [{OH2.ItemPrice}]");
                        Console.WriteLine($"Item Description >>> [{OH2.ItemDescription}]");
                        Console.WriteLine($"Item Quantity >>> [{OH2.Quantity}]");
                        
                        int ItemPrice = Convert.ToInt32(OH2.ItemPrice);
                    }
                    Console.WriteLine("Please Select your Item Name");
                    string SelectedItemName= Console.ReadLine();    
                    Console.WriteLine("Enter Your Quantity");
                    string SelectedItemQuantity = Console.ReadLine();
                    Looping = true;
                    break;
                    // not really needed, if you remove the default
                    // then your loop will not exit and you can start again
                    
                case 4:

                    Looping = false;
                    break;
                }

                Console.WriteLine("                            ");
                Console.WriteLine("What's Next?? \n Please Select from the Following: \n 1 Change Store Location \n 2 To View Products \n 3 To View Order history \n 4 to Exit");
                Looping = true;
            }

                    
                    
            }
        }
}


         
