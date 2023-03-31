Module BMICalc
    Public Function ValidateName(Name As String)
        For i = 0 To Name.Length - 1
            If Not Char.IsLetter(Name.Chars(i)) Then
                Throw New System.Exception("Name should be a string")
            End If
        Next
        Return Name
    End Function
    Public Function ValidateAge(Age As String)
        Dim AgeOut = Convert.ToUInt16(Age)
        If AgeOut > 120 Then
            Throw New System.Exception("Age cannot be > 120")
        End If
        Return AgeOut
    End Function
    Public Function ValidateHeight(Height As String)
        Dim HeightOut = Convert.ToUInt16(Height)
        If HeightOut > 300 Then
            Throw New System.Exception("Height cannot be > 300cm")
        End If
        Return HeightOut / 100
    End Function
    Public Function ValidateMass(Mass As String)
        Dim MassOut = Convert.ToUInt16(Mass)
        If MassOut > 300 Then
            Throw New System.Exception("Mass cannot be > 300kg")
        End If
        Return MassOut
    End Function
    Public Function CalculateBMI(Height As Integer, Mass As Integer) As Double
        Return (Mass) / (Height ^ 2)
    End Function
End Module
