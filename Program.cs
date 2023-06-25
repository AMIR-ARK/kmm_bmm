using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int kmm = CalculateKMM(num1, num2);
        int bmm = CalculateBMM(num1, num2);

        Console.WriteLine("The KMM of {0} and {1} is: {2}", num1, num2, kmm);
        Console.WriteLine("The BMM of {0} and {1} is: {2}", num1, num2, bmm);

        Console.ReadKey();
    }

    static int CalculateKMM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);

        int kmm = max;
        while (kmm % min != 0)
        {
            kmm += max;
        }

        return kmm;
    }

    static int CalculateBMM(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);

        int bmm = min;
        while (max % bmm != 0)
        {
            bmm--;
        }

        return bmm;
    }
}
