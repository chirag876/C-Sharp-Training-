using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PredicateDelegate
    {
    public static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());    
    }

}
