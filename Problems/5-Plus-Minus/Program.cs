
/*
Given an array of integers, calculate the ratios of its elements that are , , and . 
Print the decimal value of each fraction on a new line with 6 places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, 
though answers with absolute error of up to 10^-4  are acceptable.

Example
arr[1,1,0,-1,-1]

There are n=5 elements: two positive, two negative and one zero. 
Their ratios are 2/5=0.400000 , 2/5= 0.400000 , 1/5 = 0.200000 . Results are printed as:

0.400000
0.400000
0.200000

Function Description

Complete the plusMinus function with the following parameter(s):
int arr[n]: an array of integers

Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe .

Constraints:
0 < n <= 100
-100 <= arr[i] <= 100

Sample Input

STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
Sample Output

0.500000
0.333333
0.166667
Explanation

There are 3 positive numbers,2 negative numbers, and 1 zero in the array.
The proportions of occurrence are positive: 3/6 = 0.500000 , negative:2/6 = 0.333333  and zeros 1/6 = 0.166667

-------------------------------------------Türkçe---------------------------------------------------------

Bir dizi tamsayı verildiğinde, dizideki pozitif, negatif ve sıfır olan elemanların oranlarını hesaplayın. 
Her kesir değerini 6 ondalık basamak olacak şekilde yeni bir satıra yazdırın.

Not: Bu problem hassasiyet sorunlarını tanıtır. Test durumları altı ondalık basamağa ölçeklenmiştir, 
ancak mutlak hata belirli bir eşiğe kadar kabul edilebilir.

Örnek
Dizi şu elemanlara sahiptir: iki pozitif, iki negatif ve bir sıfır. Bunların oranları şu şekildedir:
Pozitif: 2/5 = 0.400000
Negatif: 2/5 = 0.400000
Sıfır: 1/5 = 0.200000

Sonuç şu şekilde yazdırılır:
0.400000
0.400000
0.200000

Fonksiyon Açıklaması
plusMinus fonksiyonunu aşağıdaki parametreyle tamamlayın:

arr: Bir tamsayı dizisi.

Çıktı
Pozitif, negatif ve sıfır olan sayıların oranlarını yazdırın. Her değer ayrı bir satıra 6 ondalık basamakla yazdırılmalıdır. Fonksiyon herhangi bir değer döndürmemelidir.

Girdi Formatı
İlk satır, dizinin boyutu olan bir tam sayı n içerir.

İkinci satır, n tane boşlukla ayrılmış tamsayı içerir.

Kısıtlamalar
0 < 𝑛 ≤ 100 

−100≤arr[i]≤100

Örnek Girdi:
6
-4 3 -9 0 4 1

Örnek Çıktı:

0.500000
0.333333
0.166667

Açıklama
Bu dizide:

Pozitif sayılar: 3, 4, 1 → 3 adet

Negatif sayılar: -4, -9 → 2 adet

Sıfır: 0 → 1 adet

Oranlar şu şekilde hesaplanır:

Pozitif: 
3/6 = 0.500000

Negatif: 
2/6 = 0.333333

Sıfır: 
1/6 = 0.166667

Bu oranlar her biri 6 ondalık basamakla yazdırılır.

*/

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

class PlusMinusResult
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
          int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        
         foreach (int num in arr)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
            else
                zeroCount++;
        }
        
          int totalCount = arr.Count;
          
        Console.WriteLine("{0:F6}", (double)positiveCount / totalCount);
        Console.WriteLine("{0:F6}", (double)negativeCount / totalCount);
        Console.WriteLine("{0:F6}", (double)zeroCount / totalCount);
    
    }

}

class PlusMinusSolution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        PlusMinusResult.plusMinus(arr);
    }
}