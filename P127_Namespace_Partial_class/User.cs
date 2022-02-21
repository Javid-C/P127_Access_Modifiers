using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Namespace_Partial_class
{
    class User
    {
        protected string Id;// Access modifier example
        private string _username;
        string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }

        }

        public User(string username, string pw)
        {
            Username = username;
            Password = pw;
        }

        

        public static bool CheckPassword(string pw)
        {
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char item in pw)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                        continue;
                    }
                    if(char.IsLower(item))
                    {
                        hasLower = true;
                    }
                }
                bool result = hasDigit && hasLower && hasUpper;
                return result;
            }
            return false;
        }

    }
}
