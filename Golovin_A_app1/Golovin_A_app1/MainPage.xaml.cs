using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Golovin_A_app1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            button1.Text = "Нажато";
        }
    }
}
