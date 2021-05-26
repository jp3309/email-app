using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

namespace EmailClassLibrary
{
    public class Email
    {
        

        public void SendEmail(string sender, string recipient, string subject, string messageBody)
        {
            var log = new LogFile();
            var email = new MailMessage();
            
            email.To.Add(recipient);
            email.From = new MailAddress(sender);
            email.Subject = subject;
            email.Body = messageBody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["MailUser"], ConfigurationManager.AppSettings["MailPW"])
            };

            try
            {
                smtp.Send(email);
                log.WriteLogFile(sender, recipient, subject, messageBody, "Sent Successfully");
                MessageBox.Show("Email Sent Successfully");
                
                
                
            }
            catch (SmtpFailedRecipientException ex)
            {
                for ( int i = 0; i <= 3; i++ ){
                    
                    System.Threading.Thread.Sleep(3000);
                    smtp.Send(email);
                }

                MessageBox.Show(ex.Message);
                log.WriteLogFile(sender, recipient, subject, messageBody, "Failed to send");
            }




        }
    }
}
