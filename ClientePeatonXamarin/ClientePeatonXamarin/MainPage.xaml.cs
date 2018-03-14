using ClientePeatonXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientePeatonXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InicializarEnlaces();
        }

        private void InicializarEnlaces()
        {
            MainViewModel vm = this.BindingContext as MainViewModel;
            vm.Navegacion = Navigation;         
            TapGestureRecognizer tapImage = new TapGestureRecognizer();
            tapImage.Tapped += (sender, e) =>
            {
                vm.Buscar();
            };
            buscar.GestureRecognizers.Add(tapImage);
            TapGestureRecognizer tapImageCodigo = new TapGestureRecognizer();
            tapImageCodigo.Tapped += (sender, e) =>
            {
                vm.LeerCodigoBarras();
            };
            codigoBarras.GestureRecognizers.Add(tapImageCodigo);
        }        
    }
}
