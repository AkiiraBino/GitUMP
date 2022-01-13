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
    public sealed partial class News : Page
    {
        public News()
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
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
