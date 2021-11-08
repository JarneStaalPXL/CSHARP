using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileSendViaEmail
{
    public class Clients
    {
        //Mail Variables
        public string sendToEmail;
        public string emailBody;
        public string fileName;

        //Clients
        public string Youri = "Youri_lenferink@hotmail.com";
        public string Jarne = "jarne.staal9@gmail.com";

        //Splitting the mail for displaying reasons
        public string one;
        public string two;
        public string three;
        public string four;

 
        public void SendMail(string EmailBody, string AttachmentFile)
        {
            try
            {
                #region MailThatGetsSent
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.IsBodyHtml = true;
                mail.From = new MailAddress("ethereumchecker@gmail.com");
                mail.To.Add(sendToEmail);
                mail.Subject = $"Trading Report -- {DateTime.Now.ToString("d-MM-yyyy")}";
                //mail.Body = EmailBody;  
                mail.Body = $"{one}<br><br>{two}<br><br>{three}";
                mail.Attachments.Add(new Attachment(AttachmentFile));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ethereumchecker@gmail.com", "nu61*WK12");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                MessageBox.Show("Mail Sent!","Succesfull");

                #endregion
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }
    }
}
