using System.Numerics;

public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
{
    public BigInteger Nom { get; }
    public BigInteger Denom { get; }

    public MyFrac(BigInteger nom, BigInteger denom)
    {
        if (denom == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");

        var gcd = BigInteger.GreatestCommonDivisor(nom, denom);
        Nom = nom / gcd;
        Denom = denom / gcd;

        if (Denom < 0)
        {
            Nom = -Nom;
            Denom = -Denom;
        }
    }

    public MyFrac(int nom, int denom) : this(new BigInteger(nom), new BigInteger(denom)) { }

    public MyFrac Add(MyFrac b) =>
        new MyFrac(Nom * b.Denom + Denom * b.Nom, Denom * b.Denom);

    public MyFrac Subtract(MyFrac b) =>
        new MyFrac(Nom * b.Denom - Denom * b.Nom, Denom * b.Denom);

    public MyFrac Multiply(MyFrac b) =>
        new MyFrac(Nom * b.Nom, Denom * b.Denom);

    public MyFrac Divide(MyFrac b)
    {
        if (b.Nom == 0)
            throw new DivideByZeroException("Cannot divide by zero fraction.");

        return new MyFrac(Nom * b.Denom, Denom * b.Nom);
    }

    public int CompareTo(MyFrac other)
    {
        BigInteger diff = Nom * other.Denom - Denom * other.Nom;
        return diff < 0 ? -1 : (diff > 0 ? 1 : 0);
    }

    public override string ToString() => $"{Nom}/{Denom}";
}
