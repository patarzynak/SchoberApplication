using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoberApplication
{
    public class LoginArgs : EventArgs
    {
        private string loginDetails;
        public LoginArgs(string loginDetails)
        {
            this.loginDetails = loginDetails;
        }

        // This is a straightforward implementation for 
        // declaring a public field
        public string LoginDetails
        {
            get
            {
                return loginDetails;
            }
        }
    }
}
