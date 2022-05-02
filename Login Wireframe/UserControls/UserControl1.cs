using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Wireframe.UserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        string userName;
        string userPassword;

        private void ViewPassowordPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassowordPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = false;
        }

        private void ViewPassowordPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (userNameTextBox.TextLength == 0 || passwordTextbox.TextLength == 0)
            {
                MessageBox.Show("UserName and Password not entered!", "Login info required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userName = userNameTextBox.Text;
                userPassword = passwordTextbox.Text;
            }
        }

            
     }
}       

    
