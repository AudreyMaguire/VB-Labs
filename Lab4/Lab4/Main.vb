Module Main

    Sub Main()

        Dim averageAge As AverageAge = New AverageAge()
        averageAge.AddPerson(Person.Create("Person #1"))
        averageAge.AddPerson(Person.Create("Person #2"))
        averageAge.AddPerson(Person.Create("Person #3"))
        Console.WriteLine("Average Age: " + averageAge.GetAverageAge())

    End Sub

End Module