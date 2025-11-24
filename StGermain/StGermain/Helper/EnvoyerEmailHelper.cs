using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace StGermain.Helper
{
    public static class EnvoyerEmailHelper
    {
        public static Task EnvoyerEmailMailerSend(string fromEmail, string name, string corps)
        {
            using (var smtpClient = new SmtpClient("smtp.mailersend.net"))
            {
                try
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("MS_ky7DIN@test-xkjn41m17oq4z781.mlsender.net", "mssp.uffeTrC.neqvygm3ex8l0p7w.ZVEOaU3");
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;

                    var body = $"Nom : {name} \n\n Email : {fromEmail}\n\n Message : \n\n {corps}";

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("MS_ky7DIN@test-xkjn41m17oq4z781.mlsender.net"),
                        Subject = $"Message de Mr/Mme {name}",
                        Body = body,
                        IsBodyHtml = false,
                    };
                    mailMessage.To.Add("francistek@yahoo.fr");

                    smtpClient.Send(mailMessage);
                }
                catch (SmtpException smtpEx)
                {
                    // Handle SMTP-specific exceptions
                    throw new Exception("Erreur SMTP: " + smtpEx.Message);
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    throw new Exception("Erreur lors de l'envoi de l'email: " + ex.Message);
                }
            }

            return Task.CompletedTask;
        }
    }
}
