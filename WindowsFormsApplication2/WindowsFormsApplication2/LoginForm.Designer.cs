namespace WindowsFormsApplication2
{
    partial class LoginForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRegister.Location = new System.Drawing.Point(107, 141);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Log in";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.onLoginButtonClicked);
            // 
            // editPassword
            // 
            this.editPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.editPassword.Location = new System.Drawing.Point(66, 115);
            this.editPassword.MinimumSize = new System.Drawing.Size(160, 4);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(160, 20);
            this.editPassword.TabIndex = 9;
            this.editPassword.Text = "password";
            this.editPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editPassword.Click += new System.EventHandler(this.onEditPasswordClicked);
            this.editPassword.TextChanged += new System.EventHandler(this.editPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.MinimumSize = new System.Drawing.Size(192, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editUsername
            // 
            this.editUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.editUsername.Location = new System.Drawing.Point(66, 89);
            this.editUsername.MinimumSize = new System.Drawing.Size(160, 4);
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(160, 20);
            this.editUsername.TabIndex = 7;
            this.editUsername.Text = "username";
            this.editUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editUsername.Click += new System.EventHandler(this.onEditUsernameClicked);
            this.editUsername.TextChanged += new System.EventHandler(this.editUsername_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editUsername;

    }
}