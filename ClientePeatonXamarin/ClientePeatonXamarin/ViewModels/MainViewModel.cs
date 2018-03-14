using ClientePeatonXamarin.Code;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClientePeatonXamarin.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {

        }

        public void Buscar()
        {
            if (!string.IsNullOrEmpty(numeroGuia))
            {
                Navegacion.PushAsync(new Views.SigueEnvioPage(new SigueEnvioViewModel(numeroGuia, Navegacion)));
            }
        }

        public async void LeerCodigoBarras()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            if (scanner != null)
            {
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    NumeroGuia = result;
                    Buscar();
                }
            }
        }

        private string numeroGuia;

        public string NumeroGuia
        {
            get { return numeroGuia; }
            set
            {
                numeroGuia = value;
                OnPropertyChanged("NumeroGuia");
            }
        }


    }
}
