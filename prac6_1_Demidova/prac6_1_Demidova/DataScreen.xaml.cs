using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac6_1_Demidova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataScreen : ContentPage
    {
        public DataScreen(string selectedPickerItem)
        {
            InitializeComponent();
            PickerSelected.Text = $"Вы выбрали {selectedPickerItem}";
        }
    }
}