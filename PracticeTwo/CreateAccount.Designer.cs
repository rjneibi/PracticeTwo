namespace PracticeTwo
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.btn_returnToLogin = new System.Windows.Forms.Button();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_retypePassword = new System.Windows.Forms.TextBox();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createAccount.Location = new System.Drawing.Point(165, 343);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(188, 54);
            this.btn_createAccount.TabIndex = 0;
            this.btn_createAccount.Text = "Create Account ";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // btn_returnToLogin
            // 
            this.btn_returnToLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_returnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnToLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_returnToLogin.Location = new System.Drawing.Point(481, 343);
            this.btn_returnToLogin.Name = "btn_returnToLogin";
            this.btn_returnToLogin.Size = new System.Drawing.Size(188, 54);
            this.btn_returnToLogin.TabIndex = 1;
            this.btn_returnToLogin.Text = "Return to Login";
            this.btn_returnToLogin.UseVisualStyleBackColor = false;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(105, 160);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(229, 20);
            this.txt_firstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LAst Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(105, 216);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(229, 20);
            this.txt_lastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(105, 266);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(229, 20);
            this.txt_email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(493, 160);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(229, 20);
            this.txt_password.TabIndex = 8;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Retrype password";
            // 
            // txt_retypePassword
            // 
            this.txt_retypePassword.Location = new System.Drawing.Point(493, 216);
            this.txt_retypePassword.Name = "txt_retypePassword";
            this.txt_retypePassword.Size = new System.Drawing.Size(229, 20);
            this.txt_retypePassword.TabIndex = 10;
            this.txt_retypePassword.UseSystemPasswordChar = true;
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(493, 269);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(103, 17);
            this.cb_showPassword.TabIndex = 12;
            this.cb_showPassword.Text = "SHow password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_retypePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.btn_returnToLogin);
            this.Controls.Add(this.btn_createAccount);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Button btn_returnToLogin;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_retypePassword;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}