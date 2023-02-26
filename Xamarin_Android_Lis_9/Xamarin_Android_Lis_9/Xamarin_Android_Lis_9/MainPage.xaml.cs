using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Android_Lis_9
{
    public partial class MainPage : ContentPage
    {
        StackLayout stackLayout;
        Frame frame,frame1,frame2;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            stackLayout = new StackLayout();
            for(int i=0; i < 10;i++)
            {
                frame = new Frame()
                {
                    BorderColor = Color.Blue,
                    Content = new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Spacing = 15,
                        Children =
                    {
                        new BoxView (){Color=Color.FromRgb(i*5,i*30,i*50)},
                        new Label(){Text=$"{i} элемент", VerticalOptions=LayoutOptions.Center}
                    },
                    }
                };
                stackLayout.Children.Add(frame);
            }
            //frame1 = new Frame()
            //{
            //    BorderColor = Color.Blue,
            //    Content = new StackLayout()
            //    {
            //        Orientation = StackOrientation.Horizontal,
            //        Spacing = 15,
            //        Children =
            //        {
            //            new BoxView (){Color=Color.Purple},
            //            new Label(){Text="Второй элемент", VerticalOptions=LayoutOptions.Center}
            //        },
            //    }
            //};
            //frame2 = new Frame()
            //{
            //    BorderColor = Color.Blue,
            //    Content = new StackLayout()
            //    {
            //        Orientation = StackOrientation.Horizontal,
            //        Spacing = 15,
            //        Children =
            //        {
            //            new BoxView (){Color=Color.Green},
            //            new Label(){Text="Третий элемент", VerticalOptions=LayoutOptions.Center}
            //        },
            //    }
            //};
            stackLayout.Children.Add(frame);
            //stackLayout.Children.Add(frame1);
            //stackLayout.Children.Add(frame2);

            Content = stackLayout;
        }
    }
}
