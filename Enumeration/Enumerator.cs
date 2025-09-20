
// Amir Moeini Rad
// September 2025

// Main Concept: Enumeration
// 'Enumeration' means a complete, ordered listing or collection of all the items in a collection.


using System;

namespace Enumeration
{
    internal class Enumerator
    {
        // An enumeration is a distinct value type with named constants.
        // The default first value is 0;
        // The default type is int.
        public enum Color
        {
            Red, // 0
            White, // 1
            Blue // 2
        }


        // Another enumeration of integer values.
        public enum Month
        {
            January = 1, // First value explicitly set to 1
            February, // 2
            March, // 3
            April, // 4
            May, // 5
            June, // 6
            July, // 7
            August, // 8
            September, // 9
            October, // 10
            November, // 11
            December // 12
        }


        // An enumeration of byte values.
        public enum ColorNew : byte
        {
            Red, White, Blue
        }


        ////////////////////////////////////////////////
        

        // A structure that uses the Month enumeration.
        public struct Birthday
        {
            public Month month;
            public int day;
            public int year;
        }


        ////////////////////////////////////////////////


        // Main method.
        public static void Main()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enumerations in C#.NET.");
            Console.WriteLine("-----------------------\n");



            // (1) Working with the Color enumeration.

            string buffer;
            Color myColor;

            Console.Write("Enter a value for a color: 0 = Red, 1 = White, 2 = Blue): ");
            buffer = Console.ReadLine();

            // Convert the string to an integer, then cast the integer to Color.
            myColor = (Color)Convert.ToInt32(buffer);

            switch (myColor)
            {
                case Color.Red:
                    Console.WriteLine("Switched to Red...");
                    break;
                case Color.White:
                    Console.WriteLine("Switched to White...");
                    break;
                case Color.Blue:
                    Console.WriteLine("Switched to Blue...");
                    break;
                default:
                    Console.WriteLine("Switched to default...");
                    break;
            }

            Console.WriteLine("Color is {0} ({1}).", myColor, (int)myColor);



            // (2) Working with the Birthday struct and the Month enumeration.

            Birthday myBirthday;
            myBirthday.day = 10;
            myBirthday.month = Month.August; // or myBirthday.month = (Month) 8;
            myBirthday.year = 1980;

            Console.WriteLine("\nMy birthday is {0} {1}, {2}.", myBirthday.day, myBirthday.month, myBirthday.year);



            // (3) Working with the ColorNew enumeration.

            // The 'Random' class is used to generate a random number.
            Random rnd = new Random();
            int roll = rnd.Next(0, 3); // A random number between 0 and 2.
            ColorNew myColorNew;
            myColorNew = (ColorNew)roll;

            Console.WriteLine("\nMy New Color is {0} ({1} of type {2}).", myColorNew, (byte)myColorNew, myColorNew.GetTypeCode());


            Console.WriteLine("\nDone.");
        }
    }
}
