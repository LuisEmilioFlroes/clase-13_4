using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_4.Clase_Base
{
    internal class Cls_Consola
    {

        public string Marca { get; set; }
        public int Añolanzamiento { get ; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca }, año lanzamiento: {Añolanzamiento}");
        }



}
}
