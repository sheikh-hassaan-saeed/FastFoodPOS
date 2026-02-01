using FastFoodPOS.Common;
using FastFoodPOS.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodPOS.Controller
{
    public class LoginController
    {
        //Referencing with DAL to talk to that
        private LoginDAL _loginDAL = new LoginDAL();

        public bool ExecuteLogin(Admin userObj)
        {
            //Contoller will talk to the DAL and DAL will check the credentials
            return _loginDAL.AuthenticateUser(userObj.Username, userObj.UserPassword);
        }
    }
}
