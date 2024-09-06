using System;

namespace AppleStore
{
    class AppleStoreApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================\n" +
                "     WELCOME CUSTOMER!\n"+
                "==============================\n" +
                "Please enter the amount of apples you want to purchase.\n"+
                "Each apple costs Php32.50\n");

            Console.Write("ENTER AMOUNT HERE: ");
            int userAppleAmount = Convert.ToInt32(Console.ReadLine());

            // CALCULATING THE TOTAL PRICE AND ROUND OFF
            double totalPrice = userAppleAmount * 32.50;
            int roundedPrice = (int)totalPrice;

            Console.WriteLine("\nFor " + userAppleAmount + " apples, your total price is: Php" + totalPrice + "\nWhen rounded off, the price is: "+roundedPrice);

            // THANKING THE CUSTOMER
            Console.WriteLine("==============================\n" +
                " THANK YOU FOR YOUR PURCHASE\n" +
                "==============================\n");
        }
    }
}