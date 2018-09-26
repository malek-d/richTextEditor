namespace Assignment2
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userTypeCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dobDPT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.password2Error = new System.Windows.Forms.Label();
            this.firstNameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.isSuccessLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(224, 542);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 54);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.Location = new System.Drawing.Point(63, 542);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(122, 54);
            this.signupBtn.TabIndex = 6;
            this.signupBtn.Text = "Submit";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userTypeCb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dobDPT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lastNameTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.firstNameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.confirmPasswordTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 448);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // userTypeCb
            // 
            this.userTypeCb.AllowDrop = true;
            this.userTypeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCb.FormattingEnabled = true;
            this.userTypeCb.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeCb.Location = new System.Drawing.Point(104, 408);
            this.userTypeCb.Name = "userTypeCb";
            this.userTypeCb.Size = new System.Drawing.Size(172, 24);
            this.userTypeCb.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "User-Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date of birth";
            // 
            // dobDPT
            // 
            this.dobDPT.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.dobDPT.CustomFormat = "dd - MMMM - yyyy";
            this.dobDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDPT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDPT.Location = new System.Drawing.Point(8, 364);
            this.dobDPT.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dobDPT.Name = "dobDPT";
            this.dobDPT.Size = new System.Drawing.Size(268, 26);
            this.dobDPT.TabIndex = 10;
            this.dobDPT.Value = new System.DateTime(2018, 9, 25, 10, 22, 28, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name";
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTb.Location = new System.Drawing.Point(6, 301);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(270, 26);
            this.lastNameTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "First Name";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTb.Location = new System.Drawing.Point(6, 243);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(270, 23);
            this.firstNameTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re-Enter Password";
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTB.Location = new System.Drawing.Point(6, 186);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(270, 23);
            this.confirmPasswordTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(6, 126);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(270, 23);
            this.passwordTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.usernameTB.Location = new System.Drawing.Point(6, 63);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(270, 23);
            this.usernameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ProEdit";
            // 
            // userNameError
            // 
            this.userNameError.AutoSize = true;
            this.userNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameError.ForeColor = System.Drawing.Color.Red;
            this.userNameError.Location = new System.Drawing.Point(352, 132);
            this.userNameError.Name = "userNameError";
            this.userNameError.Size = new System.Drawing.Size(13, 20);
            this.userNameError.TabIndex = 8;
            this.userNameError.Text = "!";
            this.userNameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(352, 195);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(13, 20);
            this.passwordError.TabIndex = 9;
            this.passwordError.Text = "!";
            this.passwordError.Visible = false;
            // 
            // password2Error
            // 
            this.password2Error.AutoSize = true;
            this.password2Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Error.ForeColor = System.Drawing.Color.Red;
            this.password2Error.Location = new System.Drawing.Point(352, 255);
            this.password2Error.Name = "password2Error";
            this.password2Error.Size = new System.Drawing.Size(13, 20);
            this.password2Error.TabIndex = 10;
            this.password2Error.Text = "!";
            this.password2Error.Visible = false;
            // 
            // firstNameError
            // 
            this.firstNameError.AutoSize = true;
            this.firstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameError.ForeColor = System.Drawing.Color.Red;
            this.firstNameError.Location = new System.Drawing.Point(352, 312);
            this.firstNameError.Name = "firstNameError";
            this.firstNameError.Size = new System.Drawing.Size(13, 20);
            this.firstNameError.TabIndex = 11;
            this.firstNameError.Text = "!";
            this.firstNameError.Visible = false;
            // 
            // lastNameError
            // 
            this.lastNameError.AutoSize = true;
            this.lastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameError.ForeColor = System.Drawing.Color.Red;
            this.lastNameError.Location = new System.Drawing.Point(352, 370);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(13, 20);
            this.lastNameError.TabIndex = 12;
            this.lastNameError.Text = "!";
            this.lastNameError.Visible = false;
            // 
            // isSuccessLbl
            // 
            this.isSuccessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isSuccessLbl.ForeColor = System.Drawing.Color.Red;
            this.isSuccessLbl.Location = new System.Drawing.Point(63, 39);
            this.isSuccessLbl.Name = "isSuccessLbl";
            this.isSuccessLbl.Size = new System.Drawing.Size(283, 23);
            this.isSuccessLbl.TabIndex = 13;
            this.isSuccessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 613);
            this.Controls.Add(this.isSuccessLbl);
            this.Controls.Add(this.lastNameError);
            this.Controls.Add(this.firstNameError);
            this.Controls.Add(this.password2Error);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.userNameError);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox userTypeCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dobDPT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label password2Error;
        private System.Windows.Forms.Label firstNameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.Label isSuccessLbl;
    }
}