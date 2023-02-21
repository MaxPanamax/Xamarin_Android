using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Android_Lis_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            checkBox1.IsChecked=true;
        }
        //protected override void OnAppearing()
        //{
        //   StackLayout layout=new StackLayout();
        //    Label label=new Label();
        //    label.Text = "Урок 4";
        //    label.TextColor = Color.Cyan;
        //    label.FontSize = 20;
        //    label.FontAttributes=FontAttributes.Bold;
        //    label.HorizontalOptions = LayoutOptions.Center;  

        //    Entry input=new Entry();
        //    input.Placeholder = "Пароль";
        //    input.IsPassword=true;
        //    Entry input1 = new Entry()
        //    {
        //        IsEnabled = false,
        //        Text = "*Макс что-то напсал*"
        //    };
        //    Label sub = new Label() { Text = "Подписатся", FontSize = 25, FontAttributes = FontAttributes.Bold };
        //    StackLayout horizontalStack = new StackLayout();
        //    horizontalStack.Orientation = StackOrientation.Horizontal;
        //    CheckBox checkBox = new CheckBox() { IsChecked = true };

        //    horizontalStack.Children.Add(sub);
        //    horizontalStack.Children.Add(checkBox);

        //    layout.Children.Add(label);
        //    layout.Children.Add(input);
        //    layout.Children.Add(input1);
        //    layout.Children.Add(horizontalStack);
        //    Content = layout;
        //}
    }
}
