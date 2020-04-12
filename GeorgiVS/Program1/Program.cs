using System.Net;
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



class Program
{
    static int minimumAbsoluteDifference(int[] arr) 
    {
        //List<int> numbers = arr.ToList();
       // numbers.Sort();
        int smallestDistance = arr.Max();


        for (int i = 0; i < arr.Length; i++)
        {
            for (int n = 0; n < arr.Length; n++)
            {
                if ((Math.Abs(arr[n] - arr[i])) < smallestDistance && arr[n] != arr[i])
                {
                    smallestDistance = Math.Abs(arr[n] - arr[i]);
                }
            }
        }

        return smallestDistance;
    }
    static void Main(string[] args)
    {
    }
        
}


