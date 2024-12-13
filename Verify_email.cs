using System.Net.Mail;

namespace formpage
{
    public class Verify_email
    {
        

        public string Send_email(string eposta)
        {
            try
            {
                Random random = new Random();
                int _random = random.Next(1000, 10000);
                string randomString=_random.ToString();
                MailMessage message = new MailMessage();
                message.From= new MailAddress("info.rotam1453@gmail.com"); 
                message.To.Add(eposta.ToString());
                message.Subject="doğrulama epostası";
                message.Body="dogrulama kodunuz:"+randomString;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials =new System.Net.NetworkCredential("info.rotam1453@gmail.com", "kose zxfq zezi elus");
                smtp.EnableSsl = true;
                smtp.Host ="smtp.gmail.com";
                smtp.Port =587;

                smtp.Send(message);
                return randomString;
            }
            catch
            {
                return "hata";
            } 
        }
        
    }
}
