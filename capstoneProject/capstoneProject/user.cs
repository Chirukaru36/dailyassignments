using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    public enum UserType
    {
        JobSeeker,
        Employer
    }
    public class user
    {
        public string UserName { get; set; }
        public UserType UserType { get; set; }

        public user(string userName, UserType userType)
        {
            UserName = userName;
            UserType = userType;
        }
    }
}
    
