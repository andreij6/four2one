using SocialDB;
using SocialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Social.Web.Controllers.API
{
    public class UserController : ApiController
    {
        // GET: api/User
        public List<ApplicationUser> Get()
        {
            List<ApplicationUser> users;

            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                users = db.Users.ToList();

                string userEmail = HttpContext.Current.User.Identity.Name.ToString();

                ApplicationUser remove = users.FirstOrDefault(x => x.Email == userEmail);

                users.Remove(remove);
            }

            return users;
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
