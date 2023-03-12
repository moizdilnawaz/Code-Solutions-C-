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

class CloudsJump
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int jumps=0;
        bool isJumpable;
        for(int i= 0;i<c.Count;)
        {
            if(c[i]==0){
                if(true){
                    if(i+2 < c.Count && c[i+2]==0){
                        Console.WriteLine("A Before :"+ i);
                        jumps++;
                        i=i+2;
                        Console.WriteLine("A"+ i);
                    }
                    else if(i+1 < c.Count && c[i+1]==0){
                        Console.WriteLine("B Before :"+ i);
                        jumps++;
                        i=i+1;
                        Console.WriteLine("B"+i);
                    }
                    else{
                        i++;
                    }
                }else {
                    i++;
                }
            }else{
                i++;
            }
            
        }
        return jumps;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
