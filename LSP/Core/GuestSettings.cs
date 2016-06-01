using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSP.Core
{
    public class GuestSettings: IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("GuestName", "John");
            return settings;
        }
    }

//    public class GuestSettings : ISettings
//    {
//        public void GetSettings()
//        {
//            //get settings from database
//            //include guest name、ip address...
//        }
//
//        public void SetSettings()
//        {
//            //guests are not allowed set settings
//            throw new NotImplementedException();
//        }
//    }
}