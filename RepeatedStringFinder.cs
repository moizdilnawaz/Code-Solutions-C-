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

class RepeatedStringFinder
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        long frequency = 0;
        string addedString = "";

        if (s.Length < n)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    frequency++;
                }
            }
            long frequencyInOneItem = frequency;
            long maxCount = s.Length;
            long leftCount = n - s.Length;

            long NumberOfStringRepetation = leftCount / maxCount;

            frequency += frequencyInOneItem * NumberOfStringRepetation;
            int extraLenght = (int)(n - ((NumberOfStringRepetation * maxCount) + s.Length));


            for (int i = 0; i < extraLenght; i++)
            {
                if (s[i] == 'a')
                {

                    frequency++;

                }
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'a')
                {
                    frequency++;
                }
            }
        }
        /*int currentIndex =0;
        for(int i =0;i<n;i++){
            if(currentIndex >= s.Length)
            {
                currentIndex= 0;
            }
            addedString+= s[currentIndex];
            
            
            if(s[currentIndex] == 'a'){
                frequency++;
            }
            
            currentIndex++;
        }*/
        return frequency;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
