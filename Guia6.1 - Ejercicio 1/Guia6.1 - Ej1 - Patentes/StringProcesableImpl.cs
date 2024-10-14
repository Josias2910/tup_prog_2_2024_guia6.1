using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Guia6._1___Ej1___Patentes
{
    internal class StringProcesableImpl : IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            string patenteNormalizada = patente.Replace(" ", "");
            formateada = null;

            if (patenteNormalizada.Length == 6) 
            {
                bool hasta2016 = true;
                for (int i = 0; i < patenteNormalizada.Length; i++)
                {
                    if (i < 3)
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            hasta2016 = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsNumber(patenteNormalizada[i]))
                        {
                            hasta2016 = false;
                            break;
                        }
                    }
                }
                if (hasta2016)
                {
                    formateada = patenteNormalizada;
                    return $"Automoviles y Camionetas hasta 2016 - String";
                }
            }

            if (patenteNormalizada.Length == 7)
            {
                bool desde2016 = true;
                for (int i = 0; i < patenteNormalizada.Length; i++)
                {
                    if (i < 2)
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            desde2016 = false;
                            break;
                        }
                    }
                    else if (i < 5)
                    {
                        if (!char.IsNumber(patenteNormalizada[i]))
                        {
                            desde2016 = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            desde2016 = false;
                            break;
                        }
                    }
                }
                if (desde2016)
                {
                    formateada = patenteNormalizada;
                    return "Automoviles y Camionetas desde 2016 - String";
                }              
            }

            if (patenteNormalizada.Length == 8)
            {
                bool motocicleta = true;
                for (int i = 0; i < patenteNormalizada.Length; ++i)
                {
                    if (i < 2)
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            motocicleta = false;
                            break;
                        }
                    }
                    else if (i < 5)
                    {
                        if (!char.IsNumber(patenteNormalizada[i]))
                        {
                            motocicleta = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            motocicleta = false;
                            break;
                        }
                    }
                }
                if (motocicleta)
                {
                    formateada = patenteNormalizada;
                    return $"Motocicletas = String";
                }
            }

            if (patenteNormalizada.Length == 6)
            {
                bool acoplado = true;
                for (int i = 0; i < patenteNormalizada.Length; i++)
                {
                    if (i < 2)
                    {
                        if (!char.IsLetter(patenteNormalizada[i]))
                        {
                            acoplado = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsNumber(patenteNormalizada[i]))
                        {
                            acoplado = false;
                            break;
                        }
                    }
                }
                if (acoplado)
                {
                    formateada = patenteNormalizada;
                    return $"Acoplado - String";
                }
            }

            if (patenteNormalizada.Length != 6 && patenteNormalizada.Length != 8 && patenteNormalizada.Length != 7)
            {
                return $"No Reconocido";
            }
            return formateada;
        }
    }
}
