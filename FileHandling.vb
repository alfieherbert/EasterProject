Module FileHandling
    Public Structure Record
        Public Name As String
        Public Age As UInt16
        Public Height As UInt16
        Public Mass As UInt16
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
        If Convert.ToUInt16(Age) > 120 Then
            Throw New System.Exception("Age cannot be > 120")
        End If
    End Sub
    Public Sub AddRecord(NewRecord As Record)
        ' TODO
    End Sub
End Module
