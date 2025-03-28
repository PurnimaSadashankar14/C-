/*
Write a program in C# Sharp to display the pattern like right angle triangle with a number.
The pattern like :
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
*/

using System;
class Pattern{
    public static void Main(){
        int n=5;
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write(j+" ");
            }
            Console.WriteLine();
            
        }
    }
}

