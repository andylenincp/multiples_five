/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package solutionjava;

import java.util.Scanner;

/**
 *
 * @author andyc
 */
public class SolutionJava {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("Desarrolle un programa que determine cuáles son los "
                + "múltiplos de 5 comprendidos entre 1 y N (Considere que N debe "
                + "ser múltiplo de 5), la solución debe mostrar la sumatoria de dichos múltiplos. "
                + "Adicionalmente, el programa deberá indicar cuántos y cuáles de los números "
                + "múltiplos de 5 en el rango evaluado son impares.");
        Scanner entrada = new Scanner(System.in);
        try {
            /*
            Declaramos e inicializamos las variables a utilizar
            */
            String mensaje = " ", impares = " ";
            int rango = 0, total = 0, nimpares = 0;
            do {
                /*
                Solicitamos al usuario el ingreso del rango a evaluar
                */
                System.out.println("Ingrese el rango a evaluar: ");
                rango = entrada.nextInt();
                /*
                Si el rango ingresado no es múltiplo de cinco o es menor o igual a cero
                mostramos por pantalla un ingreso no válido.
                */
                if ((rango % 5 != 0) || (rango <= 0)) {
                    System.out.println("Rango ingresado no válido, debe ser múltiplo de cinco");
                }
            } while ((rango % 5 != 0) || (rango <= 0));
            /*
            Este proceso se repetirá mientras el ingreso no sea múltiplo de cinco o menor o igual a cero.
            A continuación creamos el bucle for que realizará el recorrido mientras la variable inicializada sea menor al rango,
            ésta tendrá un incremento de cinco cada que haga una iteración.
            */
            for (int i = 5; i <= rango; i+=5) {
                if (i != rango) {
                    /*
                    Si la variable del bucle es diferente al rango se almacenará en la variable mensaje el resultado
                    concatenando la cadena de la iteración.
                    */
                    mensaje = mensaje + " " + i + " +";
                }
                else
                {
                    /*
                    Caso contrario se concatena la última cadena y este será nuestro resultado o mensaje
                    */
                    mensaje = mensaje + " " + i + " ";
                }
                if (i % 2 != 0) {
                    /*
                    Si el módulo de dividir por dos a la variable i es diferente a cero sabremos que es un número impar,
                    por lo tanto lo almacenamos en una cadena y aumentamos el contador de impares.
                    */
                    impares = impares + " " + i;
                    nimpares++;
                }
                /*
                Así mismo, en cada iteración vamos sumando el valor de la variable i para saber el total de los números
                múltiplos de cinco en el rango evaluado.
                */
                total += i;
            }
            /*
            Finalmente mostramos por pantalla todos los datos solicitados.
            */
            System.out.println("\n" + mensaje + " = " + total +
                    "\nTotal múltiplos de cinco impares: " + nimpares +
                    "\nLos múltiplos de cinco impares son: " + impares);
        }
        catch(Exception e) {
            System.out.println("Ha ocurrido un error, intente nuevamente.");
        }
        
    }
    
}
