using System;

namespace MyCalculator
{
    class Program
    {
        private const double _MIN_VALUE_Double = -1000;
        private const double _MAX_VALUE_Double = 1000;
        static void Main(string[] args)
        {
            double firstDouble = 0;
            double secondDouble = 0;
            double totalDouble = 0;
            bool OKBool = true;
            Console.WriteLine("Welcome to my Calculator");
            Console.Write("\nEnter first number ");
            firstDouble = double.Parse(Console.ReadLine());
            if ((firstDouble < _MIN_VALUE_Double) || (firstDouble > _MAX_VALUE_Double))
            {
                Console.WriteLine("\nFirst input number, {0}, is not within range of {1} and {2}. Program will end.\n",
                    firstDouble, _MIN_VALUE_Double, _MAX_VALUE_Double);
                OKBool = false;
            }
            if (OKBool)
            {
                Console.Write("\nEnter second number: ");
                secondDouble = double.Parse(Console.ReadLine());

                if ((secondDouble < _MIN_VALUE_Double) || (secondDouble > _MAX_VALUE_Double))
                {
                    Console.WriteLine("\nSecond input number, {0}, is not within range of {1} and {2}. Program will end.\n",
                        secondDouble, _MIN_VALUE_Double, _MAX_VALUE_Double);
                    OKBool = false;
                }
            }
            if (OKBool)
            {
                totalDouble = firstDouble + secondDouble;

                Console.WriteLine("\n{0} + {1} = {2}\n",
                    firstDouble, secondDouble, totalDouble);
            }

            Console.WriteLine("Press ENTER key to end program");
            Console.ReadLine();
        }
    }
}