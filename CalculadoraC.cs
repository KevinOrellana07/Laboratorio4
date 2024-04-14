using System;

namespace MyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 128;
            double num2 = 9;
            Calculator calc = new Calculator("BrandA", "ModelB");
            double sum = calc.Add(num1, num2);
            Console.WriteLine("Sum: " + sum);
            double difference = calc.Subtract(num1, num2);
            Console.WriteLine("Difference: " + difference);

            ScientificCalculator scientificCalc = new ScientificCalculator("BrandC", "ModelD");

            double squareRoot = scientificCalc.Sqrt(num1);
            Console.WriteLine("Square Root: " + squareRoot);

            Console.ReadLine();
        }

        public class Calculator
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public Calculator(string brand, string model)
            {
                Brand = brand;
                Model = model;
            }

            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide(double num1, double num2)
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
            }
        }

        public class ScientificCalculator : Calculator
        {
            public ScientificCalculator(string brand, string model) : base(brand, model)
            {
            }

            public double Power(double num1, double num2)
            {
                return Math.Pow(num1, num2);
            }

            public double Sqrt(double num1)
            {
                return Math.Sqrt(num1);
            }
        }
    }
}
