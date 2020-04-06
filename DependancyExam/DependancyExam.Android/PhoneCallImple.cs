using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependancyExam.Droid;
using Xamarin.Forms;


[assembly:Dependency(typeof(PhoneCallImple))]
namespace DependancyExam.Droid
{
    public class PhoneCallImple : IPhoneCall
    {
        public void PhoneCall(string phoneNumber)
        {
            var uri = Android.Net.Uri.Parse("tel:" + phoneNumber);
            Intent intent = new Intent(Intent.ActionDial, uri);
            Forms.Context.StartActivity(intent);

            //OR

            //try
            //{
            //    var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", phoneNumber));
            //    var intent = new Intent(Intent.ActionCall, URI);
            //    Xamarin.Forms.Forms.Context.StartActivity(intent);
            //}
            //catch(Exception ex)
            //{
            //    string msg = ex.Message;
            //}

            }
            

        public void sendSMS(string phoneNumber, string message)
        {
            //var smsUri = Android.Net.Uri.Parse("smsto:"+ phoneNumber);
            //var smsIntent = new Intent(Intent.ActionSendto, smsUri);
            //smsIntent.PutExtra("sms_body", message);
            //Forms.Context.StartActivity(smsIntent);



            var email = new Intent(Android.Content.Intent.ActionSend);
            email.PutExtra(Android.Content.Intent.ExtraEmail, new string[] {
            "chiranjeevi.kng@gmail.com",
            "rvk2799@gmail.com"
        });
            email.PutExtra(Android.Content.Intent.ExtraCc, new string[] {
            "kprvsantosh@gmail.com"
        });
            email.PutExtra(Android.Content.Intent.ExtraSubject, "Xamarin Test Mail");
            email.PutExtra(Android.Content.Intent.ExtraText, "This is just xamairn test emial for testing");
            email.SetType("message/rfc822");
            Forms.Context.StartActivity(email);
        }
    }
}