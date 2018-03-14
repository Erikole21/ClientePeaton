using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace ClientePeatonXamarin.ViewModels
{
    public class SigueEnvioViewModel : MainViewModel
    {

        public SigueEnvioViewModel(string _numeroGuia, INavigation navegacion)
        {
            this.NumeroGuia = _numeroGuia;
            this.Navegacion = navegacion;
            ConsultarDatos();
        }

        private async void ConsultarDatos()
        {
            if (!string.IsNullOrWhiteSpace(NumeroGuia))
            {
                using (IProgressDialog progress = UserDialogs.Instance.Loading("Consultando..", null, null, true, MaskType.Black))
                {
                    Modelos.ADRastreoGuiaDC rastroGuia = await Services.SigueEnvioService.Instancia.ObtenerRastreoGuia(NumeroGuia.Trim());
                    if (rastroGuia != null)
                        AsignarDatos(rastroGuia);
                    else
                    {
                        await Navegacion.PushAsync(new MainPage());
                        UserDialogs.Instance.Toast("El Número De Guía No Existe.", TimeSpan.FromMilliseconds(Services.Configuracion.TiempoMensaje));
                    }
                }
            }
        }

        private void AsignarDatos(Modelos.ADRastreoGuiaDC rastroGuia)
        {
            var estadoGuia = rastroGuia.EstadosGuia.LastOrDefault();
            if (estadoGuia != null)
            {
                EstadoGuia = estadoGuia.EstadoGuia.DescripcionEstadoGuia;
                FechaEstado = estadoGuia.EstadoGuia.FechaGrabacion.ToString("dd / MM / yyyy");
                Motivo = estadoGuia.Motivo?.Descripcion;
            }

            if (rastroGuia.Telemercadeo?.Count > 0)
            {

            }
        }

        private string estadoGuia;

        public string EstadoGuia
        {
            get { return estadoGuia; }
            set
            {
                estadoGuia = value;
                OnPropertyChanged("EstadoGuia");
            }
        }

        private string fechaEstado;

        public string FechaEstado
        {
            get { return fechaEstado; }
            set
            {
                fechaEstado = value;
                OnPropertyChanged("FechaEstado");
            }
        }

        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set
            {
                motivo = value;
                OnPropertyChanged("Motivo");
            }
        }


    }
}
