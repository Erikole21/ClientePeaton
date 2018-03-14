﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClientePeatonXamarin.Modelos
{
    public class LIGestionesDC
    {
        public LIGestionesDC()
        {

        }

        public long NumeroGuia { get; set; }

        public long IdGestion { get; set; }

        public string Telefono { get; set; }

        public string PersonaContesta { get; set; }

        public DateTime FechaGestion { get; set; }

        public string Observaciones { get; set; }

        public string NuevaDireccion { get; set; }

        public LIResultadoTelemercadeoDC Resultado { get; set; }


    }
}
