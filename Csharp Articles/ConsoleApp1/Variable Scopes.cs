using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Variable_Scopes
    {
    private string _firstName = "Bruce";
    private string _lastName = "Lee";
    public void variable1() //Class Level Scope
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }

    public string FullName
    {
        get
        {
            return _firstName + " " + _lastName;
        }
    }
}
