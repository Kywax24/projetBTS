Module Calculatrice

	Sub Main()
		Dim nombre1 As Int16
		Dim nombre2 As Int16

		Console.WriteLine("Voici ma première calculatrice géniale ")

		Console.Write("Premier nombre = ")
		nombre1 = Console.ReadLine()

		Console.Write("Deuxième nombre = ")
		nombre2 = Console.ReadLine()


		Console.Write("Le résultat est ")
		Console.Write(nombre1 + nombre2)

		Console.ReadLine()
	End Sub

End Module