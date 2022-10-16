namespace Masterclass.inheritanceLibrary;

public class Salesman: Employee 
{
    // and the SalesMan class can have additional properties or methods that are required only for the salesman; but not for the manager.
    //for example in the Salesman class, we have created a property Region, based on the field called _region.
    //so this Region property is specific to Salesman class. and of course, the Salesman class is the child of Employee class. 
    //so all the members of the Employee class are by default available in the Salesman class.
    
    //field
    private string _region;
    
    //property
    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }
    
    // and also in the Salesman class, let's create a method. 
    
    // method .. suppose in the Salesman class, we have an additional method called GetSalesOfCurrentMonth(). which is available to only salesman; but not to manager. 
    public long GetSalesOfCurrentMonth()
    {
        return 1000;
    }
}