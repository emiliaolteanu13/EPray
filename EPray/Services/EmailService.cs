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
        public static async Task Execute(string reciever)
        {
            /// used to send mails but for privacy reason this part of the code had to be deleted
            /// in orderd for the repo to be public
        }
    }
    /// i dont know in which folder this should stay but its ok
    ///             EmailSender.Execute();
    /// copy this where you need to call the function, 
    /// the "var to" should take the mail from the form, or user DB when it will be ready
}
