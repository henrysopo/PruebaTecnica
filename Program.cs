using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionPunto17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int resultDivision = Division(a, b);
            //Muestra por consola el valor que devolvio la función
            Console.Write(a + " dividido " + b + " = " + resultDivision);
            Console.ReadKey();
        }

        //Función que recibe 2 enteros y devuelve el resultado de la división entre ellos
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
