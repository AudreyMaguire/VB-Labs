Public Class Person

    Public Age As Integer
    Public FirstName As String
    Public LastName As String
    Public Spouse As Person

    Public Shared Function create(prefix As String) As Person
        Question.SetPromptPrefix(prefix)

        Dim person As Person = New Person
        person.FirstName = Question.AskForString("First Name")
        person.LastName = Question.AskForString("Last Name")
        person.Age = Question.AskForString("Age")

        If (Question.AskForBoolean("Married?")) Then
            person.Spouse = New Person
            person.Spouse.FirstName = Question.AskForString("First Name")
            person.Spouse.Age = Question.AskForString("Age")
            person.Spouse.LastName = person.LastName
            person.Spouse.Spouse = person
        End If


        Return person


    End Function
End Class