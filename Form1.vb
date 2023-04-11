Public Class Form1
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim InputRecord As Record
        Try
            InputRecord.Name = ValidateName(NameBox.Text)
        Catch
            MsgBox("The name should only contain alphabetical characters", MsgBoxStyle.Information)
            Exit Sub
        End Try
        Try
            InputRecord.Age = ValidateAge(AgeBox.Text)
        Catch ex As Exception
            MsgBox("You must enter an age between 0 and 120")
            Exit Sub
        End Try
        Try
            InputRecord.Height = ValidateHeight(HeightBox.Text)
        Catch ex As Exception
            MsgBox("Your height must be between 0 and 300cm")
        End Try
        Try
            InputRecord.Mass = ValidateMass(MassBox.Text)
        Catch ex As Exception
            MsgBox("You must enter a mass between 0 and 300kg")
            Exit Sub
        End Try

        Try
            InputRecord.BMI = CalculateBMI(InputRecord.Height / 100, InputRecord.Mass)
        Catch ex As Exception
            MsgBox("Mass cannot be 0")
            Exit Sub
        End Try
        MsgBox($"Your BMI is {InputRecord.BMI}")
        AddRecord(InputRecord)
        Dim AverageAge, AverageHeight, AverageWeight, AverageBMI
        AverageAge = CalculateAverage(DataType.Age)
        AverageHeight = CalculateAverage(DataType.Height)
        AverageWeight = CalculateAverage(DataType.Mass)
        AverageBMI = CalculateAverage(DataType.BMI)
        MsgBox($"Average age: {AverageAge}, average height: {AverageHeight}, average mass: {AverageWeight}, average BMI: {AverageBMI}")
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

    End Sub
End Class


