/*	BowersHeading.cs  Bowers, W. (c) 2014 All Rights Reserved.
 *  This application may be used with my permission provided:  1) this copyright
 *  notice remains in place and unaltered; 2) not one word of code or syntax may
 *  be altered without specific, written instructions and permission; 3) the next
 *  user adds their modification notice to the existing audit trail; and 4) 
 *  permission to use automatically ends at the completion of this course.
 *  Additional modifications by A. Student, 2014
*/
/*	SchuettHeading.cs  Schuett, H. (c) 2018 All Rights Reserved.
 *  
 *  Updated to make my own.
 *  
*/

using System;

public class MausbachHeading
{
    // Global class variables
    private static string firstName = "Nathan";
    private static string lastName = "Mausbach";
    static DateTime now = DateTime.Now;

    /*public static void Main(string[] args)
    {
        getHeading("C-Sharp Programming");
        Console.WriteLine("  Personal Heading Class Self-Test");
        Console.WriteLine("\n  Testing the modified version of " + getName()
                                + "' personal heading class.");
        Console.WriteLine("  This demonstrates two styles for presenting the date, a formatted"
                                + " time\n  and utilization of a variety of method calls.");
       
        getClosing();
    }   // end Main
    */
    public static String getName()
    {
        return getFirstName() + " " + getLastName();    // was myName;
    }   // end getName() method

    public static void getHeading(String assign)
    {   // display a header
        Console.WriteLine("\n\n  " + getName() + "\n  " + assign);
        getDate();
    }   // end getHeading() method

    public static void getClosing()
    {   // Halt processing for viewing
        Console.WriteLine("\n  Program ends {0:g}", now);
        Console.Write("  Press the Enter key to continue.  ");
        Console.ReadLine();
    }   // end getClosing() method

    public static void getDate()   // ADDED, removed date from getHeading()
    {
        Console.WriteLine("  {0:MMMM d, yyyy}\n", now);
    }   // end getDate() method

    public static string getFirstName()     // ADDED
    {
        return firstName;
    }   // end getFirstName() method

    public static string getLastName()     // ADDED
    {
        return lastName;
    }   // end getLastName() method

}   // end SchuettHeading class

