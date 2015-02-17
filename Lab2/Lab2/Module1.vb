Module Module1

    Sub Main()

        Dim person1 As Person = New Person
        Dim person2 As Person = New Person

        Dim pet1 As Pet = New Pet
        Dim pet2 As Pet = New Pet
        Dim pet3 As Pet = New Pet


        person1.firstName = "Greg"
        person1.lastName = "Maguire"

        person2.firstName = "Audrey"
        person2.lastName = "Maguire"

        pet1.name = "Ollie"
        Console.WriteLine(pet1.name)
        pet1.age = 3
        Console.WriteLine(pet1.age)
        pet1.species = "Cat"
        Console.WriteLine(pet1.species)
        pet1.owner = person1
        Console.WriteLine(pet1.owner.FullName)

        pet2.name = "Snoopy"
        Console.WriteLine(pet2.name)
        pet2.age = 7
        Console.WriteLine(pet2.age)
        pet2.species = "Dog"
        Console.WriteLine(pet2.species)
        pet2.owner = person2
        Console.WriteLine(pet2.owner.FullName)

        pet3.name = "Fluffy"
        Console.WriteLine(pet3.name)
        pet3.age = 2
        Console.WriteLine(pet3.age)
        pet3.species = "Dog"
        Console.WriteLine(pet3.species)
        pet3.owner = person2
        Console.WriteLine(pet3.owner.FullName)
        Console.ReadKey()

    End Sub

End Module
