using Social.Web.Code.Adapters.Interfaces;
using SocialDB;
using SocialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Social.Web.Code.Adapters.Adapters
{
    public class DBAdapter : IDBAdapter
    {

        public IList<ApplicationUser> GetAllUsers()
        {
            List<ApplicationUser> users;

            using(ApplicationDbContext repo = new ApplicationDbContext())
            {
                users = repo.Users.ToList();
            }

            return users;
        }
    }
}