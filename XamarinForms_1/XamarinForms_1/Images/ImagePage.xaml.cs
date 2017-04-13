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
    public partial class ImagePage : ContentPage {

        public ImagePage() {

            InitializeComponent();

            // var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

            var imageSource = new UriImageSource() { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };

            // Su valor por default es: true
            imageSource.CachingEnabled = false;

            // En caso de contar con cache, se asiga un tiempo de vida (¿?)
            imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;

        }

    }

}
