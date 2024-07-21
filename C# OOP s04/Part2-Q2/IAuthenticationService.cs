using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_s04
{
    internal interface IAuthenticationService
    {

        public bool AuthenticateUser(string UserName , string password);
        public bool AuthorizeUser(string UserName  , string role);

    }
}
