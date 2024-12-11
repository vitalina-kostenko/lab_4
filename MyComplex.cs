public class MyComplex : IMyNumber<MyComplex>
{
    public double Re { get; }
    public double Im { get; }

    public MyComplex(double re, double im)
    {
        Re = re;
        Im = im;
    }

    public MyComplex Add(MyComplex that)
    {
        return new MyComplex(this.Re + that.Re, this.Im + that.Im);
    }

    public MyComplex Subtract(MyComplex that) =>
        new MyComplex(Re - that.Re, Im - that.Im);

    public MyComplex Multiply(MyComplex that) =>
        new MyComplex(Re * that.Re - Im * that.Im, Re * that.Im + Im * that.Re);

    public MyComplex Divide(MyComplex that)
    {
        double denominator = that.Re * that.Re + that.Im * that.Im;
        if (denominator == 0)
            throw new DivideByZeroException("Cannot divide by zero complex number.");

        return new MyComplex((Re * that.Re + Im * that.Im) / denominator, (Im * that.Re - Re * that.Im) / denominator);
    }

    public override string ToString() => $"{Re}+{Im}i";
}
