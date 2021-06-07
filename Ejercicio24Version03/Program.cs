using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24Version03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el primer número:");
                var numeroUno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número:");
                var numeroDos = Convert.ToInt32(Console.ReadLine());
                var esMultiplo = VerSiEsMultiplo(numeroUno, numeroDos);
                Console.WriteLine(esMultiplo?
                    $"{numeroUno} y {numeroDos} son múltiplos":
                    $"{numeroUno} y {numeroDos} no son múltiplos");
            }
            catch (FormatException)
            {
                Console.WriteLine("Número mal ingresado");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande para ser un entero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }

        private static bool VerSiEsMultiplo(int numeroUno, int numeroDos)
        {
            if (numeroUno>numeroDos)
            {
                return numeroUno % numeroDos == 0;
            }
            return numeroDos % numeroUno == 0;
        }
    }
}
