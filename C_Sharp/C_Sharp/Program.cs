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
            Console.WriteLine("Desarrolle un programa que determine cuáles son los múltiplos de 5 comprendidos " +
                "entre 1 y N (Considere que N debe ser múltiplo de 5). El programa deberá indicar cuántos y cuáles" +
                " de los números múltiplos de 5 en el rango evaluado son impares.\n");
            int valida = 0;
            do
            {
                try
                {
                    string mensaje = " ", impares = " ";
                    int rango = 0, total = 0, nimpares = 0;
                    do
                    {
                        Console.WriteLine("Ingrese el rango a evaluar: ");
                        rango = Int32.Parse(Console.ReadLine());
                        if ((rango % 5 != 0) || (rango <= 0))
                        {
                            Console.WriteLine("\nRango ingresado no válido, debe ser múltiplo de cinco");
                        }
                    } while ((rango % 5 != 0) || (rango <= 0));
                    for (int i = 5; i <= rango; i += 5)
                    {
                        if (i != rango)
                        {
                            mensaje = mensaje + " " + i + " +";
                        }
                        else
                        {
                            mensaje = mensaje + " " + i + " ";
                        }

                        if (i % 2 != 0)
                        {
                            impares = impares + " " + i;
                            nimpares++;
                        }
                        total += i;
                    }
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
