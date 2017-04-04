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

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio : ContentPage {

        private string[] mensaje = { "Mensaje 1", "Mensaje 2", "Mensaje 3", "Mensaje 4", "Mensaje 5", "Mensaje 6", "Mensaje 7" };

        private int indice = 0;

        public Ejercicio() {

            InitializeComponent();

            texto.Text = mensaje[indice];

        }

        private void Button_Clicked(object sender, EventArgs e) {

            indice++;

            if (indice >= mensaje.Length) {

                indice = 0;

            }

            texto.Text = mensaje[indice];

        }

    }

}
