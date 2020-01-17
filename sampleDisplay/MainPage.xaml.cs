using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sampleDisplay {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible (false)]
    public partial class MainPage : ContentPage {
        public MainPage () {
            InitializeComponent ();
        }

        void GoFave (object sender, EventArgs e) {
            Device.BeginInvokeOnMainThread (() => {
                Application.Current.MainPage.DisplayAlert ("Warning", "DisplayAlert reached", "OK");
            });
        }
    }
}