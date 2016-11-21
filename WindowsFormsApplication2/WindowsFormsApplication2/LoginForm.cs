using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void editFirstname_TextChanged(object sender, EventArgs e) {

        }

        private void editPassword_TextChanged(object sender, EventArgs e) {

        }

        private void btnRegister_Click(object sender, EventArgs e) {

        }

        private void editUsername_TextChanged(object sender, EventArgs e) {

        }

        private void editLastname_TextChanged(object sender, EventArgs e) {

        }

        private void onEditUsernameClicked(object sender, EventArgs e) {
            editUsername.Text = "";
        }

        private void onEditPasswordClicked(object sender, EventArgs e) {
            editPassword.Text = "";
        }

        private void onLoginButtonClicked(object sender, EventArgs e) {
            String username = editUsername.Text;
            String password = editPassword.Text;

            if ((username == null || username.Length == 0) || (password == null || password.Length == 0)) {
                //TODO: obtain wrong arguments. Show alert dialog
                return;
            }
            new MainForm(username).Show();
        }
    }
}
