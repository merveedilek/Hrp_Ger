using Hrp_Ger.Data;
using Hrp_Ger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Hrp_Ger.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private HrpData _data;
        public HomeController()
        {
            _data = new HrpData();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult GardenProducts()
        {
            return View();
        }
        public ActionResult GardenDetails(int id)
        {
            HrpData data = new HrpData();
            BahceModel bahceModel = new BahceModel();
            var urun = data.bahceModels.Where(x => x.BahceId == id).FirstOrDefault();
            bahceModel = urun;
            return View(bahceModel);
        }
        public ActionResult IndoorProducts()
        {
            return View();
        }
        public ActionResult IndoorDetails(int id)
        {
            HrpData data = new HrpData();

            icMekanMobilya icMekanModel = new icMekanMobilya();
            var urun = data.icMekanMobilya.Where(x => x.icMekanId == id).FirstOrDefault();
            icMekanModel = urun;
            return View(icMekanModel);
        }
        public ActionResult Accessories()
        {
            return View();
        }
        public ActionResult AccessorieDetails(int id)
        {
            HrpData data = new HrpData();

            AksesuarModel aksesuarModel = new AksesuarModel();
            var urun = data.aksesuarModels.Where(x => x.aksesuarId == id).FirstOrDefault();
            aksesuarModel = urun;
            return View(aksesuarModel);
        }
        public ActionResult LightingProducts()
        {
            return View();
        }
        public ActionResult LightingDetails(int id)
        {
            HrpData data = new HrpData();

            AydinlatmaModel aydinlatmaModel = new AydinlatmaModel();
            var urun = data.aydinlatmaModels.Where(x => x.AydinlatmaId ==id).FirstOrDefault();
            aydinlatmaModel = urun;
            return View(aydinlatmaModel);
        }
        public ActionResult CityProducts()
        {
            return View();
        }
        public ActionResult CityDetails(int id)
        {
            HrpData data = new HrpData();

            KentModel kentModel = new KentModel();
            var urun = data.kentModels.Where(x => x.KentId == id).FirstOrDefault();
            kentModel = urun;
            return View(kentModel);
        }
        public ActionResult Galeri()
        {
            return View();
        }
        public ActionResult ComplementaryProducts()
        {
            return View();
        }
        public ActionResult WoodType()
        {
            return View();
        }
        public ActionResult FabricsOptions()
        {
            return View();
        }
        public ActionResult LeatherOptions()
        {
            return View();
        }
        public ActionResult MetalColor()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact form)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cred = new NetworkCredential("hrpiletisim@gmail.com", "Hrp123...");
            mailClient.Credentials = cred;
            MailMessage contact = new MailMessage();
            contact.From = new MailAddress("hrpiletisim@gmail.com"); //burası kendi maili
            contact.Subject = "İletişim Formu " + DateTime.Now;
            contact.IsBodyHtml = true;
            contact.Body = "www.hrpfurniture.de web sitesinden iletişim formu dolduruldu. <br/>";
            contact.Body += "<br/>Ad Soyad: " + form.Ad;
            contact.Body += "<br/>Email: " + form.Mail;
            contact.Body += "<br/>Konu: " + form.Konu;
            contact.Body += "<br/>Mesaj: " + form.Mesaj;
            
            mailClient.EnableSsl = true;
            contact.To.Add("mdilek3496@gmail.com"); //burası info maili
            mailClient.EnableSsl = true;
            mailClient.Send(contact);
            return RedirectToAction("Contact");

        }
    }
}