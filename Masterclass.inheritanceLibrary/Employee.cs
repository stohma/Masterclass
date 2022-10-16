namespace Masterclass.inheritanceLibrary;

public class Employee
{
     
    // fields
    private int _empId;
    private string _empName;
    // private string _location; when we use base. this line is change like below;
    protected string _location; // since Location field is a protected field; the protected field of a parent class can only be accessible in the corresponding child classes; but not in other classes. so that is the reason, this "protected" member is directly not accessible in the InheritanceExmpl.cs file in the console application.
    
    // properties
    public int EmpID
    {
        set
        {
            _empId = value;
        }
        get
        {
            return _empId;
        }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location; // after creating all the properties, now the Employee class is ready.
            // remember, all the fields, properties or methods that are defined in the parent class called Employee are going to be accessible in both child classes. so you need not recreate any fields or properties related to ID, name or location in the child classes.
        }
    }
}