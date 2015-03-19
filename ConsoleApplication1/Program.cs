using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=12345;database=test;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Connection Error");
            }

            while (true)
            {
                Console.Write("Welcome to our bank");
                string choice;
                Console.Write("\nTo log in to existing account press 1 ");
                Console.Write("\nTo create an acoount in our bank press 2 ");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Login log=new Login();
                        string email;
                        string password;
                        Console.Write("Please enter a email: ");
                        email = Console.ReadLine();
                        Console.Write("\nPlease enter your password");
                        password = Console.ReadLine();
                        if (log.authentication(email, password))
                            Console.Write("Your are succesfully loged in");
                        else
                            Console.Write("Authentication failed");

                        break;
                    case "2":
                        SignUp signUp = new SignUp();
                        signUp.creating();
                        break;

                }
            }
          
            
        }
    }
}
