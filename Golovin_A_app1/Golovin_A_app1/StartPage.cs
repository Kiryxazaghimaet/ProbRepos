using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Golovin_A_app1
{
     class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label()
            {
                Text = "Привет из Xamarin F!orms"
            };
            this.Content = header;
        }
    }
}
