using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class Customer
    {
        private string firsName;
        private string lastName;
        private string dob;
        private int age;
        private string ssn;
        private double ammount;
        private string password;
        private string email;
        private string connection;
        MySql.Data.MySqlClient.MySqlConnection conn;
       public  Customer(string firstName, string lastName, string dob, int age, string ssn,
                    double balance,string password,string email)
        {
            setfirstName(firstName);
            setLastName(lastName);
            setDOB(dob);
            setAge(age);
            setSSN(ssn);
            setAmmount(balance);
            setPassword(password);
            setEmail(email);
        }
        public Customer()
        {

        }
        private void setfirstName(string name)
        {
            while (name == " ")
            {
                Console.Write("Name cannot be  left empty!!!");
                Console.Write("\nPlease enter your first name: ");
                name = Console.ReadLine();
            }
            this.firsName = name;
        }
        private void setLastName(string name)
        {
            while (name == " ")
            {
                Console.Write("Name cannot be  left empty!!!");
                Console.Write("\nPlease enter your last name: ");
                name = Console.ReadLine();
            }
            this.lastName = name;
        }
        private void setSSN(string ssn)
        {
            while (ssn == " " || ssn.Length <= 8)
            {
                Console.Write("Please enter a valid social security number(8 digits and no space)!!!");
                Console.Write("\nPlease enter your SSN: ");
                ssn = Console.ReadLine();
            }
            this.ssn = ssn;
        }
        private void setEmail(string email)
        {
            while(!(email.Contains("@"))&& email==" ")
            {
                Console.Write("Incorect format please make sure that your email contains @ and its not empty");
                Console.Write("\nPlease enter your email address: ");
                email = Console.ReadLine();
            }
            this.email = email;
        }
        
        private void setDOB(string dob)
        {
            while(dob==" ")
            {
                Console.Write("Please Do not leave date of birth empty, you might get some puncakes");
                Console.Write("\nPlease enter your DOB");
                dob = Console.ReadLine();
            }
            this.dob = dob;
        }
        private void setAge(int age)
        {
            while(age==0)
            {
                Console.Write("Do not leave age field empty!!");
                Console.Write("\nPlease enter your age: ");
                age = int.Parse(Console.ReadLine());
              
            }
            this.age = age;
        }
        
        private void setAmmount(double ammount)
        {
            while(ammount<0)
            {
                Console.Write("You cannot have a negative ammount!!");
                Console.Write("\nHow much you would like to deposit: ");
                ammount = double.Parse(Console.ReadLine());
            }
            this.ammount = ammount;
        }
        private void setPassword(string password)
        {
            this.password = password;
        }
        protected string getPassword()
        {
            return this.password;
        }
        protected string getEmail()
        {
            return this.email;
        }
        public void print()
        {
            Console.Write("First Name: " + firsName
                          + "\nLast Name: " + lastName
                          + "\nDOB: " + dob
                          + "\nAge: " + age
                          + "\nSSN: " + ssn
                          + "\nBalance: " + ammount);
        }
        
    }
}
