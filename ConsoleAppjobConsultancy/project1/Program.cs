using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using ConsultancyBusinessLogicLayer;

namespace Project1


{
    internal class Program
    {
        static void Main(string[] args)
        {
         Register registration = new R();
            registration.JobSeekerRegister();
        }
    }
}
