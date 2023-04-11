Module FileHandling
    ' Enum with a variant for each field, used to make calculating averages cleaner
    Public Enum DataType
        Name
        Age
        Height
        Mass
        BMI
    End Enum
    ' Structure to hold a record
    Public Structure Record
        Public Name As String
        Public Age As UInt16
        Public Height As UInt16
        Public Mass As UInt16
        Public BMI As Double
    End Structure
    ' Appends a record to the input.csv file
    Public Sub AddRecord(NewRecord As Record)
        Dim InsertRecord As String
        InsertRecord = $"{NewRecord.Name},{NewRecord.Age},{NewRecord.Height},{NewRecord.Mass},{NewRecord.BMI}"
        Dim sw As New System.IO.StreamWriter("input.csv", append:=True)
        sw.WriteLine(InsertRecord)
        sw.Close()
    End Sub

    ' Searches the input.csv file for records matching the Name and Age given
    Public Function Search(Name As String, Age As String) As List(Of String)
        Dim sr As New System.IO.StreamReader("input.csv")
        Dim line
        Dim record()
        Dim found As New List(Of String)
        Do Until sr.EndOfStream
            line = sr.ReadLine()
            record = line.split(",")
            If record(0) = Name And record(1) = Age Then
                found.Add(line)
            End If
        Loop
        sr.Close()
        Return found
    End Function
End Module
