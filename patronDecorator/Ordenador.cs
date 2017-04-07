using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronDecorator
{
            public abstract class Ordenador
        {
            // Atributo común a todos los objetos que heredarán de esta clase
            protected string descripcion = "Ordenador genérico";

            // Método no abstracto que devolverá el contenido de la descripción
            // Se declara como virtual para que pueda sustituirse en las clases derivadas
            public virtual string Descripcion()
            {
                return descripcion;
            }

            // Métodos abstractos
            public abstract string Accesorio();
            public abstract int Precio();
        }

    public class CompBasic : Ordenador
    {
        public CompBasic()
        {
            descripcion = "Computador Basico";
        }

        // Funcionalidad básica
        public override string Accesorio()
        {
             return "Mouse";
        }

        // Funcionalidad básica
        public override int Precio()
        {
            return 4500;
        }
    }

    public class Toshiba : Ordenador
    {
        public Toshiba()
        {
            descripcion = "Toshiba C-40";
        }

        public override string Accesorio()
        {
            return "Bocinas";
        }

        public override int Precio()
        {
            return 7000;
        }
    }

    public abstract class Decorator : Ordenador
    {
        // Declaramos el método como abstracto para que todos los decoradores lo
        // reimplementen.
        public override abstract string Descripcion();
    }
   public class Impresora : Decorator
    {
        // Instancia de la clase ordenador
        private Ordenador computador;

        // Constructor que recibe el ordenador que encapsulará el decorator
        public Impresora(Ordenador computador)
        {
            this.computador = computador;
        }

        // Los métodos utilizan la información del objeto encapsulado y le
        // incorporan su propia funcionalidad.
        public override string Descripcion()
        {
            return computador.Descripcion() + " Impresora";
        }
        
        public override string Accesorio()
        {
            return computador.Accesorio() + " + Tinta";
        }

        public override int Precio()
        {
            return computador.Precio() + 500;
        }
    }

    public class Disipador : Decorator
    {
        
        private Ordenador computador;

        
        public Disipador(Ordenador computador)
        {
            this.computador = computador;
        }

        public override string Descripcion()
        {
            return computador.Descripcion() + " Disipador";
        }

        public override string Accesorio()
        {
            return computador.Accesorio() + " + bateria";
        }

        public override int Precio()
        {
            return computador.Precio() + 200;
        }
    }
}
