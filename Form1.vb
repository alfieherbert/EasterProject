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
        Catch ex As Exception
            MsgBox("You must enter an age between 0 and 120")
            Exit Sub
        End Try

    End Sub
End Class


