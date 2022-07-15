using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double x)
        {

            return (x - 32D) * 5D / 9D;
        }
        public static double CelciusToFarenheit(double x)
        {
            return (x * 1.8) + 32D;
        }

        public static void CelciusOrFarenheit()
        {
            Console.WriteLine("Would you like to convert from Farenheit or Celcius?");
            Console.Write("Please enter f or c: ");
            string userInput = Console.ReadLine();
            if (userInput == "F" || userInput == "f")
            {
                Console.WriteLine("Please enter the temperature you would like to convert in Farenheit: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                Console.Write($"{temp}f is equal to ");
                Console.WriteLine(TempConverter.FarenheitToCelcius(temp));
                Console.Write("c");
            }
            else if (userInput == "C" || userInput == "c")
            {
                Console.WriteLine("Please enter the temperature you would like to convert in Celcius: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                Console.Write($"{temp}c is equal to ");
                Console.Write(TempConverter.CelciusToFarenheit(temp));
                Console.Write("f");
            }
            else
            {
                Console.WriteLine("Please enter f or c: "); 
                 
            }
            
        }
    }
}

