using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Encapsulation is way of making all data private and access them using getters and setters. These getters and setters can be our own defined 
 functions or properties with get and set.*/

//Example of encapsulation with our own methods for getter and setter.
class Buisness
{
    private string Type = "Food"; // Declared private variable Type
    public string GetType() //Public method GetType
    {
        return this.Type;
    }
    public void SetType(string T) //Public method SetType
    {
        this.Type = T;
    }
    /*GetType() and SetType() return and set the value of variable Type*/
}

//Example of encapsulation using default properties.
class Business2
{
    public string Name { get; set; }

}
