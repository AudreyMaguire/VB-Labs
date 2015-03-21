Module Module1

    Sub Main()


        Console.Write("How many adults?         ")
        Dim numAdults As Integer = Console.ReadLine()
        Console.Write("How many children?       ")
        Dim numChildren As Integer = Console.ReadLine()
        Console.Write("How many seniors?        ")
        Dim numSeniors As Integer = Console.ReadLine()
        Console.Write("Is Matinee?              ")
        Dim isMatinee As Boolean = Console.ReadLine()

        Dim TicketCost As Decimal = 0.0

        TicketCost += numChildren * If(isMatinee, 3.99, 6.99)
        TicketCost += numAdults * If(isMatinee, 5.99, 10.99)
        TicketCost += numSeniors * If(isMatinee, 4.5, 8.5)

        'Food costs

        Console.WriteLine("How many small sodas?    ")
        Dim numSmallSodas As Integer = Console.ReadLine()
        Console.WriteLine("How many large sodas?    ")
        Dim numLargeSodas As Integer = Console.ReadLine()
        Console.WriteLine("How many hot dogs?       ")
        Dim numHotDogs As Integer = Console.ReadLine()
        Console.WriteLine("How many bags of popcorn?")
        Dim numPopcorn As Integer = Console.ReadLine()
        Console.WriteLine("How many candies?        ")
        Dim numCandy As Integer = Console.ReadLine()

        Dim FoodCost As Decimal = 0.0

        FoodCost += numSmallSodas * 3.5
        FoodCost += numLargeSodas * 5.99
        FoodCost += numHotDogs * 3.99
        FoodCost += numPopcorn * 4.5
        FoodCost += numCandy * 1.99

        Dim TotalCost As Decimal = 0.0

        TotalCost = TicketCost + FoodCost


        Console.WriteLine(TotalCost)


        'Discount stuff

        Dim numPeople As Integer = numAdults + numChildren + numSeniors

        If numPeople >= 3 Then
            Console.WriteLine("You recieved a free bag of popcorn!")
        End If


        Console.ReadKey()

    End Sub

End Module
