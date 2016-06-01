using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Core
{
    public class UserManager
    {

        public INotifier Notifier { get; set; }

        public UserManager(INotifier notifier)
        {
            this.Notifier = notifier;
        }


        public void ChangePassword(string username,string oldpwd,string newpwd)
        {

            //change password here

            //Notify the user
            Notifier.Notify("Password was changed on " + DateTime.Now);
        }
    }
}
