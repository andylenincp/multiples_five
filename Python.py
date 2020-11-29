print("")
print("Desarrolle un programa que determine cuáles son los múltiplos de 5 comprendidos entre 1 y N (Considere que N debe ser múltiplo de 5), la solución debe mostrar la sumatoria de dichos múltiplos. Adicionalmente, el programa deberá indicar cuántos y cuáles de los números múltiplos de 5 en el rango evaluado son impares.")
print("")

while True:
	mensaje = " "
	impares = " "
	rango = 0
	nimpares = 0
	total = 0
	rango = input("Ingrese el rango a evaluar: ")
	try:
		rango = int(rango)
		if rango % 5 != 0 or rango <= 0:
			print("Rango ingresado no válido, debe ser múltiplo de cinco")
		else:
			for i in range(5, rango+1, 5):
				if i != rango:
					mensaje = mensaje + " " + str(i) + " +"
				else:
					mensaje = mensaje + " " + str(i) + " "
				if i % 2 != 0:
					impares = impares + " " + str(i)
					nimpares = nimpares + 1
				total += i
	
			print(mensaje + " = " + str(total))
			print("Total múltiplos de cinco impares: " + str(nimpares))
			print("Los múltiplos de cinco impares son: " + str(impares))
			
	except ValueError:
		print("Ingreso no válido, debe ser un número entero múltiplo de cinco")
			