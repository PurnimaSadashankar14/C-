/*
Write a program in C# Sharp to display the pattern like right angle triangle with a number.
The pattern like :
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5
*/
using System;
class Pattern{
    public static void Main(){
        int n=5;
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write(i+" ");
            }
            Console.WriteLine();
            
        }
    }
}
