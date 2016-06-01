using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LSP.Core;

namespace LSP.Controllers
{
    public class SettingsController : Controller
    {
        List<IReadableSettings> readableSettings = new List<IReadableSettings>();
        List<IWritableSettings> writableSettings = new List<IWritableSettings>();
        public SettingsController()
        {
            GlobalSettings g = new GlobalSettings();
            SectionSettings s = new SectionSettings("Sports");
            UserSettings u = new UserSettings("User1");
            GuestSettings gu = new GuestSettings();

            readableSettings.Add(g);
            readableSettings.Add(s);
            readableSettings.Add(u);
            readableSettings.Add(gu);

            writableSettings.Add(g);
            writableSettings.Add(s);
            writableSettings.Add(u);
        }
        // GET: Settings
        public ActionResult Index()
        {
            var allSettings = SettingsHelper.GetAllSettings(readableSettings);
            return View(allSettings);
        }
        [HttpPost]
        public ActionResult Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();

            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Theme", "Winter");

            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");

            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Tom");

            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Jerry");

            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);
            //settings.Add(gst);

            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);
            return View(model);
        }
    }
}