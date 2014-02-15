using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Threading;

namespace SoundBoard
{
    public partial class splashscreen : PhoneApplicationPage
    {
        private Popup popup;
        private BackgroundWorker backroungWorker;
        public splashscreen()
        {
            InitializeComponent();
            ShowSplash();
        }

        private void StartLoadingData()
        {
            backroungWorker = new BackgroundWorker();
            backroungWorker.DoWork += new DoWorkEventHandler(backroungWorker_DoWork);
            backroungWorker.RunWorkerCompleted +=
          new RunWorkerCompletedEventHandler(backroungWorker_RunWorkerCompleted);
            backroungWorker.RunWorkerAsync();
        }
        void backroungWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }
        void backroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml?index=", UriKind.RelativeOrAbsolute));
            });
        }

        private void ShowSplash()
        {
            this.popup = new Popup();
          //  this.popup.Child = new SplashScreenControl();
            this.popup.IsOpen = true;
            StartLoadingData();
        }
    }
}