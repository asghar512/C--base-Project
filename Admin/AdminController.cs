using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class AdminController
    {

        public string createLibrarian(string name, string cno, string uname, string pw)
        {
            Librarian l = new Librarian();
            return l.createLibrarian(name, cno, uname, pw);
        }

        public DataTable getLibrarians(string name)
        {
            Librarian l = new Librarian();
            return l.getLibrarians(name);
        }
        public string deleteLibrarian(string lid)
        {
            Librarian l = new Librarian();
            return l.deleteLibrarian(lid);
        }
        public string updateLibrarian(string id, string name, string cno, string pw)
        {
            Librarian l = new Librarian();
            return l.updateLibrarian(id, name, cno, pw);
        }

        public bool authenticate(string username, string password)
        {

            IAdminLogin ia = new IAdminLogin(username, password);
            return ia.authenticate();
        }
    
    }
}
