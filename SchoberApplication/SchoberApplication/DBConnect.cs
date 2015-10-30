using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SchoberApplication
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
         
            string connectionString;
          
           connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["team06ConnectionString"].ConnectionString;
          //      connectionString = "SERVER=silva;PORT=3306;DATABASE=14ac3d06;Uid=14ac3u06;PASSWORD=cba123;";
            Console.WriteLine("\n\n"+connectionString);
            
            connection = new MySqlConnection(connectionString);
        }

        
        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                       Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine("\n\n"+ex.Message+"\n\n");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        

        //Insert statement
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
            throw new NotImplementedException();
        }

        //Count statement
        public int Count()
        {
            throw new NotImplementedException();
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
