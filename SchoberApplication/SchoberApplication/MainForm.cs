using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectCsharpToMysql;

namespace SchoberApplication
{
    public partial class MainForm : Form
    {

        Login login;
        public AccessLevels userAccess = AccessLevels.None;
        public MainForm()
        {
            InitializeComponent();
            //Creates LogInScreen which changes user's AccessLevel
            logUser();
           
        }

        private void logUser()
        {
            login = new Login(); //Create a login Screen and Pass it a controller (parent)

            login.OnLogin += new Login.LoginHandler(CheckLogin);
            login.ShowDialog();
            
        }

        void CheckLogin(object a, LoginArgs e)
        {
          
            //Check whether the loginDetails are comparable to the ones we have in database and give user according userAccess.
            //e.LoginDetails returns a String in the format  "username%%password"
            if (e.LoginDetails.CompareTo(e.LoginDetails) == 0)
            {
                userAccess = AccessLevels.Admin;

            }
            else
            {
                userAccess = AccessLevels.None;
            }
            Console.WriteLine("User's Access Level is " + userAccess);

            ((Form)a).Close(); //Close the Login Screen and return to whatever screen launched it.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
       
    }

}
