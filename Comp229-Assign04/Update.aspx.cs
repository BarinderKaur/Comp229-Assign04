using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class Update : System.Web.UI.Page
    {
        public static void EmailJsonFile(string clientEmailAddress, string clientName, string attachmentFileName)
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
                MailAddress toAddress = new MailAddress(clientEmailAddress, clientName);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Comp229-Assign04 email";
                message.Body = "This is the body of a sample message";

                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.EnableSsl = true;

               
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");

                System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
                contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
                contentType.Name = attachmentFileName;
                message.Attachments.Add(new Attachment(System.Web.Hosting.HostingEnvironment.MapPath(ModelsNewJsonFilePath), contentType));

                smtpClient.Send(message);
                //statusLabel.Text = "Email sent.";
            }
            catch (Exception ex)
            {
                //statusLabel.Text = "Coudn't send the message!";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}