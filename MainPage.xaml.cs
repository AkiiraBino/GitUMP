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
using System.Diagnostics;

namespace GitUMP
{
    public sealed partial class MainPage : Page
    {
        //TODO: Тут код основной страницы.Внимательно его смотрите.
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
            // Условие которое при нажатие на кнопку открывает у вас меню
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(News));
        }

        private void CollectivsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Collectivs));
        }
        private void PhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Photo));
        }
        private void VideoButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Video));
        }
    }
}
