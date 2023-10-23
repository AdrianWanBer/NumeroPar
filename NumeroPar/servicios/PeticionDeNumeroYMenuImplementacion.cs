using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPar.servicios
{
    internal class PeticionDeNumeroYImplementacion : PeticionDeNumeroYMenuInterfaz
    {
        public int menuYNumero()
        {
            Console.WriteLine("Escriba su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
