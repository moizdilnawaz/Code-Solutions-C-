// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class SumOfPairSetsAndWholeSet
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        int [] input = new int[4]{1,4,2,5};
        int length = input.Length;
        int [] list = new int[input.Length];
        int sum =0;
        
        for(int i=0;i<length;i++){
            if(i<length-1){
                list[i]= input[i]+input[i+1];
            }
            else{
                int value = 0;
                for(int j=0;j<length;j++){
                    value += input[j];
                }
                list[i]=  value;
            }
            
        }
        for(int i=0;i<length;i++){
            sum+= list[i];
        }
        Console.WriteLine("Sum:"+sum);
    }
}
