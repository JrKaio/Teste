using System;

public class FibonacciChecker {
    public static string CheckFibonacci(int num) {
        int a = 0, b = 1, c = 0;

        while (c < num) {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num) {
            return $"O número {num} pertence à sequência de Fibonacci.";
        } else {
            return $"O número {num} não pertence à sequência de Fibonacci.";
        }
    }

    static void Main(string[] args)
    {
        int num = 13;
        string result = CheckFibonacci(num);
        Console.WriteLine(result);
    }
}