Module Module1

    Sub Main()
        Dim indice As Int16
        Dim salaireB As Double
        Dim salaireN As Double
        Dim tauxBrut As Double
        Dim prixPoint As Double
        prixPoint = 3.25
        tauxBrut = 0.8

        Console.WriteLine("Application qui calcule le salaire brut et le salaire net d'un fonctionnaire")
        Console.WriteLine("Saisir l'indice :")
        indice = Console.ReadLine()
        salaireB = indice * prixPoint
        salaireN = salaireB * tauxBrut
        Console.WriteLine("Indice = " + Convert.ToString(indice))
        Console.WriteLine("Prix du point = " + Convert.ToString(prixPoint))
        Console.WriteLine("Taux de retenue = " + Convert.ToString((1 - tauxBrut)))
        Console.WriteLine("Salaire brut = " + Convert.ToString(salaireB))
        Console.WriteLine("Salaire net = " + Convert.ToString(salaireN))
        Console.ReadLine()

    End Sub

End Module
