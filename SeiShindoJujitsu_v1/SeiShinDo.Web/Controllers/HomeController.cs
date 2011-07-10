using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using SeiShinDo.Web.Common;


namespace SeiShinDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult YoshitsuneJujitsu()
        {
            string TextContent = "Yoshitsune Jiu-Jitsu is a traditional Japanese style of jiu-jitsu, It is designed strictly for self-defense.  \r\nIt contains many of the beautiful lock and throw techniques of Aikido, throwing techniques of Kodokan Judo, \r\nand striking techniques of various Karate styles, and many other techniques not common to any of these forms.\r\n\r\n" +
                                 "Yes, it contains devastating punishment type techniques designed to break bones, dislocate joints, and do other damage.  \r\nSome of its techniques are potentially deadly.  However, it also contains much that enables the practitioner to control a situation, \r\nand an opponent, in such a way that no HARM is necessary.\r\n\r\n" +
                                 "Therefore, it has proven to be a very effective self-defense form for police officers and others who wish to control rather \r\nthan damage.  The classes in Yoshitsune are taught in a variety of ways, but usually begin with Ukemi, which is breakfall techniques to teach \r\na student to take falls without being injured.  Then kata, or form training occurs to give students a base of technique on which to develop.\r\n\r\n" +
                                 "This proceeds to various randori (free practice) activities, from one-on-one attack and defense activities to blindfold \r\nactivities to multiple attack sequences against a number of attackers both armed and unarmed.  Unlike some of the strike oriented styles of \r\njiu-jitsu or the ground grappling styles of jiu-jitsu, Yoshitsune is not bound in one form, but is very diverse in types of technique.  \r\nIt has little sport element to it at all, and is geared almost solely to self-defense.";
            UIHelper uiHelper = new UIHelper();
            
            ViewBag.Title = "Yoshitsune Jujitsu History";
            ViewBag.Content = HtmlExtensions.Nl2Br(TextContent);
            
            return View();
        }

        
    }
}
