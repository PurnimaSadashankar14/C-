using System;
using System.Text;
class Program
{
    static void Main(){
        StringBuilder sb= new StringBuilder();
        for (int i=0; i<10; i++){
            sb.Append(i).Append(" ");
        }
        Console.WriteLine(sb);
    }
}