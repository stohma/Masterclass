// See https://aka.ms/new-console-template for more information

// goal: this allows classes to be arranged in a hierarchy that represents "is-a-type-of" relationships. so the goal of inheritance is: creating is-a-type-of among two or more classes.

// parent class=> 
// one parent class can have multiple child classes. for example, animal is a parent class. tiger, lion, dog; these are all examples of child classes of animal class. 
// the "parent class" acts as a "base type" of "one or more child classes".
//child classes are derived from parent class. that means, all the members of parent classes are implicitly given to the child class. that means, from the child class you access all the members of parent class;
// parent class's fields
// parent class's methods
// parent class's properties etc
// but the parent class can't access any member of the child class. so being from the parent class, we can't access the child class's field or child class's method or child class's property. in other words, the concept of extending the parent class by creating a child class is called as "inheritance".
// "child class" extends "parent class". the parent class animal has a set of fields and methods that are common to all the animals. the child class tiger has all the members of the parent class by default;
// child class=>
// child class's fields
// child class's methods
// [also can access parent class's fields and methods]
// and also the child class tiger can have additional fields, properties and methods apart from the parent class's members.
// the object of child class by default contains all the fields of parent clas and also all the fields of child class. for example, the parent class contains two fields; and the child class contains two other fields. when you create an object for the parent class, it contains only the parent class's fields; that means two fields only. 
// in the child class's object, the memory will be allocated (tahsis etmek) for the fields or both parent class and child class also.
// in real time projects, in order to segregate (ayrım yapmak) code into multiple classes, you may require the interlinked set of classes.
// for example MobilePhone and Laptop are the child classes of the parent class called ElectronicDevice. Like tis, whenever the child class is a type of the parent class; you can call it as "inheritance".

using Masterclass.inheritanceLibrary;

class Inheritance
{
    static void Main()
    {
        //create object of Employee .. you can create object of both parent class or child class also.
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "ece";
        emp1.Location = "Hatay";

        Console.WriteLine("Object of Parent Class(Employee):");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Location);
        Console.WriteLine("");
        // output: in the object of parent class, only the parent class's fields get stored.
        
        //create object of Manager .. now we are creating an object for the child class i.e. Manager. 
        Manager mgr1 = new Manager();
        mgr1.EmpID = 102;
        mgr1.EmpName = "gamze";
        mgr1.Location = "Bolu";
        mgr1.DepartmentName = "IT";
        
        Console.WriteLine("Object of Child Class(Manager):");
        Console.WriteLine(mgr1.EmpID);
        Console.WriteLine(mgr1.EmpName);
        Console.WriteLine(mgr1.Location);
        Console.WriteLine(mgr1.DepartmentName);
        Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        Console.WriteLine("");
        
        //create object of Salesman .. now we are creating an object for the child class i.e. Salesman. 
        Salesman salesman1 = new Salesman();
        salesman1.EmpID = 103;
        salesman1.EmpName = "hilal";
        salesman1.Location = "Erzurum";
        salesman1.Region = "East";
        
        Console.WriteLine("Object of Child Class(Salesman):");
        Console.WriteLine(salesman1.EmpID);
        Console.WriteLine(salesman1.EmpName);
        Console.WriteLine(salesman1.Location);
        Console.WriteLine(salesman1.Region);
        Console.WriteLine(salesman1.GetSalesOfCurrentMonth());
        Console.WriteLine(mgr1.GetFullDepartmentName()); // IT at Bolu .. but indirectly by calling a method GetFullDepartmentName(), we can access the location details in the output.
        Console.WriteLine("");
        //in the object of child class, both parent class's fields an child class2s fields also will be stored. so overall, inheritance is a concept of extending the parent class by creating the child class; or you can say the child class is a "type" of the parent class. 
        // in real time projects, whenever you find out is-a-type of relationship aong two or more classes, then you have to implement (uygulamak) it with inheritance. 

    }
}
