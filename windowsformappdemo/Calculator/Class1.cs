using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class EMS

    {
        List<Emp> Emplist = new List<Emp>();
        public EMS()
        {
            Emplist.Add(new Emp { Userid = "Shamika", Password = "Shamika@123" });
            Emplist.Add(new Emp { Userid = "Sumita", Password = "Sumita@123" });
            Emplist.Add(new Emp { Userid = "Sharvika", Password = "Sharvika@123" });


        }

        public bool ValidateUser(string username, string password)
        {
            Emp efound = Emplist.Find(edata => edata.Userid == username && edata.Password == password);
            bool flag = false;
            if (efound != null)
            {
                flag = true;
            }
            return flag;



        }
    }




    public class Emp
    {
        public string Userid { get; set; }
        public string Password { get; set; }


    }
}

