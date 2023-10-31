using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    public class EmployerRegistration
    {
        private List<user> employerUsers = new List<user>();

        public user RegisterEmployer(string userName, string branchOffice)
        {
            if (IsUsernameUnique(userName, UserType.Employer))
            {
                user employer = new user(userName, UserType.Employer);
                Console.WriteLine($"Employer registered at branch office: {branchOffice}");
                employerUsers.Add(employer);
                return employer;
            }
            else
            {
                Console.WriteLine("Username is not unique for employers. Please choose a different one.");
                return null;
            }
        }

        private bool IsUsernameUnique(string userName, UserType userType)
        {
            return !employerUsers.Exists(user => user.UserName == userName && user.UserType == userType);
        }
    }
}

