using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Text = "Register";
            signup.ShowDialog();

            this.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), "login.txt");
            
            StreamReader reader = File.OpenText("..\\..\\login.txt");
            string line;
            Boolean didLogin = false;
            while ((line = reader.ReadLine())!= null)
            {
                string[] items = line.Split(',');

                if(items[0].Equals(usernameTB.Text) && items[1].Equals(passwordTB.Text))
                {
                    User loginUser = new User(items[0], items[1], items[2], items[3], items[4], items[5]);
                    TextEditor textEditor = new TextEditor(loginUser);

                    didLogin = true;

                    this.Hide();
                    textEditor.Text = "ProEdit Text Editor Window";
                    textEditor.ShowDialog();
                    this.Show();                    
                }
            }
            if (!didLogin)
            {
                isSuccessLbl.Text = "User not found, please try again";
                isSuccessLbl.ForeColor = System.Drawing.Color.Red;
                isSuccessLbl.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }
    }
}
