namespace Masterclass.InheritanceTypes;
//1.single inheritance: whenever there is one parent class with one child class, you can call it as "single inheritance". for example, Person is a parent class; Teacher is a child class of Person class.

//2.multi-level inheritance: whenever there is one parent clas with one child class; and there is child class 2 based on the child class 1. so this is called as "multi-level inheritance". because the child class 1 acts as a parent of child class 2; and a child class 1 act as child of parent class 1. for example;
/* public class Person{}
class Teacher : Person{}
class Professor : Teacher{} */

//3.hierarchical inheritance; whenever one parent clas has multiple child clases, you can call it as "hierarchical inheritance".
//one parent class, multiple child classes.
//for example; below example, every teacher is a Person and every Physician is a Person.
/*
class Person {}
class Teacher:Person{}
class Physician:Person{} */

//4.multiple inheritance; whenever one child class has multiple parent classes, we can call it as multiple inheritance.
//multiple parent class, one child class
//**and as per the rules of C#, a class can't have multiple parent classes at-a-time. 
/*
class ParentClass1{}
class ParentClass2{}
class ChildClass:ParentClass1,ParentClass2{}  */

//but you can implement (uygulamak) multiple inheritance in C# indirectly by using interfaces. in this case, it is possible to implement inheritance in C#. in C #, we can't implement multiple inheritance by using multiple parent classes. but we can implement multiple inheritance by using "multiple parent interfaces". 
/*
interface ParentClass1{}
interface ParentClass2{}
class ChildClass:ParentClass1,ParentClass2{} */

//5.hybrid inheritance; whenever you have combination of two or more types of inheritances; that means, a complex parent-child relationship among classes, that is called as "hybrid inheritance". 
//hierarchical inheritance + multilevel inheritance
//for example, as of the parent class, child class1 and child class2; we have "multilevel inheritance". and as of the child class1, child class2, child class3; we have hierarchical inheritance.
//so we have a combination of hierarchical inheritance and multilevel inheritance at the same time in the same application. so this is called "hybrid inheritance". 
/*
class Person{}
class Tailor:Person{}
class Professor:Person{}
class MedicalProfessor:Professor{} */