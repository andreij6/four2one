using Social.Web.Code;
using Social.Web.Code.Adapters.Adapters;
using Social.Web.Code.Adapters.Interfaces;
using SocialLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace Social.Web.Controllers.API
{
    public class AdminController : ApiController
    {
        IDBAdapter _db;

        public AdminController() 
        {
            _db = new DBAdapter();
        }

        public IEnumerable<ApplicationUser> Get()
        {
            IList<ApplicationUser> results = _db.GetAllUsers();

            return results;
        }


    }
}
