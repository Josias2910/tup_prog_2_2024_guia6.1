using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia6._1___Ej1___Patentes
{
    internal class RegexProcesableImpl : IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            formateada = "";
            Match m = null;           
            m = Regex.Match(patente, @"[A-Z]{3}\s?\d{3}$", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                formateada = m.Value.Replace(" ", "");
                return $"Automoviles y Camionetas hasta 2016 - Regex";
            }          
            m = Regex.Match(patente, @"[A-Z]{2}\s?\d{3}\s?[A-Z]{2}$", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                formateada = m.Value.Replace(" ","");
                return $"Automoviles y Camionetas desde 2016 - Regex";
            }            
            m = Regex.Match(patente, @"[A-Z]{2}\s?\d{3}\s?[A-Z]{3}$", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                formateada = m.Value.Replace(" ", "");
                return $"Motocicletas - Regex";
            }            
            m = Regex.Match(patente, @"[A-Z]{2}\s?\d{4}$", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                formateada = m.Value.Replace(" ", "");
                return $"Acoplado - Regex";
            }
            return formateada;
        }
    }
}
