using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultancyBusinessLogicLayer

{
    public class Register
    {
        public void JobseekerRegister()
        {
            Console.WriteLine("jobseeker registration: enter your details");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            if (IsValidUsername(username) && IsValidPassword(password))
            {


                Console.WriteLine("Registration successfull");
                Console.WriteLine($"username: {username}");
            }


            else
            {
                Console.WriteLine("Registration failed,Please enter valid username and password");
            }
        }
        private bool IsValidUsername(string username)
        {
            return username.Length >= 5;
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 5;
        }
    }
}
