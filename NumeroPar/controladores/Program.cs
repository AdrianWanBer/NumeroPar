using NumeroPar.servicios;

namespace NumeroPar.controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            PeticionDeNumeroYMenuInterfaz objetoNumero = new PeticionDeNumeroYImplementacion();
            int numeroseleccionado = objetoNumero.menuYNumero();
            
            if ((numeroseleccionado % 2)==0)
            {
                Console.WriteLine("El numero es par");
            }else {
                Console.WriteLine("El numero es impar");
            }



        }
    }
}

