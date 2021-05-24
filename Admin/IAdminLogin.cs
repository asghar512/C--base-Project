using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class IAdminLogin
    {
        string username;
        string password;
        public IAdminLogin(string uname, string pw)
        {
            username = uname;
            password = pw;
        }
        public bool authenticate()
        {

            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
