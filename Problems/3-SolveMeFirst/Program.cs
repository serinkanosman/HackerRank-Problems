using System;
using System.Collections.Generic;
using System.IO;


/*

Complete the function  to compute the sum of two integers.

Example


Return .

Function Description

Complete the  function with the following parameters:

: the first value
: the second value
Returns
- : the sum of  and 

Constraints


Sample Input

a = 2
b = 3
Sample Output

5
Explanation
2+3 = 5

*/
namespace SolveMeFirst{
public class Program{
      
            // Toplama işlemi yapan fonksiyon
        public static int solveMeFirst(int a, int b) 
        { 
                return a + b; // İki sayıyı toplar
        }
        

        static void Main(String[] args) 
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
    }
}
