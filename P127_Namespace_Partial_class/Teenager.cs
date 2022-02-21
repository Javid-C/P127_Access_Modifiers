using MyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Namespace_Partial_class
{
    class Teenager : Human
    {
        private int _password;
        public int Password
        {
            set
            {
                _password = value;
            }
        }
        public Teenager()
        {
            //Human human = new Human();
            //Surname =
        }
    }
}
