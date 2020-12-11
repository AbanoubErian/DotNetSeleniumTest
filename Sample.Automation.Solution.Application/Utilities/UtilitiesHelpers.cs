using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Logging.Utilities.Logging;
using Reporting.Utilities.Reporting;

namespace Sample.Automation.Solution.Application.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class UtilitiesHelpers
    {
        //public static void SendmailMethod(string FilesPath, string emailRecipient)
        //{
        //    string t1 = DateTime.Now.ToString("yyyy-MM-dd");
        //    string[] files = Directory.GetFiles(FilesPath + t1 + "\\", "*.html")
        //                             .Select(Path.GetFileName)
        //                             .ToArray();
        //    var fromAddress = new MailAddress(emailRecipient);
        //    var toAddress = new MailAddress(emailRecipient);
        //    const string fromPassword = "Micro$oft11";
        //    const string subject = "Sample Automation Test Run";
        //    const string body = "This mail is a report for All Completed Tests";
        //    var smtp = new SmtpClient
        //    {
        //        Host = "Smtp_in.itworx.com",
        //        Port = 25,
        //        EnableSsl = false,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
        //    };

        //    {
        //        ServicePointManager.ServerCertificateValidationCallback =
        //    delegate (
        //        object s,
        //        X509Certificate certificate,
        //        X509Chain chain,
        //        SslPolicyErrors sslPolicyErrors
        //    )
        //    {
        //        return true;
        //    };
        //        MailMessage message = new MailMessage();
        //        message.From = fromAddress;
        //        message.To.Add(toAddress);
        //        message.Subject = subject;
        //        message.Body = body;

        //        foreach (var f in files)
        //        {
        //            string t = DateTime.Now.ToString("yyyy-MM-dd");
        //            message.Attachments.Add(new Attachment(FilesPath + t + "\\" + f));
        //        }
        //        smtp.Send(message);               
        //    }
        //}
        public static void SendmailMethod(string FilesPath, string emailRecipient)
        {
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");

            var directory = new DirectoryInfo(FilesPath + todayDate + "\\");
            var file = (from f in directory.GetFiles("*.html")
                        orderby f.LastWriteTime descending
                        select f).First();
            var fromAddress = new MailAddress(emailRecipient);
            var toAddress = new MailAddress(emailRecipient);
            const string fromPassword = "Micro$oft11";
            const string subject = "Test Automation Report";
            const string body = "This mail is a report for All Completed Tests";
            var smtp = new SmtpClient
            {
                Host = "Smtp_in.itworx.com",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
            };

            {
                ServicePointManager.ServerCertificateValidationCallback =
            delegate (
                object s,
                X509Certificate certificate,
                X509Chain chain,
                SslPolicyErrors sslPolicyErrors
            )
            {
                return true;
            };
                MailMessage message = new MailMessage();
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = subject;
                message.Body = body;

                message.Attachments.Add(new Attachment(FilesPath + todayDate + "\\" + file));

                smtp.Send(message);
            }
        }
    }
}

