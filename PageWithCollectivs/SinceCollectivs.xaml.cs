using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace GitUMP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class SinceCollectivs : Page
    {
        public SinceCollectivs()
        {
            this.InitializeComponent();
        }

        private void ButtonCreation_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DanceCollectivs));
        }

        private void ButtonSince_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SinceCollectivs));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void PhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Photo));
        }
        private void VideoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Video));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ButtonInfoRSO_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoRSO));
        }

        private void ButtonInfoCV_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoCV));
        }

        private void ButtonInfoDigital_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoDigital));
        }

        private void ButtonInfoStatus_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoStatus));
        }

        private void ButtonInfoNSO_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoNSO));
        }

        private void ButtonInfoSSK_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoSSK));
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(News));
        }

        private void ButtonInfoSSO_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoSSO));
        }

        private void ButtonInfoMTTS_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoMTTS));
        }

        private void CollectivsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Collectivs));
        }

        private void ButtonInfoDebate_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoDebate));
        }

        private void ButtonInfoSSAG_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InfoLSEPPI));
        }

        private void ButtonCommunyti_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CommunityCollectivs));
        }
        private void ButtonSport_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SportCollectivs));
        }
    }

}
