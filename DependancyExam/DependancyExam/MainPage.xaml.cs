using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependancyExam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnPhoneCall.Clicked += BtnPhoneCall_Clicked;
            btnSendSMS.Clicked += BtnSendSMS_Clicked;
        }

        private void BtnSendSMS_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IPhoneCall>().sendSMS(etMobileNumber.Text, etMessage.Text);
        }

        private void BtnPhoneCall_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IPhoneCall>().PhoneCall(etMobileNumber.Text);
        }
    }
}
