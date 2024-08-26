using System;

namespace PaintCalculator_We
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialising current variables 
            double deductableArea = 0;
            //assuming a 5l can of paint is being used
            double paintCanCapacity = 5;

            //gaining user input
            Console.WriteLine("What is the height of your wall? ");
            double heightInpit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the length of your wall? ");
            double lengthInput = Convert.ToDouble(Console.ReadLine());

            //checking external factors
            Console.WriteLine("Does your room have windows? ");
            string windowsChoice = Console.ReadLine();
            if (windowsChoice == "yes" ||  windowsChoice == "Yes") 
            {
                Console.WriteLine("How many windows does it have? ");
                int windowsNo = Convert.ToInt32(Console.ReadLine());
                //assuming the area of the window is 635mmx890mm
                deductableArea = (0.635 * 0.89) * windowsNo;
            }

            //calculating the surface area of the room
            double totalArea = heightInpit * lengthInput;
            //assuming the area of the door is 762mmx1.981
            deductableArea = deductableArea + (0.762 * 1.981);
            totalArea = (totalArea * 4) - deductableArea;

            //calculating the paint needed
            //assuming that 1sqm of paint takes 100ml
            double oneCoatVolume = totalArea * 100;
            //assuming each wall needs two coats
            double totalVolumeNedded = (oneCoatVolume * 2) / 1000; //measured in litres
            

            //calculting how many paint cans you need
            if (totalVolumeNedded < paintCanCapacity)
            {
                Console.WriteLine("You will only need one can of paint to paint your room. ");
            }
            else
            {
                int cansNeeded = Convert.ToInt32(Math.Ceiling(totalVolumeNedded / paintCanCapacity));
                Console.WriteLine($"You will need {cansNeeded} cans of paint to paint your room. ");
            }

        }
    }
}