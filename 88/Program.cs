using System;

class Program
{
    static void Main()
    {
        int number1 = 5;
        int number2 = 7;
        int sum = AddNumbers(number1, number2);
        Console.WriteLine($"Сумма чисел {number1} и {number2} равна {sum}");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
