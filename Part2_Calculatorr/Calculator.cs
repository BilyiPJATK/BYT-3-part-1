namespace Part2_Calculatorr;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : A / B,
            _ => throw new InvalidOperationException($"Invalid operation '{Operation}'. Only +, -, *, / are allowed.")
        };
    }
}