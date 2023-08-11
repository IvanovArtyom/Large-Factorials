## Description:
In mathematics, the factorial of integer ```n``` is written as ```n!```. It is equal to the product of ```n``` and every integer preceding it.  
For example: ```5! = 1 x 2 x 3 x 4 x 5 = 120```

Your mission is simple: write a function that takes an integer ```n``` and returns the value of ```n!```.

You are guaranteed an integer argument. For any values outside the non-negative range, return ```null```, ```nil``` or ```None``` (return an empty string ```""``` in **C** and **C++**). For non-negative numbers a full length number is expected for example, return ```25! = "15511210043330985984000000"``` as a string.

For more on factorials, see http://en.wikipedia.org/wiki/Factorial

**NOTES:**

- The use of BigInteger or BigNumber functions has been disabled, this requires a complex solution.
- I have removed the use of require in the javascript language.
### My solution
```C#
using System.Collections.Generic;
using System.Linq;

public class Kata
{
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
```
