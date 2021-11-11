using Android.Widget;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZebraBarcodeScannerSDK;


namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        private TextView statusView = null;
        private TextView dataView = null;

        Scanner scanner = null;

        public AboutPage()
        {
            InitializeComponent();
        }
    }
}