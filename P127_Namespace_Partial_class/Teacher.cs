using MyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Namespace_Partial_class
{
    class Teacher:Human
    {
        public Teacher()
        {
            Name = "Javid";
        }
        public string getName()
        {
            return Name;
        }
    }
}
