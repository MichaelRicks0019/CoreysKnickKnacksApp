using System;
using System.Windows.Forms;

namespace Login_Wireframe.UserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string userName { get; set; }
        private string userPassword { get; set; }

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

        public string GetUserName()
        {
            return userName;
        }

        public string GetPassWord()
        {
            return userPassword;
        }


    }

}



