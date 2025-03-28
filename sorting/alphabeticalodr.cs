//Write a C# program to sort name of 10 person in alphabetical order.
using System;
class Alpabetical{
    public static void Main(){
        string[] names= new string[10];
        Console.WriteLine("enter the names of 10 persons:");
        for(int i=0;i<10;i++){
            names[i]=Console.ReadLine();
        }
        Array.Sort(names);
        Console.WriteLine("The names in alphabetical order are:");
        for(int i=0;i<10;i++){
            Console.WriteLine(names[i]);
         } }
}