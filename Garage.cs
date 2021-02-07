// Exercise 7.8 Solution: Garage.cs
// Application calculates charges for parking
//alterations made by Nathan Mausbach
using System;

public class Garage
{
   // begin calculating charges
   public void StartCharging()
   {
      double totalReceipts = 0; // total fee collected for the day
      double fee; // the charge for the current customer
      double hours; // hours for the current customer
        int count = 0;
        int countDaily = 0;
        double dailyFee=0.00;
        double overnightFee=0.00;

      // read in the first customer's hours
      Console.Write( 
         " Enter the number of hours parked\n (or a negative or zero to quit) ->  " );
      hours = Convert.ToDouble( Console.ReadLine() );

      while ( hours > 0.0 )
      {
         // calculate and print the charges
         fee = CalculateCharges( hours );
         if (hours >= 24)
                overnightFee += fee;
         if (hours < 24)
                dailyFee += fee;   
                totalReceipts += fee;
         if (hours >= 24)
                ++countDaily;
         ++count;

         Console.WriteLine(
            "\t\t  Parking Charge -> {0:C}\n",
            fee);

            // read in the next customer's hours
            Console.Write(
            " Enter the number of hours parked\n (or a negative or zero to quit) ->  ");
         hours = Convert.ToDouble( Console.ReadLine() );

            if (hours <= 0.0)
            {
                dailyFee = totalReceipts - overnightFee;
                overnightFee = totalReceipts - dailyFee;
                Console.WriteLine("\n Parking Management Summary\tCount\tAmount\n Total Receipts .............\t{0,4}\t{1,5:C}", count, totalReceipts);
                Console.WriteLine(" Itemization\n   Daily Parking Receipts .....\t{0,4}\t {1,6:n}", countDaily, dailyFee);
                Console.WriteLine("   Overnight(24 +) Parking....\t{0,4}\t {1,6:n}", countDaily, overnightFee);
            }
      } // end while    
   } // end method StartCharging

   // determines fee based on time
   public double CalculateCharges( double hours )
   {
      // apply minimum charge
      double charge = 2;

      // add extra fees as applicable
      if ( hours > 3.0 && hours <= 24)
         charge = 2 + (double) ( 0.5 * Math.Ceiling( hours - 3.0 ) );

      // apply maximum value if needed
      if ( charge > 10 && charge <= 12.5 )
         charge = 10;

      if (hours > 24 && hours <= 48)
         charge = (double)(0.5 * Math.Ceiling(hours - 3.0));

      if (charge > 20 && charge <= 22.5)
         charge = 20;

      if (hours > 48 && hours <= 72)
         charge = (double)(0.5 * Math.Ceiling(hours - 3.0));

      if (charge > 30 )
         charge = 30;

        return charge;
   } // end method CalculateCharges
} // end class Garage


/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
