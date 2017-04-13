using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_1.Images {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImagePage : ContentPage {

        public EmbeddedImagePage() {

            InitializeComponent();

            // image.Source = ImageSource.FromResource("XamarinForms_1.Images.background.jpg");

        }

    }

}
