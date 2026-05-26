using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inicializacion acumulador y contador
            int acum = 0;
            int cont = 0;
            #endregion

            #region iterar 20 nros
            for (int n = 0; n < 20; n++)
            {
                #region 
                Console.WriteLine("ingrese un numero");
                int num=Convert.ToInt32(Console.ReadLine());
                #endregion
                #region Actualizar acumulador
                acum += n;
                #endregion
                #region Actualizar contador
                cont++;
                #endregion
            }
            #endregion
            #region Calcular Promedio
            double promedio = 1.0 * acum / cont;
            #endregion
            #region  Mostrar Promedio
            Console.WriteLine("promedio: {promedio}");
            #endregion 
            Console.WriteLine("presione cualquier tecla");
            Console.ReadKey();
        }
    }
}
