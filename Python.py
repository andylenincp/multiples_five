print("")
print("Desarrolle un programa que determine cuáles son los múltiplos de 5 comprendidos entre 1 y N (Considere que N debe ser múltiplo de 5), la solución debe mostrar la sumatoria de dichos múltiplos. Adicionalmente, el programa deberá indicar cuántos y cuáles de los números múltiplos de 5 en el rango evaluado son impares.")
print("")

while True:

	#Declaramos e inicializamos las variables a utilizar
	mensaje = " "
	impares = " "
	rango = 0
	nimpares = 0
	total = 0

	#Solicitamos al usuario el ingreso del rango a evaluar
	rango = input("Ingrese el rango a evaluar: ")
	try:
		rango = int(rango)

		#Si el rango ingresado no es múltiplo de cinco o es menor o igual a cero
		#mostramos por pantalla un ingreso no válido
		if rango % 5 != 0 or rango <= 0:
			print("Rango ingresado no válido, debe ser múltiplo de cinco")

		#Caso contrario creamos el bucle for que realizará el recorrido mientras la variable inicializada sea menor al rango,
		#ésta tendrá un incremento de cinco cada que haga una iteración.
		else:
			for i in range(5, rango+1, 5):

				#Si la variable del bucle es diferente al rango se almacenará en la variable mensaje el resultado
				#concatenando la cadena de la iteración
				if i != rango:
					mensaje = mensaje + " " + str(i) + " +"

				#Caso contrario se concatena la última cadena y este será nuestro resultado o mensaje
				else:
					mensaje = mensaje + " " + str(i) + " "
				
				#Si el módulo de dividir por dos a la variable i es diferente de cero sabremos que es un número impar,
				#por lo tanto lo almacenamos en una cadena y aumentamos el contador de impares
				if i % 2 != 0:
					impares = impares + " " + str(i)
					nimpares = nimpares + 1
				
				#Así mismo, en cada iteración vamos sumando el valor de la variable i para saber el total de los números
				#múltiplos de cinco en el rango evaluado.
				total += i
	
			#Finalmente mostramos pon pantalla todos los datos solicitados.
			print(mensaje + " = " + str(total))
			print("Total múltiplos de cinco impares: " + str(nimpares))
			print("Los múltiplos de cinco impares son: " + str(impares))
			
	except ValueError:
		print("Ha ocurrido un error, intente nuevamente.")
			