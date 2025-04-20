//create two different classes named Rose and lilly and add specific method relevant to that type of class. then create another class named flower that inherits from both rose and lily.Show how to achieve it.

using System;
 
 interface Rose{
    void smell()
 }

 interface Lilly{
    void smell()
 }

 class Flower:Rose,Lilly{
    void Rose.smell()
    {
       Console.WriteLine("This is rose");
    }
    void Lilly.smell()
    {
        Console.WriteLine("This is Lilly");
    }

public void smell(){
    Console.WriteLine("This is flower");
    }
}
 class Program{
    static void Main(string[] args){
        Flower f = new Flower();
        f.smell();
        Rose r = f;
        r.smell();
        Lilly l = f;
        l.smell();
    }
 }