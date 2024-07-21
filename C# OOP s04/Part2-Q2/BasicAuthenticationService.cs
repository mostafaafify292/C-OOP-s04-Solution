using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C__OOP_s04
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string UserName, string password)
        {
            if (UserName == "Admin" && password == "password")
            {
                Console.WriteLine("true");
                return true;

            }
            else
            {
                Console.WriteLine("Wrong UserName or Password");
            }
            return false; 
        }

        public bool AuthorizeUser(string UserName, string role)
        {
            if (UserName == " Admin " && role == "Admin")
            {
                
                return true; 
            }
            return false;
        }
    }
}
