Module FileHandling
    Public Structure Record
        Public Name As String
        Public Age As UInt16
        Public Height As UInt16
        Public Mass As UInt16
        Public BMI As Double
    End Structure

    Public Sub AddRecord(NewRecord As Record)
        Dim sr As New System.IO.StreamReader("input.csv")
        Dim sw As New System.IO.StreamWriter("newinput.csv")

    End Sub
End Module
