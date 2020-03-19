using System;

namespace Hacker_Rank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is just a program that holds my solutions for hacker rank problems.");

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(i);
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            
            int result = TwoDArray.hourglassSum(arr);

            Console.WriteLine(result);
        }
    }
}
