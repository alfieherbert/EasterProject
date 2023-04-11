Module FileHandling
    Public Enum DataType
        Name
        Age
        Height
        Mass
        BMI
    End Enum
    Public Structure Record
        Public Name As String
        Public Age As UInt16
        Public Height As UInt16
        Public Mass As UInt16
        Public BMI As Double
    End Structure

    Public Sub AddRecord(NewRecord As Record)
        Dim InsertRecord As String
        InsertRecord = $"{NewRecord.Name},{NewRecord.Age},{NewRecord.Height},{NewRecord.Mass},{NewRecord.BMI}"
        Dim sw As New System.IO.StreamWriter("input.csv", append:=True)
        sw.WriteLine(InsertRecord)
        sw.Close()
    End Sub
    Public Function CalculateAverage(Type As DataType) As Decimal
        Dim offset As Integer
        Select Case Type
            Case DataType.Age
                offset = 1
            Case DataType.Height
                offset = 2
            Case DataType.Mass
                offset = 3
            Case DataType.BMI
                offset = 4
        End Select
        Dim line
        Dim fields()
        Dim sr As New System.IO.StreamReader("input.csv")
        Dim sum As Double
        Dim linescount As Integer
        Do Until sr.EndOfStream
            line = sr.ReadLine()
            fields = line.split(",")
            sum += fields(offset)
            linescount += 1
        Loop
        sr.Close()
        Return sum / linescount
    End Function
End Module
