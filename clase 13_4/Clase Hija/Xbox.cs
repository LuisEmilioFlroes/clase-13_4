using clase_13_4.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_4.Clase_Hija
{
    internal class Xbox : Cls_Consola
    {
        public bool TieneKinekt { get; set; }

        public string MostrarDetallesXbox()
        {
            return  $"Es Portatil {TieneKinekt}";
        }


    }
}
