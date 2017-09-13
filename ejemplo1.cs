//Costo sueldo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            //Para hacer entrada de datos por teclado se necesita una variable tipo string
            string linea;
            //Se utiliza el objeto console para mostrar mensajes en pantalla
            Console.Write("Ingrese Horas trabajadas por el operario:");
            //Al momento de ingresar por teclado datos se usa la funcion readline del objeto console
            linea = Console.ReadLine();
            //Se copia el contenido de la variable linea en otra de tipo int o float
            //Utilizando la funcion Parse del objeto int
            horasTrabajadas = int.Parse(linea);
            Console.Write("Ingrese el pago por hora:");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            //Operacion realizada
            sueldo = horasTrabajadas * costoHora;
            Console.Write("El sueldo total del operario es:");
            Console.Write(sueldo);
            Console.ReadKey();
        }
    }
}