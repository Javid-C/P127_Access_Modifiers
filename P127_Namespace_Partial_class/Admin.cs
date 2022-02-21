using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Namespace_Partial_class
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(string username,string pw,bool issuperadmin,string section):base(username,pw)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }


        public string GetInfo()
        {
            return $"Username: {Username}, Password: {Password}, Is super admin: {(IsSuperAdmin ? "Yes" : "No")}, Section: {Section}";
        }
    }
}
