using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Grantor.Helper
{
    public static class EmailConfirmation
    {
        public static void SendEmail(string link, string email)
        {

            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("mail.besniburs.com");
            mail.From = new MailAddress("info@besniburs.com");
            mail.To.Add(email);

            mail.Subject = $"Grantor.com - Lütfen E-Postanızı Onaylayın";
            mail.Body = "<h2> E-Posta Onaylama Formu</h2> <hr/>";
           
            mail.Body += $"Değerli kullanıcımız, sistemimizden eksiksiz bir şekilde yararlanabilmek için E-posta adresini onaylamanız gerekmektedir. E-posta adresinizi onaylamak için <a href='{link}'> buraya tıklayın </a>";
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("info@besniburs.com", "AKcn04G6");
            smtpClient.Send(mail);

        }
    }
}
