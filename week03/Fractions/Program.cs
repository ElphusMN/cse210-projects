class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();

        fraction.SetTop(3);
        fraction.SetBottom(4);

        Console.WriteLine(fraction.GetFraction());
    }
}