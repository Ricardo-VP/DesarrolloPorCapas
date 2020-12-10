using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
   public class Utilidades
    {
        public static string getNombreDelMes(int mes)
        {
            string aux = "";
            switch (mes)
            {
                case 1:
                    aux = "Enero";
                    break;               
                case 2:
                    aux = "Febrero";
                    break;
                case 3:
                    aux = "Marzo";
                    break;
                case 4:
                    aux = "Abril";
                    break;
                case 5:
                    aux = "Mayo";
                    break;
                case 6:
                    aux = "Junio";
                    break;
                case 7:
                    aux = "Julio";
                    break;
                case 8:
                    aux = "Agosto";
                    break;
                case 9:
                    aux = "Septiembre";
                    break;
                case 10:
                    aux = "Octubre";
                    break;
                case 11:
                    aux = "Noviembre";
                    break;
                case 12:
                    aux = "Diciembre";
                    break;
                default:
                    aux = "";
                    break;
            }// Fin switch
            return aux;
        }
    }
}
