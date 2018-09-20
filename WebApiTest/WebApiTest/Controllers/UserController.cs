using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class UserController : ApiController
    {
        public UserModel getAdmin()
        {
            return new UserModel() { UserID = "000", UserName = "Admin" };
        }
    }
}
