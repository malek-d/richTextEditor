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
            isSuccessLbl.Text = "";
            Boolean isComplete = validateForm();
            if (isComplete)
            {
                AuthenticationHandler authentication = new AuthenticationHandler();
                User user = authentication.Signup(usernameTB.Text, passwordTB.Text, userTypeCb.Text, firstNameTb.Text,
                    lastNameTb.Text, dobDPT.Value.ToString("dd-MM-yyyy"));
                if(user == null)
                {
                    isSuccessLbl.Text = "username already exists";
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
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
                isSuccessLbl.Text = "Please fill in Username";
                userNameError.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(passwordTB.Text))
            {
                isSuccessLbl.Text = "Please fill in Password";
                passwordError.Visible = true;
                return false;
            } else if (!passwordTB.Text.Equals(confirmPasswordTB.Text) || String.IsNullOrEmpty(confirmPasswordTB.Text))
            {
                isSuccessLbl.Text = "Please fill in Password again";
                password2Error.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(firstNameTb.Text))
            {
                isSuccessLbl.Text = "Please fill in First name";
                firstNameError.Visible = true;
                return false;
            } else if (String.IsNullOrEmpty(lastNameTb.Text))
            {
                isSuccessLbl.Text = "Please fill in Last name";
                lastNameError.Visible = true;
                return false;
            }
            return true;
        }
    }
}
