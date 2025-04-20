//create a base class vechile and derive the class car, truck and motorcycle from it. Each derived classes should add specific method relevant to that type of vechile.

using System;
class Vechile{
   
    public void display_info(){
        Console.WriteLine("this is vechile info");
       
    }
    class Car:Vechile{
        public void car_info(){
            Console.WriteLine("this is car info");
        }
    }

    class Truck:Vechile{
        public void truck_info(){
            Console.WriteLine("this is truck info");
        }
    }

    class Motorcycle:Vechile{
        public void motorcycle_info(){
            Console.WriteLine("this is motorcycle info");
        }
    }

class Output{
    public void Main(){
        Car c = new Car();
        c.display_info();
        c.car_info();

        Truck t = new Truck();
        t.display_info();
        t.truck_info();

        Motorcycle m = new Motorcycle();
        m.display_info();
        m.motorcycle_info();
    }
}

}