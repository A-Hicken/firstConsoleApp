using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MeasureClass
{
    public void MeasureNumbers()
    {

        Console.WriteLine("Please input a Width:");

        // Width double variable
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Please input a Height:");

        // Height double variable
        double height = double.Parse(Console.ReadLine());

        // Length double variable
        double length = 2 * width * 2 * 3.25;

        // Area double variable
        double area = height * width * 2;

        Console.WriteLine($"The length of the wood is {length} feet");
        Console.WriteLine($"The area of the glass if {area} square meters");
    }

}
