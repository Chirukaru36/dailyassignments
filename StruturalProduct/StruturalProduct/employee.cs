using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruturalProduct
{
    public class employee
    {
        private int v1;
        private string name;
        private string desig;
        private int v2;

        public employee(int v1, string name, string desig, int v2)
        {
            this.v1 = v1;
            this.name = name;
            this.desig = desig;
            this.v2 = v2;
        }

        public int empId { get; set; }
        public string empname { get; set; }

        public int Salary { get; set; }

        public string Job { get; set; }
        public void Employeee(int id, string name, int salary, string job)
        {
            empId = id;
            empname = name;
            Salary = salary;
            Job = job;
        }

        public class salaryCalculations
        {
            public void Processsalary(List<employee> employees)
            {

            }
        }
    }
}

   

  

