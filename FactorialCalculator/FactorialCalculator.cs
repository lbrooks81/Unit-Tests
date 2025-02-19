namespace FactorialCalculator;

public class FactorialCalculator
{
    public static void Main() 
    {
        Console.WriteLine(CalculateFactorial(7));
    }
    public static int CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), number, "Cannot calculate the factorial values of negative numbers.");
        }
        return Factorial(number, number);
    }
    private static int Factorial(int number, int total)
    {
        if (total == 0)
        {
            return 1;
        }
        
        // Base Case
        if (number == 1)
        {
            return total;
        }

        checked
        {
            number--;
            total *= number;
        }

        return Factorial(number, total);
    }
}
