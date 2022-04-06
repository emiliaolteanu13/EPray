using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace EPray.Services
{
    public class EmailSender
    {
        private readonly string _apiKey = null;
        public EmailSender(string apiKey)
        {
            _apiKey = apiKey;
        }
        public async Task Execute(string reciever)
        {
            
            var client = new SendGridClient(_apiKey);

            var from = new EmailAddress("alin10nastasa@gmail.com", "Epray"); // this is my mail (alin), the api key is set with it so leave this as it is
            var subject = "Somebody is praying for you!";

            var to = new EmailAddress(reciever, "Example User"); // here is the resciever of the main, i dont know what exaple use does
            var plainTextContent = "YEAH"; // for some reason this doesnt apear in the email at all, but i dont want to ruin it and i will leave it here
            var htmlContent = "<strong><h2>Come to the Father, O Wanderer come, <br/>Somebody’s praying for you; <br/>Turn from the sin-paths no longer to roam,<br/>Somebody’s praying for you.<br/>Somebody loves you wherever you stray,<br/>Bears you in faith to God day after day;<br/>Pray’rfully follows you all the dark way,<br/>Somebody’s praying for you, for you.</h2></strong><br/> <br/> <h3>Hello Lamb whereever you are, have faith, somebody prays for you!<br/><br/>If you want you can visit <a href=\" https://localhost:44334/ \"> Our Site</a> and pray for someone.<br/>Or you can <a href=\"https://www.greenpeace.org/international/act/donate/\">donate</a> to us and help spread the word of god, any god</h3>"; 
            // this is the actual content of the mail, written like html we can add products and everything we need

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

        }
    }
    /// i dont know in which folder this should stay but its ok
    ///             EmailSender.Execute();
    /// copy this where you need to call the function, 
    /// the "var to" should take the mail from the form, or user DB when it will be ready
}
