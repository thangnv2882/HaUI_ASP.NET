using Bai5._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Bai5._2.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailInfo model)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(model.From);
                mail.To.Add(model.To);
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                mail.IsBodyHtml = true;

                // Can set to false, if you are sending pure text.
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(model.From, model.Password);
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }

            return RedirectToAction("Index", "Mail");

        }
    }
}