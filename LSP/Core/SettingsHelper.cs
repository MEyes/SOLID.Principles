using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSP.Core
{
    public class SettingsHelper
    {
        public static Dictionary<IReadableSettings, Dictionary<string, string>> GetAllSettings(List<IReadableSettings> items)
        {
            var allSettings = new Dictionary<IReadableSettings, Dictionary<string, string>>();
            foreach (IReadableSettings item in items)
            {
                allSettings.Add(item, item.GetSettings());
            }
            return allSettings;
        }
        public static List<string> SetAllSettings(List<IWritableSettings> items,
        List<Dictionary<string, string>> values)
        {
            List<string> messages = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                messages.Add(items[i].SetSettings(values[i]));
            }
            return messages;
        }
    }
}