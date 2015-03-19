using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Login :Customer
    {
       public Login () :base()
        {

        }
        public Boolean authentication(string email,string passowrd)
        {
            return ((getPassword()== passowrd)&& (getEmail()==email)) ? true : false;
        }
    }
}
