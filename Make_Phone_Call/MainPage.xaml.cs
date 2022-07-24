using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Make_Phone_Call
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MakeCall(object sender, EventArgs e)
        {
            DependencyService.Get<IMakeCall>().DialCall(txtNumber.Text.ToString());
        }
    }
}
