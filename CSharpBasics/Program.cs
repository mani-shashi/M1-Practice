//  Reverse a string without using built-in functions.
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static string ReverseString(string str){
        string res ="";
        for(int i=str.Length-1;i>=0;i--){
            res+=str[i];
        }
        return res;
    }
    public static void Main(string[] args)
    {
        string? str = Console.ReadLine();
        Console.WriteLine(ReverseString(str));
    }
}

// Remove duplicates from a list using a HashSet.
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(12);
        list.Add(45);
        list.Add(12);
        list.Add(45);
        list.Add(67);
        HashSet<int> set = new HashSet<int>(list);
        
        foreach(var i in set){
            Console.Write(i+" ");
        }
    }
}

// Find the largest element in an integer array
public class HelloWorld
{
    public static int LargestElemet(int [] arr){
        int max = int.MinValue;
        for(int i=0;i<arr.Length;i++){
            if(arr[i] > max){
                max = arr[i];
            }
        }
        return max;
    }
    public static void Main(string[] args)
    {
        int [] arr = new int[]{12,34,23,45,23,568,674,32};
        Console.WriteLine(LargestElemet(arr));
    }
}

// Find the sum of all elements in an array.
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] arr = new int[]{12,34,23,56,34};
        int sum = 0;
        
        foreach(var i in arr){
            sum+=i;
        }
        Console.WriteLine(sum);
    }
}

// Toggle case using only char APIs
public class HelloWorld
{
    public static string ToggleCase(string str){
        string res = "";
        foreach(var i in str){
            if(char.IsUpper(i)){
                res += char.ToLower(i);
            }else if(char.IsLower(i)){
                res += char.ToUpper(i);
            }
        }
        return res;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the String : ");
        string str = Console.ReadLine();
        
        Console.WriteLine(ToggleCase(str));
    }
}