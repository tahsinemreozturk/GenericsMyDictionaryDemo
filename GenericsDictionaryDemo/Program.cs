using GenericsDictionaryDemo;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {

        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>(); 

        myDictionary.Add(1, "Emre");
        myDictionary.Add(2, "Faruk");
        myDictionary.Add(3, "Cengiz");
        
    }
}