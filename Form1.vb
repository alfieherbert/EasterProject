Public Class Form1
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim InputRecord As Record
        Try
            ValidateName(NameBox.Text)
            InputRecord.Name = NameBox.Text
        Catch
            MsgBox("The name should only contain alphabetical characters", MsgBoxStyle.Information)
            Exit Sub
        End Try
        Try
            ValidateAge(AgeBox.Text)
            InputRecord.Age = Convert.ToUInt16(AgeBox.Text)
        Catch ex As Exception
            MsgBox("You must enter an age between 0 and 120")
            Exit Sub
        End Try
        Try
            ValidateHeight(HeightBox.Text)
            InputRecord.Height = Convert.ToUInt16(HeightBox.Text) / 100
        Catch ex As Exception
            MsgBox("Your height must be between 0 and 300cm")
        End Try
        Try
            ValidateMass(MassBox.Text)
            InputRecord.Mass = Convert.ToUInt16(MassBox.Text)
        Catch ex As Exception
            MsgBox("You must enter a mass between 0 and 300kg")
            Exit Sub
        End Try

        Try
            InputRecord.BMI = CalculateBMI(InputRecord.Height, InputRecord.Mass)
        Catch ex As Exception
            MsgBox("Mass cannot be 0")
            Exit Sub
        End Try
    End Sub
End Class


