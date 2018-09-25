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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            userTypeCb.SelectedIndex = 0;
            dobDPT.CustomFormat = "dd MMMM yy";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            //if(usernameTB && passwordTB && )
            Boolean isComplete = validateForm();
            if (isComplete)
            {
                //Valid Sign up
                isSuccessLbl.Text = "";
                StreamReader reader = File.OpenText("login.txt");
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split(',');

                    if (items[0].Equals(usernameTB.Text))
                    {
                        isSuccessLbl.Text = "Username already existant";
                    }
                }
                reader.Close();

                User user = new User(usernameTB.Text, passwordTB.Text, userTypeCb.Text, firstNameTb.Text,
                    lastNameTb.Text, dobDPT.Value.ToString("dd-MM-yyyy"));
                String newUser = "\n" + usernameTB.Text + "," + passwordTB.Text + "," + userTypeCb.Text + "," + firstNameTb.Text + "," +
                    lastNameTb.Text + "," + dobDPT.Value.ToString("dd-MM-yyyy");

                File.AppendAllText("login.txt", newUser + Environment.NewLine);

                textEditor textEditor = new textEditor(user);
                //textEditor.User = user;
                this.Hide();
                textEditor.Show();
            }
        }

        private bool validateForm()
        {
            userNameError.Visible = false;
            passwordError.Visible = false;
            password2Error.Visible = false;
            firstNameError.Visible = false;
            lastNameError.Visible = false;
            if (String.IsNullOrEmpty(usernameTB.Text))
            {
                userNameError.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(passwordTB.Text))
            {
                passwordError.Visible = true;
                return false;
            } else if (!passwordTB.Text.Equals(confirmPasswordTB.Text) || String.IsNullOrEmpty(confirmPasswordTB.Text))
            {
                password2Error.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(firstNameTb.Text))
            {
                firstNameError.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(lastNameTb.Text))
            {
                lastNameError.Visible = true;
                return false;
            }
            return true;
        }
    }
}
