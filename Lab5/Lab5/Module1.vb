Module Module1

    Sub Main()

        Dim Question As Boolean
        Dim visualBasic As Course = New Course()

        Do While Question = False

            Console.WriteLine("Course Name:")
            visualBasic.Name = Console.ReadLine()
            Console.WriteLine("Course ID:")
            visualBasic.ID = Console.ReadLine()
            Console.WriteLine("Number of students:")
            ReDim visualBasic.Students(Console.ReadLine() - 1)

            For i = 0 To visualBasic.Students.Length - 1
                Console.WriteLine(i)
                visualBasic.Students(i) = New Student()
                Console.WriteLine("Student Name:")
                visualBasic.Students(i).Name = Console.ReadLine()
                Console.WriteLine("Student ID:")
                visualBasic.Students(i).ID = Console.ReadLine()
            Next

            Console.WriteLine("Is everything correct? (True or False)")
            Question = Console.ReadLine



        Loop


        Console.ReadKey()
    End Sub

End Module
