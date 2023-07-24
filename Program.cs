using System;
using System.Collections.Generic;

public class Program
{
    public static IEnumerable<int> ProceduralApproach(int[] inputArray)
    {
        List<int> result = new List<int>();

        foreach (int num in inputArray)
        {
            if (num % 2 == 0)
            {
                result.Add(num * 2);
            }
        }

        result.Sort();
        return result;
    }

    public static IEnumerable<int> KeywordQueryExpressionApproach(int[] inputArray)
    {
        var result = from num in inputArray
                     where num % 2 == 0
                     orderby num
                     select num * 2;

        return result;
    }

    public static IEnumerable<int> MethodCallQueryExpressionApproach(int[] inputArray)
    {
        var result = inputArray
                     .Where(num => num % 2 == 0)
                     .OrderBy(num => num)
                     .Select(num => num * 2);

        return result;
    }

    public static void Main()
    {
        int[] inputArray = { 1, 9, 2, 8, 3, 7, 4, 6, 5 };

        Console.WriteLine("Procedural Approach:");
        DisplayResult(ProceduralApproach(inputArray));

        Console.WriteLine("\nKeyword Query Expression Approach:");
        DisplayResult(KeywordQueryExpressionApproach(inputArray));

        Console.WriteLine("\nMethod-call Query Expression Approach:");
        DisplayResult(MethodCallQueryExpressionApproach(inputArray));
    }

    public static void DisplayResult(IEnumerable<int> result)
    {
        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
