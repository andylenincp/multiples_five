using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desarrolle un programa que determine cuáles son los múltiplos de 5 comprendidos entre 1 y N " +
                "(Considere que N debe ser múltiplo de 5), la solución debe mostrar la sumatoria de dichos múltiplos. " +
                "Adicionalmente, el programa deberá indicar cuántos y cuáles de los números múltiplos de 5 en el " +
                "rango evaluado son impares.\n");
            int valida = 0;
            do
            {
                try
                {
                    /*
                     * Declaramos e inicializamos las variables a utilizar
                     */
                    string mensaje = " ", impares = " ";
                    int rango = 0, total = 0, nimpares = 0;
                    do
                    {
                        /*
                         * Solicitamos al usuario el ingreso del rango a evaluar
                         */
                        Console.WriteLine("Ingrese el rango a evaluar: ");
                        rango = Int32.Parse(Console.ReadLine());
                        /*
                         * Si el rango ingresado no es múltiplo de cinco o es menor o igual a cero
                         * mostramos por pantalla un ingreso no válido
                         */
                        if ((rango % 5 != 0) || (rango <= 0))
                        {
                            Console.WriteLine("\nRango ingresado no válido, debe ser múltiplo de cinco");
                        }
                    } while ((rango % 5 != 0) || (rango <= 0));
                    /*
                     * Este proceso se repetirá mientras el ingreso no sea múltiplo de cinco o menor o igual a cero.
                     * A continuación creamos el bucle for que realizará el recorrido mientras la variable inicializada sea menor al rango,
                     * éste tendrá un incremento de 5 cada que haga una iteración.
                     */
                    for (int i = 5; i <= rango; i += 5)
                    {
                        if (i != rango)
                        {
                            /*
                             * Si la variable del bucle es diferente al rango se almacenará en la variable mensaje el resultado
                             * concatenando la cadena de la iteración.
                             */
                            mensaje = mensaje + " " + i + " +";
                        }
                        else
                        {
                            /*
                             * Caso contrario se concatena la última cadena y este será nuestro resultado o mensaje
                             */
                            mensaje = mensaje + " " + i + " ";
                        }

                        if (i % 2 != 0)
                        {
                            /*
                             * Si el módulo de dividir por dos a la variable i es diferente a cero sabemos que es un número impar,
                             * por lo tanto lo almacenamos en una cadena y aumentamos el contador de impares,
                             */
                            impares = impares + " " + i;
                            nimpares++;
                        }
                        /*
                         * Así mismo, en cada iteración vamos sumando el valor de la variable i para saber el total de los números
                         * múltiplos de cinco en el rango evaluado.
                         */
                        total += i;
                    }
                    /*
                     * Finalmente mostramos por pantalla todos los datos solicitados.
                     */
                    Console.WriteLine("\n" + mensaje + " = " + total +
                        "\n\nTotal múltiplos de cinco impares: " + nimpares +
                        "\n\nLos múltiplos de cinco impares son: " + impares);
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    valida = 1;
                    Console.WriteLine("\nIngreso no válido, debe ser un número entero múltiplo de cinco");
                }
            } while (valida == 1);
        }
    }
}
