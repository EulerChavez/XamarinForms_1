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

namespace XamarinForms_1.Lists {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage {

        public ListPage() {

            InitializeComponent();

            var items = new List<string> {
                "Euler",
                "Chavez",
                "Hernandez"
            };

            list.ItemsSource = items;

        }

    }

}
