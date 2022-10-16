namespace Masterclass.inheritanceLibrary;

public class Manager:Employee // the syntax of inheritance is that: ChildClassName: ParentClassName . the colon (:) says that the left-hand side one is the child class; and the right-hand side one is the parent class.  
{
    // so in the child class called Manager, we need not redefine the fields, properties or methods of the Employee class.
    // but we can have additional properties or methods, which are specific for Manager class. suppose, the Manager has an additional property called Department. so creating a private field for that:
    
    // field
    private string _departmentName;
    
    // and also defining corresponding property:
    // property
    public string DepartmentName
    {
        // optionally, in the "set" accessor you can write the necessary conditions that are required to validate the value before assigning it into the field.
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
        // so we have created the necessary field and property in the Manager class.
    }
    
    // and also let's create a method in the Manager class, which is specific to Manager class only. for example; GetTotalSalesOfTheYear().
    // this is defined in the Manager class, which is means that, this is available only for the managers; but not for the salesmen.
    // method
    public long GetTotalSalesOfTheYear()
    {
        // so let's returning some dummy value; for example 10000.
        return 10000;
    }
    
    // base keyword
    // method
    public string GetFullDepartmentName()
    {
        // return DepartmentName + " at " + base.Location; // notice, when you write like base.; you can see all the properties and methods of the parent class. so this output is: "IT at Bolu"
        return DepartmentName + " at " + base._location; //in the child class called Manager, I can access the parent clas's field by the "base" keyboard.
    }
}