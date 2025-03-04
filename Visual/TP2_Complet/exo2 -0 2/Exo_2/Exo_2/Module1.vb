Module Module1

    Sub Main()

        Dim indice As Double
        Dim salaire_brut As Double
        Dim prix_point As Double
        Dim taux_de_retenue As Double
        prix_point = 3.25
        taux_de_retenue = 0.2

        Console.WriteLine("Calcul du salaire brut et net d'un fonctionnaire :")

        Console.Write("Veuillez saisir le nombre de points : ")
        indice = Console.ReadLine()
        salaire_brut = prix_point * indice
        Console.Write("L'indice est de : ")
        Console.WriteLine(indice)
        Console.Write("Le prix du point est de :")
        Console.WriteLine(prix_point)
        Console.Write("Le taux de retenue :")
        Console.WriteLine(taux_de_retenue)
        Console.Write("Le salaire brut est de : ")
        Console.WriteLine(salaire_brut)
        Console.Write("Le salaire net est de : ")
        Console.WriteLine(salaire_brut * (1 - taux_de_retenue))
        Console.ReadLine()



    End Sub

End Module
