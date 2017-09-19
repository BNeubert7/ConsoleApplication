using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            
            //My stuff:
            //Change that you should see later
            Console.WriteLine("Hellow World!");
            Console.WriteLine("Brandon A. Neubert");
            Console.WriteLine("From Utah, USA");

            String firstName = "Brandon";
            Console.WriteLine("Hello " + firstName);
            
            Console.WriteLine(DateTime.Today);

            DateTime christmas17 = new DateTime(2017, 12, 25);
            TimeSpan duration = christmas17 - DateTime.Today;
            Console.WriteLine("The Number of days until christmas is: " + duration);


            //Example from 2.1 in cheesy book:

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadLine();
        }
    }
}