//WAP to generate multiplication table from 1 to 10
using System;
class Multiplication{
    public static void Main(){
        for(int i=1;i<=10;i++){
            for(int j=1;j<=10;j++){
                Console.Write(i*j+" ");
            }
            Console.WriteLine();
        }
    }
}