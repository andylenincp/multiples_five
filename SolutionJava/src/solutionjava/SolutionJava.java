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
            String mensaje = " ", impares = " ";
            int rango = 0, total = 0, nimpares = 0;
            do {
                System.out.println("Ingrese el rango a evaluar: ");
                rango = entrada.nextInt();
                if ((rango % 5 != 0) || (rango <= 0)) {
                    System.out.println("Rango ingresado no válido, debe ser múltiplo de cinco");
                }
            } while ((rango % 5 != 0) || (rango <= 0));
            for (int i = 5; i <= rango; i+=5) {
                if (i != rango) {
                    mensaje = mensaje + " " + i + " +";
                }
                else
                {
                    mensaje = mensaje + " " + i + " ";
                }
                if (i % 2 != 0) {
                    impares = impares + " " + i;
                    nimpares++;
                }
                total += i;
            }
            System.out.println("\n" + mensaje + " = " + total +
                    "\nTotal múltiplos de cinco impares: " + nimpares +
                    "\nLos múltiplos de cinco impares son: " + impares);
        }
        catch(Exception e) {
            System.out.println("Ingreso no válido, debe ser un número entero múltiplo de cinco");
        }
        
    }
    
}
