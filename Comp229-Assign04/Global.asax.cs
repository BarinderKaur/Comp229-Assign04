using System.IO;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Net.Mail;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;


namespace Comp229_Assign04
{
    public class Global : HttpApplication
    {
        public static IEnumerable<Models.Model> Models;
        public const string ModelsJsonFilePath = "~/Data/Assign04.json";
        private const string ModelsNewJsonFilePath = "~/Data/NewAssign04.json";
        private static Object statusLabel;


        public static object Model { get; internal set; }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void prepareModelCollection()
        {
            using (System.IO.StreamReader streamReader = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(ModelsJsonFilePath)))
            {
                var jsonString = streamReader.ReadToEnd();
                Models = JsonConvert.DeserializeObject<List<Models.Model>>(jsonString);

            }
        }
        public void UpdateNewJsonFile()
        {
            using (StreamWriter StreamWriter = File.CreateText(System.Web.Hosting.HostingEnvironment.MapPath(ModelsJsonFilePath)))
            {
                StreamWriter.WriteLine(JsonConvert.SerializeObject(Models));
            }
        }

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

                // SET UseDefaultCredentials to false BEFORE setting Credentials - we all have 'ugh' moments
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");

                System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
                contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
                contentType.Name = attachmentFileName;
                message.Attachments.Add(new Attachment(System.Web.Hosting.HostingEnvironment.MapPath(ModelsNewJsonFilePath), contentType));

                smtpClient.Send(message);
                // statusLabel.Text = "Email sent.";
            }


            catch (Exception ex)
            {
                
            statusLabel.Text = "Coudn't send the message!";
               }
            }
        }
    }

