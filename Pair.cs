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

public class Pair{
	public static int sockMerchant(int n, List<int> ar)
	{
        List<int> tempArray = new List<int>();
        int countOfPairs = 0;
        
        for(int i=0;i<n; i++){
            if(tempArray.Contains(ar[i]))
            {
                tempArray.Remove(ar[i]);
                countOfPairs++;
            }
            else{
                tempArray.Add(ar[i]);
            }
        }
        return countOfPairs;
	}

}
