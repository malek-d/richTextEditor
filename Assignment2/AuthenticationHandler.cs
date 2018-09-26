using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AuthenticationHandler
    {
        String path = "..\\..\\login.txt";
        public User Login(String username, String password)
        {
            StreamReader reader = File.OpenText(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split(',');

                if (items[0].Equals(username) && items[1].Equals(password))
                {
                    User loginUser = new User(items[0], items[1], items[2], items[3], items[4], items[5]);
                    reader.Close();
                    return loginUser;
                }
            }
            //User not found
            reader.Close();
            return null;
        }

        public User Signup(String username, String password, String type, String firstName, String lastName, String dob)
        {
            StreamReader reader = File.OpenText(path);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split(',');

                if (items[0].Equals(username))
                {
                    //Ending task as username already exists in login.txt
                    reader.Close();
                    return null;
                }
            }
            reader.Close();

            User user = new User(username, password, type, firstName,lastName, dob);
            String newUser = "\n" + username + "," + password+ "," + type + "," + firstName + "," +
                lastName + "," + dob;

            File.AppendAllText(path, newUser + Environment.NewLine);
            return user;
        }
    }
}
