Public Class Form1

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        MsgBox(e.GetType.ToString)
    End Sub
End Class


