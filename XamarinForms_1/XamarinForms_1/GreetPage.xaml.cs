using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_1 {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage {

        public GreetPage() {

            InitializeComponent();

            slider.Value = 0.5;
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e) {

            label.Text = String.Format("Value is {0:F2}", e.NewValue);

        }

    }

}
