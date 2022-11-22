using Microsoft.Toolkit.Uwp.Notifications;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApp16
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SendToast_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("Adaptive Tiles Meeting", hintMaxLines: 1)
                .AddText("Conf Room 2001 / Building 135")
                .AddText("10:00 AM - 10:30 AM")
                .Show();
        }

        private void SendSecondToast_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("This is a image")
                .AddInlineImage(new Uri("https://picsum.photos/360/202?image=1043"))
                .Show();
        }

        private void SendThirdToast_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("This is a image")
                .AddAppLogoOverride(new Uri("https://picsum.photos/360/202?image=1043"))
                .Show();
        }

        private void SendForthToast_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("This is a image")
                .AddAppLogoOverride(new Uri("https://picsum.photos/48?image=883"), ToastGenericAppLogoCrop.Circle)
                .Show();
        }
    }
}
