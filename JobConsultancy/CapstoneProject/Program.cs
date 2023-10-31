using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultancyBusinessLogicLayer;

namespace CapstoneProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
         User jobSeeker = new User("JohnDoe", UserType.JobSeeker, "jobseekerpassword");
            Console.WriteLine($"Username: {jobSeeker.Username}, UserType: {jobSeeker.UserType}, Password: {jobSeeker.Password}");

            // Create an Employer user with a password
            User employer = new User("ACMECorp", UserType.Employer, "employerpassword");
            Console.WriteLine($"Username: {employer.Username}, UserType: {employer.UserType}, Password: {employer.Password}");
        }
    }

    internal class User
    {
    }
}
