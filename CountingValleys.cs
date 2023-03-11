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

    public static int countingValleys(int steps, string path)
    {
        int level = 0;
        int valleyCount = 0;
        bool isStepDown =false;
        for(int i =0; i< path.Length;i++){
            if(path[i] =='U'){
                level++;
                if(level ==0 && isStepDown){
                    valleyCount++;
                    isStepDown =false;
                }
            }
            else{
                
                level--;
                isStepDown =true;
            }
        }
        return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
