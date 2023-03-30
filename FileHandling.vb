Module FileHandling
    Public Structure Record
        Public Name As String
        Public Age As Integer
        Public Height As Integer
        Public Mass As Integer
        Public BMI As Double
    End Structure
    Public Sub ValidateName(Name As String)
        For i = 0 To Name.Length - 1
            If Not Char.IsLetter(Name.Chars(i)) Then
                Throw New System.Exception("Name should be a string")
            End If
        Next
    End Sub
    Public Sub ValidateAge(Age As String)

    End Sub
    Public Sub AddRecord(NewRecord As Record)
        ' TODO
    End Sub
End Module
