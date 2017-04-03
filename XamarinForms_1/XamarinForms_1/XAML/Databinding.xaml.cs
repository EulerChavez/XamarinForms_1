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

namespace XamarinForms_1.XAML {

    // 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Databinding : ContentPage {

        public Databinding() {

            InitializeComponent();

            // Primera forma

            //switch (Device.OS) {
            //    case TargetPlatform.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case TargetPlatform.Android:
            //        Padding = new Thickness(40, 20, 0, 0);
            //        break;
            //}

            // Segunda forma

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(40, 20, 0, 0),
            //    WinPhone: new Thickness(0, 0, 0, 0));

            // Tercera forma

            //Device.OnPlatform(
            //    iOS: () => { Padding = new Thickness(0, 20, 0, 0); },
            //    Android: () => { Padding = new Thickness(40, 20, 0, 0); });


        }

    }

}
