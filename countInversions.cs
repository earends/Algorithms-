/*
In an array, , the elements at indices  and  (where ) form an inversion if . In other words, inverted elements  and  are considered to be "out of order". To correct an inversion, we can swap adjacent elements.

Example


To sort the array, we must perform the following two swaps to correct the inversions:

The sort has two inversions:  and .
Given an array , return the number of inversions to sort the array.

Function Description

Complete the function countInversions in the editor below.

countInversions has the following parameter(s):

int arr[n]: an array of integers to sort
Returns

int: the number of inversions
Input Format

The first line contains an integer, , the number of datasets.

Each of the next  pairs of lines is as follows:

The first line contains an integer, , the number of elements in .
The second line contains  space-separated integers, .
Constraints

Sample Input

STDIN       Function
-----       --------
2           d = 2
5           arr[] size n = 5 for the first dataset
1 1 1 2 2   arr = [1, 1, 1, 2, 2]
5           arr[] size n = 5 for the second dataset     
2 1 3 1 2   arr = [2, 1, 3, 1, 2]
Sample Output

0  
4   
Explanation

We sort the following  datasets:

 is already sorted, so there are no inversions for us to correct.
We performed a total of  swaps to correct inversions.
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

class Result
{

    static long inversionCount = 0;
    /*
     * Complete the 'countInversions' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static long countInversions(List<int> arr)
    {
        inversionCount = 0;
        MergeSort(arr);
        Console.WriteLine(inversionCount);
        return inversionCount;
    }
    
    public static void MergeSort(List<int> arr) 
    {
            // stop condition 
            if (arr.Count <= 1) {
                return;
            }
            
            // split the array in half
            int middle = arr.Count / 2;
            List<int> tempArr1 = arr.GetRange(0, middle);
            List<int> tempArr2 = arr.GetRange(middle, arr.Count - middle);
            // continue to do this with the arrays till they are 1 count
            MergeSort(tempArr1);
            MergeSort(tempArr2);
            // now merge the two arrays and overwrite the placement or the original array
            Merge(arr, tempArr1, tempArr2);
            
    }
    
    public static void Merge(List<int> arr, List<int> tempArr1, List<int> tempArr2) {
        int arrCount = 0;
        int tempArr1Count = 0;
        int tempArr2Count = 0;
        
        while (tempArr1Count < tempArr1.Count && tempArr2Count < tempArr2.Count) {
            if (tempArr1[tempArr1Count] <= tempArr2[tempArr2Count] ) {
                arr[arrCount] = tempArr1[tempArr1Count];
                tempArr1Count += 1;
            }
            else {
                // 1,2 
                // 1,2,3
                // 1 goes first so the list is {1} and {1,2,3}
                inversionCount += (tempArr1.Count - tempArr1Count);
                arr[arrCount] = tempArr2[tempArr2Count];
                tempArr2Count += 1;
            }
            arrCount += 1;
        }
        
        // backfill arr1
        while (tempArr1Count < tempArr1.Count) {
            arr[arrCount] = tempArr1[tempArr1Count];
            tempArr1Count +=1;
            arrCount += 1;
        }
        
        // backfill arr2
        while (tempArr2Count < tempArr2.Count) {
            arr[arrCount] = tempArr2[tempArr2Count];
            tempArr2Count +=1;
            arrCount += 1;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            long result = Result.countInversions(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

