using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_HW_8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Content = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    //new Label { Text = "Основной цвет",Margin=new Thickness(10,10,10,10) },
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },

                    //new Label { Text = "Смешанные цвета",Margin=new Thickness(0, 30, 0, 10) },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple },
                    new BoxView { Color = Color.Green }
                },
                Spacing = 15
            };
        }
    }
}
