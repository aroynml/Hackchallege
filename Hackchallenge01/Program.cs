using System.Collections.Generic;
using Hackchallenge01.Methods;

namespace ConsoleAppTest_Hacker_FindtheSingleton;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RunStart");
        var input1 = new int[] { 1, 23, 5, 8, 1, 3, 2, 1, 23, 5, 8, 1, 3, 2, 5, 1, 23, 5, 8, 1, 3, 2, 1, 23, 5, 8, 1, 3, 2, 5, 1, 23, 5, 8, 1, 3, 2, 1, 23, 5, 8, 1, 3, 2, 5, 8, 4, 2, 1, 23, 5, 8, 1, 3, 2, 1, 23, 5, 8, 1, 3, 2, 5, };
        DateTime currdtime = DateTime.Now;
        Console.WriteLine(FindSingleton.FindMethod(input1));
        Console.WriteLine("----");
        var input2 = new int[] { 1, 0, 2, 6, 3, 4, 5, 11, 12, 13 };
        Console.WriteLine(LongestIncreasingSubseq.GetMaxLengthOfSubseq(input2));
        Console.WriteLine("----");
        var input3 = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaxSubarray.ComputeMaximumSum(input3));
        var input4 = "23-10";
        Console.WriteLine(GetDayofweek.CheckValidDayofweek(input4, 2016));
    }

       

}