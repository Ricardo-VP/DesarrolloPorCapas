using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variables
            double saldo;
            string nombre, fecha;
            int numeroMes;

            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            Console.WriteLine("Ingresa los siguientes valores:");
            Console.WriteLine();

            //Llenando Variables
            Console.Write("Saldo inicial: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Numero del mes: ");
            numeroMes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fecha: ");
            fecha = Console.ReadLine();

            //Aplicando funciones
            Console.WriteLine();
            Console.WriteLine("Resultado sueldo: {0}", conta.getSaldos(saldo));
            Console.WriteLine(conta.Saludos(nombre));
            Console.WriteLine(CapaLogica.Utilidades.getNombreDelMes(numeroMes));
            Console.WriteLine(CapaLogica.Utilidades.Fecha(fecha));

            Console.ReadKey();
        }
    }
}
