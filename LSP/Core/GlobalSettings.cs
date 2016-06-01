using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSP.Core
{
    public class GlobalSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("Theme", "Summer");
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "Global settings saved on " + DateTime.Now;
        }
    }

//    public class GlobalSettings : ISettings
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