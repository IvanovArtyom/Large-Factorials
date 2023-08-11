using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static void Main()
    {
        // Test
        var t = Factorial(5);
        // ...should return "120"
    }

    public static string? Factorial(int n)
    {
        if (n < 0)
            return null;

        List<int> factorial = new() { 1 };

        for (int i = 1; i <= n; i++)
            MultiplyLargeNumber(factorial, i);

        return string.Concat(factorial.Select(x => x).Reverse());
    }

    public static void MultiplyLargeNumber(List<int> largeNumber, int number)
    {
        int remainder = 0;

        for (int i = 0; i < largeNumber.Count; i++)
        {
            remainder += largeNumber[i] * number;
            largeNumber[i] = remainder % 10;
            remainder /= 10;
        }

        while (remainder != 0)
        {
            largeNumber.Add(remainder % 10);
            remainder /= 10;
        }
    }
}