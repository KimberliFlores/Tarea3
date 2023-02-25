using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Entidades;

namespace Tarea3.Negocio
{
    public class Numeros
    {
        public void ImprimirPares(Numero Numeros)
        {

            for (int i = Numeros.NumeroMinimo; i < Numeros.NumeroMaximo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                } 

    }
}
