Module Arrays

    Sub Main()
        Simplearray()
    End Sub
    Sub Simplearray()

        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"

        Console.WriteLine("hello " & names(3))

        Console.Read()

    End Sub

End Module
