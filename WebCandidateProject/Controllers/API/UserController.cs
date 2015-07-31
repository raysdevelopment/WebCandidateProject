using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebCandidateProject.Models;
using WebCandidateProject.Data;

namespace WebCandidateProject.Controllers.API
{
    public class UserController : ApiController
    {
        // GET api/user
        public IEnumerable<User> Get()
        {
            return UserData.Get();
        }

        // GET api/user/5
        public User Get(int id)
        {
            var users = UserData.Get();
            return users.FirstOrDefault(u => u.UserId == id);
        }
    }
}