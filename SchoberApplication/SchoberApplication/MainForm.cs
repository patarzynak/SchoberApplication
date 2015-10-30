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


        public AccessLevels userAccess = AccessLevels.None;
        public MainForm()
        {
            InitializeComponent();
            //Creates LogInScreen which changes user's AccessLevel
            logUser();
           
        }

        private void logUser()
        {
            Login login = new Login(this);

            login.OnLogin += new Login.LoginHandler(ShowLoginMessage);
            login.ShowDialog();
            
        }

        static void ShowLoginMessage(object a, LoginArgs e)
        {
           
        }
       
    }

}
