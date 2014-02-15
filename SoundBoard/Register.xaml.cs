using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Quickteller.Sdk.Wp8;

namespace SoundBoard
{
    public partial class Register : PhoneApplicationPage
    {

        private const string CLIENT_ID = "XXXXXXXXXXXXXXXXXX";
        private const string CLIENT_SECRET = "XXXXXXXXXXXXXXXXX";
        public Register()
        {
            InitializeComponent();
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnTechQuest_Click(object sender, RoutedEventArgs e)
        {
            PerformPaymentOperation(3000);
        }

        private void PerformPaymentOperation(long amount)
        {
            var quicktellerPayment = new QuicktellerPayment(this, "10402", amount, "0000000001", CLIENT_ID, CLIENT_SECRET);

            quicktellerPayment.OnPaymentCompleted += (e) =>
            {
                //where e is a type of PaymentCompletedEventArgs
                NavigationService.Navigate(new Uri("/PaymentSuccessful.xaml", UriKind.Relative));
            };
            quicktellerPayment.OnPaymentException += (e) =>
            {
                //where e is a type of PaymentExceptionEventArgs
                NavigationService.Navigate(new Uri("/PaymentFailed.xaml?error=" + e.PaymentException.Message, UriKind.Relative));
            };

            quicktellerPayment.DoPayment();
        }
    }
}