using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first fraction (numerator and denominator):");
            int nom1 = int.Parse(Console.ReadLine());
            int denom1 = int.Parse(Console.ReadLine());
            var frac1 = new MyFrac(nom1, denom1);

            Console.WriteLine("Enter the second fraction (numerator and denominator):");
            int nom2 = int.Parse(Console.ReadLine());
            int denom2 = int.Parse(Console.ReadLine());
            var frac2 = new MyFrac(nom2, denom2);

            TestOperations_1.TestAPlusBSquare(frac1, frac2);
            TestOperations_2.TestSquaresDifference(frac1, frac2);

            Console.WriteLine("Enter the first complex number (real and imaginary parts):");
            double re1 = double.Parse(Console.ReadLine());
            double im1 = double.Parse(Console.ReadLine());
            var complex1 = new MyComplex(re1, im1);

            Console.WriteLine("Enter the second complex number (real and imaginary parts):");
            double re2 = double.Parse(Console.ReadLine());
            double im2 = double.Parse(Console.ReadLine());
            var complex2 = new MyComplex(re2, im2);

            TestOperations_1.TestAPlusBSquare(complex1, complex2);
            TestOperations_2.TestSquaresDifference(complex1, complex2);

            Console.WriteLine("Sorting fractions:");
            var fractions = new[] { frac1, frac2, new MyFrac(2, 3), new MyFrac(1, 2) };
            Array.Sort(fractions);
            foreach (var frac in fractions)
            {
                Console.WriteLine(frac);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        Console.ReadKey();
    }
}