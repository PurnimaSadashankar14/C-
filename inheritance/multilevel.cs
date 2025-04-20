//create a class employee that inherits from person and adds a method employee_details
// then create another class called manager that inherits from employee and adds a method department.

using System;
class Person{
    public string name;
    public int age;
}
class Employee:Person{
    public string emp_id;
    public void employee_details(){
        Console.WriteLine("Employee ID: " + emp_id);
    }
}
class Manager:Employee{
    public string department;
    public void department_details(){
        Console.WriteLine("Department: " + department);
    }

    class Program{
        static void Main(string[] args){
            Manager m = new Manager();
            m.name = "John Doe";
            m.age = 30;
            m.emp_id = "E123";
            m.department = "HR";

            Console.WriteLine("Name: " + m.name);
            Console.WriteLine("Age: " + m.age);
            m.employee_details();
            m.department_details();
        }
    }
    
}