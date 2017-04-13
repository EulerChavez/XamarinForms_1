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

namespace XamarinForms_1.Images {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformSpecificImages : ContentPage {

        public PlatformSpecificImages() {

            InitializeComponent();


            //btn.Image = new FileImageSource() { File = "clock.png" };

            // Sobreescribir la convencion

            //btn.Image = (FileImageSource) ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clok.png",
            //    WinPhone: "images/clock.png"
            //));



        }

    }

}
