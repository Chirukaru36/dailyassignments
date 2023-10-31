using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    public class JobSeekerRegistration
    {
        private List<user> jobseekerUsers = new List<user>();

        public user RegisterJobSeeker(string userName)
        {
            if (IsUsernameUnique(userName, UserType.JobSeeker))
            {
                user jobSeeker = new user(userName, UserType.JobSeeker);
                return jobSeeker;
            }
            else
            {
                return null;
            }
        }
            private bool IsUsernameUnique(string userName,UserType userType)
            {
             return !
                jobseekerUsers.Exists(user=> user.UserName == userName && user.UserType == userType);

            }
    }
}

