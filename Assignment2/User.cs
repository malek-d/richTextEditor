using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public enum Type { View, Edit }
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public Type User_Type { get; set; }
        private String First_Name { get; set; }
        private String Last_Name { get; set; }
        private DateTime Dob { get; set; }

        public User()
        {
            Username = "";
            Password = "";
            User_Type = Type.View;
            First_Name = "";
            Last_Name = "";
            Dob = DateTime.Now;
        }

        public User(String username, String password, Type Type, String First, String Last, DateTime dob)
        {
            Username = username;
            Password = password;
            User_Type = Type;
            First_Name = First;
            Last_Name = Last;
            Dob = dob;
        }

        public User(String username, String password, String Type, String First, String Last, String dob)
        {
            Username = username;
            Password = password;
            if (Type.Equals("View"))
            {
                User_Type = Assignment2.Type.View;
            }
            else
            {
                User_Type = Assignment2.Type.Edit;
            }
            First_Name = First;
            Last_Name = Last;
            Dob = DateTime.Parse(dob);
        }
    }
}
