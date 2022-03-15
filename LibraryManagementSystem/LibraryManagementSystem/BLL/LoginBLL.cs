using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        public static LoginUser Login(string LoginCode, string Password, string Type)
        {
          return LoginDAL.Login(LoginCode, Password, Type);
        }
    }
}
