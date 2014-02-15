using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SoundBoard.Resources;
using SoundBoard.ViewModels;
using Coding4Fun.Toolkit.Controls;


namespace SoundBoard
{
    public partial class Testimonial : PhoneApplicationPage
    {
        public Testimonial()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton recordAudioAppBar =
                new ApplicationBarIconButton();
            recordAudioAppBar.IconUri =
                new Uri("/Assets/images/profile.png", UriKind.Relative);
            recordAudioAppBar.Text = AppResources.AppBarRecord;

            recordAudioAppBar.Click += RegisterClick;

            ApplicationBarMenuItem aboutAppBar =
                new ApplicationBarMenuItem();
            aboutAppBar.Text = AppResources.AppBarAbout;

            aboutAppBar.Click += AboutClick;

            ApplicationBar.Buttons.Add(recordAudioAppBar);
            ApplicationBar.MenuItems.Add(aboutAppBar);
        }


        private void AboutClick(object sender, EventArgs e)
        {
            AboutPrompt aboutMe = new AboutPrompt();

            aboutMe.Show("Channel 9", "@ch9", "ch9@microsoft.com", "http://channel9.msdn.com");
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.RelativeOrAbsolute));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
           
            string strItemIndex;
            if (NavigationContext.QueryString.TryGetValue("index", out strItemIndex))
            {
                 
                     testimonials.SelectedIndex = Convert.ToInt32(strItemIndex);
            }
            base.OnNavigatedTo(e);
        }
    }
}