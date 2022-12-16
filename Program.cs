using System;

class baek1712
{
    static void Main()
    {
        long[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long resultNum = 0;
        for (long i = 1; i <= 2100000001; i++)
        {
            if (i * inputArr[2] > inputArr[0] + inputArr[1] * i)
            {
                resultNum = i;
                break;
            }
            else
            {
                resultNum = -1;
            }
        }
        Console.WriteLine(resultNum);
    }
}