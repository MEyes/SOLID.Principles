using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;

namespace LSP.Core
{
    public class UserSettings:IReadableSettings,IWritableSettings
    {
        private string userName = "";

        public UserSettings(string username)
        {
            this.userName = username;
        }


        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("DisplayName", "Bob");
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "User settings for " + userName + " saved on " + DateTime.Now;
        }
    }

//    public class UserSettings : ISettings
//    {
//        public void GetSettings()
//        {
//            throw new NotImplementedException();
//        }
//
//        public void SetSettings()
//        {
//            throw new NotImplementedException();
//        }
//    }
}