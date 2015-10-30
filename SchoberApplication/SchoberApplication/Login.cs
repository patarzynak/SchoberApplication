using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChreneLib.Controls.TextBoxes;


namespace SchoberApplication
{
    public partial class Login : Form
    {
        MainForm parent;
        public delegate void LoginHandler(object myObject,
                                               LoginArgs myArgs);
        public event LoginHandler OnLogin;
        public Login(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
         
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\n"+parent.Name);
            LoginArgs loginArgs = new LoginArgs(cTextBox1.Text+"%%"+cTextBox2.Text, parent);
            OnLogin(this, loginArgs);
            Console.WriteLine(loginArgs.Message);
            if (parent.userAccess == AccessLevels.Regular)
            {
                Console.WriteLine("I AM REGULAR NOW WOO");
                parent.Show();
            }
           
        }

  
    }
}
