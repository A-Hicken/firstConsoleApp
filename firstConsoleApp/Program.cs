// See https://aka.ms/new-console-template for more information

using System;
using System.Formats.Asn1;

namespace firstConsoleApp;


//Class Declaration
public class Person

{
    static void Main(string[] args)
    {
        // Type your name and press enter
        Console.WriteLine("What is your name?");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine($"Hi! {userName} Where are you from?");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string location = Console.ReadLine();

        //Print the value of the variable (location), which will display in the input value
        Console.WriteLine($"I have never been to {location}. I bet it is nice.");

        MeasureClass measurement = new MeasureClass();
        measurement.MeasureNumbers();

        ChristmasCountDown christmasCountDown = new ChristmasCountDown();
        christmasCountDown.DaysToChristmas();
    }

 
}
