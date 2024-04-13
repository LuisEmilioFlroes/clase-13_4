using clase_13_4.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_4.Clase_Hija
{
   
    
        internal class Nintendo : Cls_Consola
        {
            public bool EsPortatil { get; set; }

            public string MostrarDetallesNintendo()
            {
                return $"Es Portatil {EsPortatil}";
            }


        }
    }


