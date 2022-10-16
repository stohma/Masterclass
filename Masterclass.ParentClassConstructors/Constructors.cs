namespace Masterclass.ParentClassConstructors;

// generally, the parent class's constructor initializes the fields of the parent class only. in the same way, the child class's constructor initializes the fields of the child class only. 
// but whenever you create an object for the child class, the child class's object stores the fields of the parent class and child class also.
// so there is a need of calling the parent class's constructor to initialize the parent class's fields.
// but by default, when you write the statement new ChildClassName() to create object of the child class; by default it will directly call the child class's constructor only. 
// when you create an object for the child class by writing new ChildClassName(); it will receive all the parameters in to the child class's constructor. 
// and then you will call the parent class's constructor by writing colon (:) and parent class name. 
// and also you may pass essential argument values, which are required for the parent class's constructor.
// so based on this statement, the execution the sequence jumps to the parent class's constructor. 
// and the parent class's constructor receives essential parameters; and initializes those parameter values into the parent class's fields.

public class Class1
{
}