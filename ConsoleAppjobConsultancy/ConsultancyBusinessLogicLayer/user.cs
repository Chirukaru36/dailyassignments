using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyBusinessLogicLayer
{
    internal class user
    {
        public enum UserType
        {
            JobSeeker,
            Employer
        }
        public class User
        {
            public string UserName { get; set; }
            public UserType UserType { get; set; }

            public User(string userName, UserType userType)
            {
                UserName = userName;
                UserType = userType;
            }
        }
    }
}
