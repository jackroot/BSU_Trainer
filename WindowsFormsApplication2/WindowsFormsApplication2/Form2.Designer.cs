namespace WindowsFormsApplication2
{
    partial class RegisterForm
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
            this.editLastname = new System.Windows.Forms.TextBox();
            this.editUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.editFirstname = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editLastname
            // 
            this.editLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editLastname.ForeColor = System.Drawing.SystemColors.Window;
            this.editLastname.Location = new System.Drawing.Point(62, 94);
            this.editLastname.MinimumSize = new System.Drawing.Size(160, 0);
            this.editLastname.Name = "editLastname";
            this.editLastname.Size = new System.Drawing.Size(160, 20);
            this.editLastname.TabIndex = 0;
            this.editLastname.Text = "last name";
            this.editLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editLastname.Click += new System.EventHandler(this.onEditLastnameClicked);
            this.editLastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // editUsername
            // 
            this.editUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.editUsername.Location = new System.Drawing.Point(62, 120);
            this.editUsername.MinimumSize = new System.Drawing.Size(160, 0);
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(160, 20);
            this.editUsername.TabIndex = 1;
            this.editUsername.Text = "username";
            this.editUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editUsername.Click += new System.EventHandler(this.onEditUsernameClicked);
            this.editUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.MinimumSize = new System.Drawing.Size(192, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register your account";
            // 
            // editPassword
            // 
            this.editPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.editPassword.Location = new System.Drawing.Point(62, 146);
            this.editPassword.MinimumSize = new System.Drawing.Size(160, 0);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(160, 20);
            this.editPassword.TabIndex = 3;
            this.editPassword.Text = "password";
            this.editPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editPassword.Click += new System.EventHandler(this.onEditPasswordClicked);
            this.editPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // editFirstname
            // 
            this.editFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editFirstname.ForeColor = System.Drawing.SystemColors.Window;
            this.editFirstname.Location = new System.Drawing.Point(62, 68);
            this.editFirstname.MinimumSize = new System.Drawing.Size(160, 0);
            this.editFirstname.Name = "editFirstname";
            this.editFirstname.Size = new System.Drawing.Size(160, 20);
            this.editFirstname.TabIndex = 4;
            this.editFirstname.Text = "first name";
            this.editFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editFirstname.Click += new System.EventHandler(this.onEditFirstnameClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegister.Location = new System.Drawing.Point(103, 172);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.onRegisterButtonClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.editFirstname);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editUsername);
            this.Controls.Add(this.editLastname);
            this.Name = "RegisterForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editLastname;
        private System.Windows.Forms.TextBox editUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.TextBox editFirstname;
        private System.Windows.Forms.Button btnRegister;
    }
}