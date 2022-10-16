using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bai5._3.Models;
using System.Net.Mime;
using System.Web.Services.Description;
using System.IO;
using System.Web.UI.WebControls;

namespace Bai5._3.Controllers
{
    public class SendMailWithAttController : Controller
    {
        // GET: SendMailWithAtt
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
                mail.Body = model.Note;
                mail.IsBodyHtml = true;

                // Lấy thông tin từ input type = size
                var fAtt = Request.Files["myAttachment"];

                // Save hinh về server
                var pathAtt = Server.MapPath("~/Attachment/" + fAtt.FileName);
                fAtt.SaveAs(pathAtt);

                Attachment data = new Attachment(
                         "~/Attachment/" + fAtt.FileName,
                         MediaTypeNames.Application.Octet);
                mail.Attachments.Add(data);

                // Can set to false, if you are sending pure text.
                using (SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(model.From, "amoqkqczfjexcizd");
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }

            return RedirectToAction("Index", "SendMailWithAtt");

        }
    }
}