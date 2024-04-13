using clase_13_4.Clase_Base;
using clase_13_4.Clase_Hija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Xbox sw = new Xbox();

            sw.EsPortatil = true;
            sw.Añolanzamiento = 2017;
            sw.Marca = "Xbox 360";

            string resultado = sw.MostrarDetallesXbox();
            Console.WriteLine(resultado);


        }
    }
}
