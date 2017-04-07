using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenador compBasico = new CompBasic();
            Ordenador toshiba = new Toshiba();
            
            //Mostramos los parametros basicos
            MostrarCaracteristicas(compBasico);
            MostrarCaracteristicas(toshiba);

            //mostramos los parametros mas los decoradores
            compBasico = new Impresora(compBasico);
            MostrarCaracteristicas(compBasico);

            toshiba = new Disipador(toshiba);
            MostrarCaracteristicas(toshiba);

            toshiba = new Impresora(toshiba);
            MostrarCaracteristicas(toshiba);

            Console.ReadKey();
        }

        private static void MostrarCaracteristicas(Ordenador v)
        {
            Console.WriteLine(string.Format("{0}\n\tAccesorio Incluido: {1} \n\tPrecio del producto: {2} \n",
                                            v.Descripcion(),
                                            v.Accesorio(),
                                            v.Precio()));
        }
    }
}
