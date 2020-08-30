using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class UserInfo
    {
        public int id;
        public string UserName;
        private string UserPassword;
        public int Age;


        void method()
        {
            id = 10;
            UserName = "";
            UserPassword = "";
          
        }

        public override string ToString()
        {
            return String.Format("UserInfo [ID:{0}, User Name:{1},Password:{3}, Age:{2}]",id,UserName,Age,UserPassword) ;
        }
    }
    class Encapulation
    {
        static void Main(string[] args)
        {
            UserInfo user = new UserInfo();
            user.id = 1;
            user.UserName = "Ali";
            user.Age = 225;
            

            Console.WriteLine(user);     // or     Console.WriteLine(user.ToString());

            Console.ReadKey();
        }
    }
}
