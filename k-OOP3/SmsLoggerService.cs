using System;
using System.Collections.Generic;
using System.Text;

namespace k_OOP3
{
    class SmsLoggerService : ILoggerService
    {       
        public void Log()
        {
            Console.WriteLine("Sms gönderildi ve loglandı");
        }
    }
}
