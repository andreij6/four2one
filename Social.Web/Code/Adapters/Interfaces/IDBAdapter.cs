using SocialLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Web.Code.Adapters.Interfaces
{
    public interface IDBAdapter
    {
        IList<ApplicationUser> GetAllUsers(); 
    }
}
