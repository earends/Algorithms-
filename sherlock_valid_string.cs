/*
CREDIT HACKER RANK:https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings

Sherlock considers a string to be valid if all characters of the string appear the same number of times. It is also valid if he can remove just  character at  index in the string, and the remaining characters will occur the same number of times. Given a string , determine if it is valid. If so, return YES, otherwise return NO.

Example

This is a valid string because frequencies are .


This is a valid string because we can remove one  and have  of each character in the remaining string.


This string is not valid as we can only remove  occurrence of . That leaves character frequencies of .

Function Description

Complete the isValid function in the editor below.

isValid has the following parameter(s):

string s: a string
Returns

string: either YES or NO
Input Format

A single string .

Constraints

Each character 
Sample Input 0

aabbcd
Sample Output 0

NO
Explanation 0

Given , we would need to remove two characters, both c and d  aabb or a and b  abcd, to make it valid. We are limited to removing only one character, so  is invalid.

Sample Input 1

aabbccddeefghi
Sample Output 1

NO
Explanation 1

Frequency counts for the letters are as follows:

{'a': 2, 'b': 2, 'c': 2, 'd': 2, 'e': 2, 'f': 1, 'g': 1, 'h': 1, 'i': 1}

There are two ways to make the valid string:

Remove  characters with a frequency of : .
Remove  characters of frequency : .
Neither of these is an option.

Sample Input 2

abcdefghhgfedecba
Sample Output 2

YES
Explanation 2

All characters occur twice except for  which occurs  times. We can delete one instance of  to have a valid string.

Language
C#

More
67686970717273747576777879808182838485868788899091
        
        
        IEnumerable<int> FrequencyKeysThatAreNotCommon = frequencyDict.Keys.Where(x => x!= mostCommonFrequency);
        
        
        if (FrequencyKeysThatAreNotCommon.Count() > 1) {
            return "NO";
        }
        else if (FrequencyKeysThatAreNotCommon.Any(x => frequencyDict[x] > 1)) {

Line: 73 Col: 9

Submit Code

Run Code

Upload Code as File

Test against custom input
Problem Solving
You have earned 35.00 points!
These points will also count towards your progress in the Problem Solving Badge.
53%345/475
Congratulations
You solved this challenge. Would you like to challenge your friends?Share on FacebookShare on TwitterShare on LinkedIn
Next Challenge

Test case 0

Test case 1

Test case 2

Test case 3

Test case 4

Test case 5

Test case 6

Test case 7

Test case 8

Test case 9

Test case 10

Test case 11

Test case 12

Test case 13

Test case 14

Test case 15

Test case 16

Test case 17

Test case 18

Test case 19
Compiler Message
Success
Input (stdin)

Download
aabbcd
Expected Output

Download
NO
BlogScoringEnvironmentFAQAbout UsSupportCareersTerms Of ServicePrivacy Policy

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

    /*
     * Complete the 'isValid' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isValid(string s)
    {
        Dictionary<char, int> characterFrequencyDict = new Dictionary<char, int>();
        foreach(char c in s) {
            if (characterFrequencyDict.ContainsKey(c)) {
                characterFrequencyDict[c] += 1;
            }
            else {
                characterFrequencyDict[c] = 1;
            }
        }
        
        // happy path loop through each value in if they all match done
        bool passedHappyPath = true;
        int previous = -1;
        foreach(int value in characterFrequencyDict.Values) {
            if (previous == -1) {
                previous = value;
            }
            
            if (value != previous) {
                passedHappyPath = false;
            }
            
            previous = value;
        }
        
        if (passedHappyPath) {
            return "YES";
        }
        
        // collect frequency dictionary of the frequencies at which the numners show up
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
        foreach(int frequency in characterFrequencyDict.Values) {
            
            if (frequencyDict.ContainsKey(frequency)) {
                frequencyDict[frequency] += 1;
            }
            else {
                frequencyDict[frequency] = 1;
            }
        }
        
        
        int mostCommonFrequency = frequencyDict.Keys.OrderByDescending(x => frequencyDict[x]).First();
        
        
        IEnumerable<int> FrequencyKeysThatAreNotCommon = frequencyDict.Keys.Where(x => x!= mostCommonFrequency);
        
        
        if (FrequencyKeysThatAreNotCommon.Count() > 1) {
            return "NO";
        }
        else if (FrequencyKeysThatAreNotCommon.Any(x => frequencyDict[x] > 1)) {
            return "NO";
        }
        else if (FrequencyKeysThatAreNotCommon.ElementAt(0) - 1 == 0 || FrequencyKeysThatAreNotCommon.ElementAt(0) - 1 == mostCommonFrequency) {
            return "YES";
        }
        else {
            return "NO";
        }
        
        
        //aabbc
        //2,2,1 - OK 
        //2:2, 1:1
        
        //2,1,1 - 
        // 2:1, 1:2 '
        
        //3,3,1,1 
        //3:2, 1:2 
        
        // 3,3,2
        //3: 2, 2:1
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
