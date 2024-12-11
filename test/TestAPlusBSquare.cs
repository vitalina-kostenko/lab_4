using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TestOperations_1
{
    public static void TestAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine($"=== Testing (a+b)^2 = a^2 + 2ab + b^2 with a = {a}, b = {b} ===");
        try
        {
            T aPlusB = a.Add(b);
            Console.WriteLine($"(a + b) = {aPlusB}");
            Console.WriteLine($"(a+b)^2 = {aPlusB.Multiply(aPlusB)}");

            T aSquared = a.Multiply(a);
            T bSquared = b.Multiply(b);
            T twoAB = a.Multiply(b).Add(a.Multiply(b));

            Console.WriteLine($"a^2 = {aSquared}");
            Console.WriteLine($"b^2 = {bSquared}");
            Console.WriteLine($"2*a*b = {twoAB}");

            T rightHandSide = aSquared.Add(twoAB).Add(bSquared);
            Console.WriteLine($"a^2 + 2ab + b^2 = {rightHandSide}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during calculation: {ex.Message}");
        }
    }
}
