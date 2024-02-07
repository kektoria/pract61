using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace prac6_1_Demidova
{
    public partial class MainPage : CarouselPage
    {
        private Xamarin.Forms.Picker Picker;
        public MainPage(string login, string password)
        {
            InitializeComponent();
            Login.Text = login;
            Password.Text = password;

        }

        private void switch1_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == true)
            {
                OnOff1.Text = "ON";
            }
            else
                OnOff1.Text = "OFF";
        }

        private void switch2_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch2.IsToggled == true)
            {
                OnOff2.Text = "ON";
            }
            else
                OnOff2.Text = "OFF";
        }

        private void switch3_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch3.IsToggled == true)
            {
                OnOff3.Text = "✓";
            }
            else
                OnOff3.Text = "✕";
        }

        private void switch4_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch4.IsToggled == true)
            {
                OnOff4.Text = "✓";
            }
            else
                OnOff4.Text = "✕";
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ItemPicker = MyPicker.SelectedItem as string;
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            string itemPicker = MyPicker.SelectedItem as string;
            DataScreen page = new DataScreen(itemPicker);
            Navigation.PushAsync(page);
        }
    }
}
