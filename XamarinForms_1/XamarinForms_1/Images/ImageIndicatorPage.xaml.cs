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
    public partial class ImageIndicatorPage : ContentPage {

        public ImageIndicatorPage() {

            InitializeComponent();

            var imageSource = new UriImageSource() { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;

            image.Source = imageSource;

        }

    }

}
