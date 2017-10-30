using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotvvmCoffeeTemplate.Services
{
    public class EmailAlreadySubscribedException : Exception { }

    public class SubscribtionService
    {
        private static Dictionary<string, DateTime> emails = new Dictionary<string, DateTime>();

        public void Subscribe(string emailAddress)
        {
            if (!emails.ContainsKey(emailAddress))
            {
                emails.Add(emailAddress, DateTime.Now);
            }
            else
            {
                throw new EmailAlreadySubscribedException();
            }
        }
    }
}