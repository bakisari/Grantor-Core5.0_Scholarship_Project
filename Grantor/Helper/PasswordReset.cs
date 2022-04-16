using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Grantor.Helper
{
    public static class PasswordReset
    {
        public static void PasswordResetSendEmail(string link,string email)
        {

            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("mail.besniburs.com");
            mail.From = new MailAddress("info@besniburs.com");
            mail.To.Add($"{email}");

            mail.Subject = $"Grantor.com - Şifre Sıfırlama";
            mail.Body = "<h2> Sifrenizi sıfırlamak icin baglantiya tiklayınız.</h2> <hr/>";
            mail.Body += $"Yeni sifrenizi buradaki linkten degiştirebilirsiniz. <a href='{link}'> şifre yenileme bağlantısı </a>";
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("info@besniburs.com", "AKcn04G6");
            smtpClient.Send(mail);

        }
    }
}
