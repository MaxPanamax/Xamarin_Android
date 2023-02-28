using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Xamarin_aandroid_11_Video
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //WebView webView;
        //StackLayout stackLayout;
        //Button button;
        //Uri uri;
        //protected override void OnAppearing()
        //{
        //    webView = new WebView()
        //    {
        //        //Source= "https://www.youtube.com/embed/gZKQAlSpOyQ",
        //        Source = "https://dzen.ru/video/watch/63c54365b2b430123911a253?share_to=link",
        //        WidthRequest = 360,
        //        HeightRequest = 240,
        //        MinimumHeightRequest = 240,
        //        MinimumWidthRequest = 360
        //    };
        //    button = new Button();
        //    button.Text = "Открыть ссылку";
        //    button.Clicked += Button_Clicked;
        //    stackLayout = new StackLayout();
        //    //{
        //    //    Children=
        //    //    {
        //    //        webView,
        //    //        button
        //    //    }
               
        //    //};
        //    stackLayout.Children.Add(webView);
        //    stackLayout.Children.Add(button);
        //    Content=stackLayout;
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://dzen.ru/video/watch/63ce73e3f3903a6deec048c0?share_to=link");
            await Browser.OpenAsync(uri);
        }
    }
}
