using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLibrary
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Read { get; set; }
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Reciever { get; set; }

        public Message()
        {
            this.Read = false;
        }
    }
}
