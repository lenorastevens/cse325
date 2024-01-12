using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFristColsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Lenora Stevens";
            string location = "Texas";
            DateTime date = DateTime.Now;
            DateTime christmas = new DateTime(2024, 12, 25);
            TimeSpan daysToChristmas = date.Subtract(christmas);


            Console.WriteLine("Hello World!\n");

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am from {location}.\n");

            Console.WriteLine("Today is " + date.ToString("MM/dd/yyyy"));
            Console.WriteLine($"Number of days to Christmas: " + daysToChristmas.ToString("dd"));

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nWhat is the width of the glass? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height of the glass? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine($"\nThe length of the wood is {woodLength} feet.");
            Console.WriteLine($"\nThe area of the glass is {glassArea} square metres.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
