using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SendViaEmail
    {
        private String emailAddr;

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void sendEmail(string msg)
        {
            Console.WriteLine("The message" + "\"" + msg + "\" has already sent to " + emailAddr);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;


        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
