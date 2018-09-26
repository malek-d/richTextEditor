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
           AuthenticationHandler authentication = new AuthenticationHandler();
           User loginUser = authentication.Login(usernameTB.Text, passwordTB.Text);
           if (loginUser != null)
           {
               TextEditor textEditor = new TextEditor(loginUser);
               this.Hide();
               textEditor.Text = "ProEdit Text Editor Window";
               textEditor.ShowDialog();
               this.Show();
           }
           else
           {
                isSuccessLbl.Text = "User not found, please try again";
                isSuccessLbl.ForeColor = System.Drawing.Color.Red;
                isSuccessLbl.Font = new Font("Arial", 12, FontStyle.Regular);
           }
        }
    }
}
