using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyExam
{
   public interface IPhoneCall
    {
        void PhoneCall(string phoneNumber);

        void sendSMS(string phoneNumber, string message);
    }
}
