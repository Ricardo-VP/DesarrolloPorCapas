using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
    public class Contabilidad
    {
        public double getSaldos(double saldoInicial)
        {
            double aux = saldoInicial + 1000 + saldoInicial * 0.1;
            return aux;
        }

        public string Saludos(string nombre = "Juan Pérez") // Parámetros opcionales
        {
            return "Hola " + nombre + ", bienvenido al sistema de contabilidad!";
        }
    }
}
