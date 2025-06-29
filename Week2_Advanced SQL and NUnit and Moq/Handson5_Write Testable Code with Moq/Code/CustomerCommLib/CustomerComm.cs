using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm
    {
        private IMailSender _mailSender;
    
    public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string message = "Hi, I am Uttaran. This is a sample test mail";
            string toAddress = "cust123@abc.com";

            _mailSender.SendMail(toAddress, message);
            return true;
        }
    }
}
