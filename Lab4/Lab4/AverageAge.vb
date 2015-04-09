Public Class AverageAge

    Private SumOfAllAges As Integer
    Private TotalNumberOfPeople As Integer

    Public Sub AddPerson(p As Person)
        TotalNumberOfPeople = TotalNumberOfPeople + 1
        SumOfAllAges = SumOfAllAges + p.Age
        If p.Spouse IsNot Nothing Then
            TotalNumberOfPeople = TotalNumberOfPeople + 1
            SumOfAllAges = SumOfAllAges + p.Spouse.Age
        End If
    End Sub
    Public Function GetAverageAge() As Decimal
        Return SumOfAllAges / TotalNumberOfPeople
    End Function
End Class