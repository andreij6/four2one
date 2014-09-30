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
    public class MessageController : ApiController
    {
        // GET: api/Message
        public IEnumerable<Message> Get()
        {
            List<Message> inbox;

            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                string userEmail = HttpContext.Current.User.Identity.Name.ToString();
                ApplicationUser user = db.Users.Where(m => m.Email == userEmail).FirstOrDefault();

                inbox = db.Messages.Include("Sender").Include("Reciever").Where(x => x.Reciever.Id == user.Id).ToList();

                var mySent = inbox.Where(x => x.Sender.Id == user.Id).ToList();

                foreach(Message x in mySent)
                {
                    inbox.Remove(x);
                }
            }

            return inbox;
        }

        // GET: api/Message/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Message
        public void Post(Message model)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                ApplicationUser recipient = db.Users.FirstOrDefault(x => x.Id == model.Reciever.Id);
                string senderName = HttpContext.Current.User.Identity.Name.ToString();
                ApplicationUser sender = db.Users.FirstOrDefault(x => x.UserName == senderName);

                model.Sender = sender;
                model.Reciever = recipient;

                //recipient.Inbox.Add(model);
                //sender.Sent.Add(model);

                db.Messages.Add(model);

                db.SaveChanges();
            }
        }

        // PUT: api/Message/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Message/5
        public void Delete(int id)
        {
        }
    }
}
