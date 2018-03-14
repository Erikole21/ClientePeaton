using System;
using System.Collections.Generic;
using System.Text;

namespace ClientePeatonXamarin.Modelos
{
    public class ONNovedadesTransporteDC
    {
        public ONNovedadesTransporteDC()
        {

        }

        public long IdManifiestoOperacionNacio { get; set; }

        public string NombreNovedad { get; set; }

        public string LugarIncidente { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaNovedad { get; set; }

        public string Tiempo { get; set; }

        public DateTime FechaEstimadaEntrega { get; set; }
    }
}
