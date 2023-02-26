using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_android_Lis_10
{
    public partial class MainPage : ContentPage
    {
        StackLayout stacklayout;
       // Frame frame;
        
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            BackgroundColor = Color.Pink;
            stacklayout = new StackLayout()
            {
                BackgroundColor=Color.Yellow,
                Margin=new Thickness(5,10,15,5),
                Padding=new Thickness(15),
                Children=
                {
                    new BoxView(){BackgroundColor=Color.Violet,VerticalOptions=LayoutOptions.FillAndExpand},
                    new BoxView(){BackgroundColor=Color.LimeGreen, Margin=new Thickness(0,40,0,0),VerticalOptions=LayoutOptions.FillAndExpand},
                }
            };
            Content = stacklayout;
        }
    }
}
