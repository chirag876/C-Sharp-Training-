using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{

    //public class DataAccess
    //{
    //    public DataAccess() {

    //    }

    //    public string GetPersonNameDataAcess()
    //    {
    //        return "Person Name";
    //    }

    //}
    //public class Person //depends on Data Access class high levvel module
    //{
    //    public Person()
    //    {

    //    }


    //    public void GetPersonName()
    //    {
    //        DataAccess dataAccess = new DataAccess();
    //        dataAccess.GetPersonNameDataAcess();
    //    }
    //}

    //the above is violating the dip principle because of tight coupling


    

    public interface IPersonDataAccess
    {
        string GetPersonNameDataAcess();
    }
    public class DataAcessFactory //it will generate object
    {
        public static IPersonDataAccess GetPersonName()
        {
            return new DataAccess();
        }
    }
    public class DataAccess : IPersonDataAccess
    {
        public DataAccess()
        {

        }

        public string GetPersonNameDataAcess()
        {
            return "Person Name";
        }

    }

    public class Person //do not depends on Data Access class high levvel module
    {
        public Person()
        {

        }
        public static void GetPersonName()
        {
            IPersonDataAccess dataAccess = DataAcessFactory.GetPersonName();
            dataAccess.GetPersonNameDataAcess();
        }
    }
}

