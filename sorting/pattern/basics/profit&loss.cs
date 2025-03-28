//WAP to input CP and SP and check profit or loss. Also find the profit or loss amount.
using System;
class Profitloss{
    public static void Main(){
        Console.WriteLine("Enter Cost Price:");
        int cp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter selling Price: ");
        int sp= Convert.ToInt32(Console.ReadLine());
        if(sp>cp){
            Console.WriteLine("Profit is:"+ (sp-cp));
        }
        else if(cp>sp){
            Console.WriteLine("Loss is:"+ (cp-sp));
        }
        else{
            Console.WriteLine("No Profit No Loss");
        }
    }
}