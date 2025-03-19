using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

#region Problem
    /// Given an array of integers, find the sum of its elements.
/*
For example, if the array , , so return .

Function Description

Complete the  function with the following parameter(s):

: an array of integers
Returns

: the sum of the array elements
Input Format

The first line contains an integer, , denoting the size of the array.
The second line contains  space-separated integers representing the array's elements.

Constraints

0<n, ar[i]<=1000

Sample Input

STDIN           Function
-----           --------
6               ar[] size n = 6
1 2 3 4 10 11   ar = [1, 2, 3, 4, 10, 11]
Sample Output

31

Print the sum of the array's elements: .*/
#endregion
class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
                return ar.Sum();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


/*
Run Code
--------
Input (stdin)
6
1 2 3 4 10 11
--------
Your Output (stdout)
31
Expected Output
31
--------
*/