using System;
using System.Collections.Generic;
using System.Text;

namespace ClientePeatonXamarin.Code
{
    public class NavegarEventArgs<T> : EventArgs
    {
        public T Parametro { get; set; }
    }
}
