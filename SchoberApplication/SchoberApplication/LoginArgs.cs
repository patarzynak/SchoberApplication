using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoberApplication
{
    public class LoginArgs : EventArgs
    {
        private string message;
        private MainForm controller;
        public LoginArgs(string message, MainForm controller)
        {
            this.controller = controller;
            this.message = message;
        }

        // This is a straightforward implementation for 
        // declaring a public field
        public string Message
        {
            get
            {
                controller.userAccess = AccessLevels.Regular;
                Console.WriteLine(controller.userAccess);
                
                return message;
            }
        }
    }
}
