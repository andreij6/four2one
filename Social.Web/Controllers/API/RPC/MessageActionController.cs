using SocialDB;
using SocialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Social.Web.Controllers.API.RPC
{
    public class MessageActionController : ApiController
    {
        [HttpGet]
        public void MarkAsRead(int Id)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                Message model = db.Messages.Where(x => x.Id == Id).FirstOrDefault();

                model.Read = true;

                db.SaveChanges();
            }
        }

        [HttpGet]
        public List<Message> GetSent()
        {
            List<Message> result = new List<Message>();

            using(ApplicationDbContext db = new ApplicationDbContext())
            {
               string userEmail = HttpContext.Current.User.Identity.Name.ToString();

               result = db.Messages.Include("Sender").Where(x => x.Sender.Email == userEmail).ToList();
            }

            return result;
        }
    }
}
