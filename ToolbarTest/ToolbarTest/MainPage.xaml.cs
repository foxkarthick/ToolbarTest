using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToolbarTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Menu1Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Menu Clicked For Testing", "", "Okay");
        }
    }
}
