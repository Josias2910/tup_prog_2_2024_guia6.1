using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6._1___Ej1___Patentes
{
    internal interface IProcesable
    {
        string Procesar(string patente, out string formateada);
    }
}
