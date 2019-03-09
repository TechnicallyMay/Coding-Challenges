using System;

class MainClass
{
    public static int PentagonalNumber(int num)
    {
        int output = 1;
        for (int i = 1; i <= num; i++)
        {
            output += 5 * (i-1);
        }
        return output;
    }

    static void Main()
    {
        for (int i = 1; i < 20; i++)
        {
            Console.WriteLine(PentagonalNumber(i));
        }
        Console.ReadLine();
    }
}
