using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SignUp
    {
       private string fname, lname, ssn, dob,password,email;
        private double deposit;
       private int age;
      public void  creating()
        {
            Console.Write("Please enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("\nPlease enter your last name: ");
            lname = Console.ReadLine();
            Console.Write("\nPlease enter your email adress: ");
            email = Console.ReadLine();
            Console.Write("\nPlease enter your password: ");
            password = Console.ReadLine();
            Console.Write("\nPlease enter your SSN number: ");
            ssn = Console.ReadLine();
            Console.Write("\nPlease endter your Date of Birth: ");
            dob = Console.ReadLine();
            Console.Write("\nPlease enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Please enter the ammount of money you would like to deposit: ");
            deposit = double.Parse(Console.ReadLine());
            Customer cust;
            cust = new Customer(fname, lname, dob, age, ssn, deposit, password, email);

        }
       
            
    }
}
