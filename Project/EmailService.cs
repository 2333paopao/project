using System.Net.Mail;
using System.Text;

namespace Project
{
    public class EmailService : IEmailService
    {
        public void Send(string fromEmailAddress, string fromDisplayName, string toEmailAdress, string subject, string body)
        {
            var from = new MailAddress(fromEmailAddress, fromDisplayName, Encoding.UTF8);
            var to = new MailAddress(toEmailAdress);

            using (var mailMessage = new MailMessage(from, to)
            {
                Subject = subject,
                Body = body,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            })
            {
                using (var client = new SmtpClient())
                {
                    if (client.DeliveryMethod == SmtpDeliveryMethod.SpecifiedPickupDirectory)
                    {
                        if (!System.IO.Directory.Exists(client.PickupDirectoryLocation))
                        {
                            System.IO.Directory.CreateDirectory(client.PickupDirectoryLocation);
                        }
                    }
                    client.Send(mailMessage);
                }
            }
        }
    }
}
