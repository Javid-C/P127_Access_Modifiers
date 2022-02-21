using MyClasses.Business;
using MyClasses;
using System;

namespace P127_Namespace_Partial_class
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Homework
            //string username;
            //string pw;
            //do
            //{
            //    Console.WriteLine("Username daxil edin: ");
            //    username = Console.ReadLine();
            //} while (username.Length < 6);

            //do
            //{
            //    Console.WriteLine("Password daxil edin: ");
            //    pw = Console.ReadLine();
            //} while (!User.CheckPassword(pw));

            //Console.WriteLine("Are you super admin? yes/no");
            //string str = Console.ReadLine();
            //bool isSuper = false;
            //if (str.ToLower().Trim() == "yes")
            //{
            //    isSuper = true;
            //}

            //Console.WriteLine("Please choose section");
            //string section = Console.ReadLine();

            //Admin admin = new Admin(username, pw, isSuper, section);


            //Console.WriteLine(admin.GetInfo());

            #endregion

            Human human = new Human();
            //human.Name = "Kamran";
            //human.Surname = "Abilov";
            //Console.WriteLine(human.Name + " " + human.Surname);
            Teacher teacher = new Teacher();
            Trade trade = new Trade();

            User user = new User("Lutfiyar","Okay1234");

            Console.WriteLine(teacher.getName());

            Teenager teenager = new Teenager();

            teenager.Password = 192831281;
            Console.WriteLine(teenager.Password);


        }
    }
}
