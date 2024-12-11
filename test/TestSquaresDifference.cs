using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TestOperations_2
{
    public static void TestSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine($"=== Testing (a-b)*(a+b)=a^2-b^2 with a = {a}, b = {b} ===");
        try
        {
            T aMinusB = a.Subtract(b);
            T aPlusB = a.Add(b);
            T leftHandSide = aMinusB.Multiply(aPlusB);

            T aSquared = a.Multiply(a);
            T bSquared = b.Multiply(b);
            T rightHandSide = aSquared.Subtract(bSquared);

            Console.WriteLine($"(a - b) = {aMinusB}");
            Console.WriteLine($"(a + b) = {aPlusB}");
            Console.WriteLine($"(a-b)*(a+b) = {leftHandSide}");
            Console.WriteLine($"a^2 - b^2 = {rightHandSide}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during calculation: {ex.Message}");
        }
    }
}

