namespace PracticeTwo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.txt_createAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name (First and LAst)";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(360, 162);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(212, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(360, 205);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(212, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Login.Location = new System.Drawing.Point(258, 341);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(260, 51);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(204, 293);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(101, 17);
            this.cb_showPassword.TabIndex = 5;
            this.cb_showPassword.Text = "Show password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // txt_createAccount
            // 
            this.txt_createAccount.AutoSize = true;
            this.txt_createAccount.Location = new System.Drawing.Point(464, 293);
            this.txt_createAccount.Name = "txt_createAccount";
            this.txt_createAccount.Size = new System.Drawing.Size(81, 13);
            this.txt_createAccount.TabIndex = 6;
            this.txt_createAccount.TabStop = true;
            this.txt_createAccount.Text = "Create Account";
            this.txt_createAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txt_createAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_createAccount);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.LinkLabel txt_createAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

