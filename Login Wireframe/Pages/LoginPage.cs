using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Wireframe
{
    public partial class loginPageForm : Form
    {
        public loginPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectPage selectPage = new SelectPage();
            selectPage.Show();
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string item = "UserName:  " + userControl11.GetUserName();
            listBox1.Items.Add(item);
            item = "Password:  " + userControl11.GetPassWord();
            listBox1.Items.Add(item);
        }
    }
}
