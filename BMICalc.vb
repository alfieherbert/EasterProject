Module BMICalc
    Public Function ValidateName(Name As String)
        ' Checks if any of the characters in the name are not alphabetic, and raises an exception 
        For i = 0 To Name.Length - 1
            If Not Char.IsLetter(Name.Chars(i)) Then
                Throw New System.Exception("Name should be a string")
            End If
        Next
        Return Name
    End Function
    Public Function ValidateAge(Age As String)
        Dim AgeOut = Convert.ToUInt16(Age) ' This is unsigned - no negative values are allowed
        If AgeOut > 120 Then ' Raises if the age is > 120
            Throw New System.Exception("Age cannot be > 120")
        End If
        Return AgeOut
    End Function
    Public Function ValidateHeight(Height As String)
        Dim HeightOut = Convert.ToUInt16(Height) ' Unsigned - no negative values
        If HeightOut > 300 Then
            Throw New System.Exception("Height cannot be > 300cm")
        End If
        Return HeightOut
    End Function
    Public Function ValidateMass(Mass As String)
        Dim MassOut = Convert.ToUInt16(Mass) ' Unsigned - no negative values
        If MassOut > 300 Then
            Throw New System.Exception("Mass cannot be > 300kg")
        End If
        Return MassOut
    End Function
    Public Function CalculateBMI(Height As Double, Mass As Integer) As Double
        Return (Mass) / (Height ^ 2) ' Calculates BMI with the formula BMI = Mass/Height^2
    End Function
End Module
