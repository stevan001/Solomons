using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace ProdigyProducts.BLL.Services
{
    public class EmailService
    {
        public static void SendMail(string toAddress, string toName, string subject, string body)
        {
            var fromAddress = new MailAddress("donotreply@solomonstt.com",
                                              "Solomons Website");
            var mailTo = new MailAddress(toAddress, toName);
            var smtp = new SmtpClient
            {
                Host = "www.prodigysoft.net",
                DeliveryMethod = SmtpDeliveryMethod.Network,
                //EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials =
                    new NetworkCredential("pmail",
                                          "Service001")
            };
           // var smtp = new SmtpClient();
            smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
            using (var message = new MailMessage(fromAddress, mailTo)
            {
                Subject = subject,
                Body = body
            })
            {
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
        }


    }
}