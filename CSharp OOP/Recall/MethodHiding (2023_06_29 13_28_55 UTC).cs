using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// method hiding is a way to hide a method in a derived class that has the same name as a method in the base class. 
/// When a method is hidden, the derived class method takes precedence over the base class method, and the base class 
/// method is no longer accessible from the derived class or any other classes that use the derived class.
/// To hide a method in a derived class, you can use the "new" keyword in the method declaration.
/// </summary>


class BaseClass
{
    public void MethodToHide()
    {
        Console.WriteLine("Base class method");
    }
}

class DerivedClass : BaseClass
{
    public new void MethodToHide()
    {
        Console.WriteLine("Derived class method");
        //If you want to access the base class method from the derived class, you can use the "base" keyword.
        //base.MethodToHide();
    }
}

/// <summary>
/// In this example, the DerivedClass hides the MethodToHide method from the BaseClass. If you create an instance of 
/// DerivedClass and call the MethodToHide method, the derived class method will be called instead of the base class 
/// method
/// </summary>
