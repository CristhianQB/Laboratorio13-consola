using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio13_consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.encuesta();
                        break;
                    case 2:
                        opcion = Pantallas.ordenarDatos();
                        break;
                    case 3:
                        opcion = Pantallas.elimininarDatos();
                        break;
                    
                }
            } while (opcion != 4);

        }
    }
}

