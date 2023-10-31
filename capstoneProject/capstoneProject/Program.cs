using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    internal class Program
    {

        static void Main()
        {
            user jobSeeker = new user("JohnDoe", UserType.JobSeeker);

            
            user employer = new user("ABCCompany", UserType.Employer);

            
            if (jobSeeker.UserType == UserType.JobSeeker)
            {
                Console.WriteLine($"{jobSeeker.UserName} is a job seeker.");
            }

            if (employer.UserType == UserType.Employer)
            {
                Console.WriteLine($"{employer.UserName} is an employer.");
            }

            JobSeekerRegistration jobSeekerRegistration = new JobSeekerRegistration();
            EmployerRegistration employerRegistration = new EmployerRegistration();

            
        }
    }
}
  
 

