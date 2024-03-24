using System;

public class Program
{
   public static void Main()
    {
        // Current stock values for soda, chips, candy all stored as int variables. 
	    // The same storage type for the 3 tiems but also has the restock value.
	   
        int currentSoda = 100;
        int restockSoda = 40;

        int currentChips = 40;
        int restockChips = 20;

        int currentCandy = 60;
        int restockCandy = 40;

	    // Copying the header as provided in the "Console Output Example" section
	   
        Console.WriteLine("Welcome to the restocking tool.\n");

        /* Asking the employee the stock of each item and then returning the acutal number available. 
	       Depending on the answer, either return the restock number or provide the amount of stock left for each item.*/
	   
	   
	   //SODA Section
	   
        Console.WriteLine("How many sodas have been sold today? " + currentSoda + " are in stock.");
	   
        int soldSoda = int.Parse(Console.ReadLine());
	   
        if (soldSoda <= currentSoda)
        {
            currentSoda -= soldSoda;
            Console.WriteLine("There are " + currentSoda + " sodas left.\n");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted.\n");
        }

   
	   //CHIPs Section 
	   
        Console.WriteLine("How many chips have been sold today? " + currentChips + " are in stock.");
	   
        int soldChips = int.Parse(Console.ReadLine());
	   
        if (soldChips <= currentChips)
        {
            currentChips -= soldChips;
            Console.WriteLine("There are " + currentChips + " chips left.\n");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted.\n");
        }

       //CANDY Section 
	
        Console.WriteLine("How much candy has been sold today? " + currentCandy + " are in stock.");
	   
        int soldCandy = int.Parse(Console.ReadLine());
	   
        if (soldCandy <= currentCandy)
        {
            currentCandy -= soldCandy;
            Console.WriteLine("There is " + currentCandy + " candy stock left.\n");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted.\n");
        }

	   
        // The next section provides the restocking item count back to the employee.
	   
	  
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.\n");
        if (currentSoda <= restockSoda)
        {
            Console.WriteLine("Sodas needs to be restocked.\n");
        }
        if (currentChips <= restockChips)
        {
            Console.WriteLine("Chips needs to be restocked.\n");
        }
        if (currentCandy <= restockCandy)
        {
            Console.WriteLine("Candy needs to be restocked.\n");
        }

	   //Sign off greeting.
	   
        Console.WriteLine("Goodbye!");
    }
}
