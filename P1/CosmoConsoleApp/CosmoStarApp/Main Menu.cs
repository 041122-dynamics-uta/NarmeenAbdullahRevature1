using System;
namespace CosmoStarApp;

public class MainMenu : nMenu
{
    public void ShowMenu()
    {
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine("                  Cosmo Star Beauty supply Store");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine();
        Console.WriteLine("                            Main Menu ");
        Console.WriteLine("");
        Console.WriteLine("                   How Can We Help You Today?\n");
        Console.WriteLine("                    <1> Add Custumer");
        Console.WriteLine("                    <2> View Available Products");
        Console.WriteLine("                    <3> Store Locations");
        Console.WriteLine("                    <4> Place Order");
        Console.WriteLine("                    <5> View Order History");
        Console.WriteLine("                    <0> Exit\n\n");
        Console.Write(" Enter the number of your choice ");
    }

    public string UserPick()
    {
        string pickedChoice = Console.ReadLine();

        switch (pickedChoice)
        {
            
            case "1":
                return "AddCustumer";
            case "2":
                return "View Available Products";
            case "3":
                return "StoreLocations";
            case "4":
                return "PlaceOrder";
            case "5":
                return "OrderHistory";
            case "0":
                return "Exit";
            default:
                Console.WriteLine("You Have Entered An Invalid Choice");
                Console.WriteLine("Press ENTER to try again");
                Console.ReadLine();
                return "MainMenu";
                
        }
    }
}