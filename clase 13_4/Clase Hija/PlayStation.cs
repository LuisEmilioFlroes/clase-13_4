using clase_13_4.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_4.Clase_Hija
{
    internal class PlayStation : Cls_Consola
    {
        public string ModeloControlador { get; set; }

        public string MostrarDetallesPS()
        {

            MostrarDetalles();
            return $"Modelo de Controlador: {ModeloControlador}";

        }
    }
}
