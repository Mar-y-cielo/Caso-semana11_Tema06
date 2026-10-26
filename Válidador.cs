using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_semana11_Tema06
{
    internal class Válidador
    {
        public static int LeerEntero(string mensaje)
        {
            int valor;
            while (true) 
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor < 0 || valor > 20)
                    {
                        Console.WriteLine("ERROR: El valor es entre [0-20]");
                        continue;
                    }
                    return valor;
                }
                Console.WriteLine("ERROR: El valor debe ser numerico entero)");
            }
        }  
        public static double LeerDecimal(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if(double.TryParse(Console.ReadLine(),out valor))
                {
                    if(valor<0 || valor > 20)
                    {
                        Console.WriteLine("ERROR: Lanota es entre [0-20]");
                        continue;
                    }
                    return valor;
                }
                Console.WriteLine("ERROR: El valor debe ser numerico decimal");
            }
        }
        public static string LeerTexto(String mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string texto = Console.ReadLine()?.Trim();
                if(!string.IsNullOrEmpty(texto))
                    return texto;
                Console.WriteLine("ERROR: Este campo no puede ser vacio...!!!");
            }
        }
    }
}
