Module Terminal
    Dim input As String = Nothing

    Sub Main()
        Console.WriteLine(My.Application.Info.ProductName & " v" & My.Application.Info.Version.ToString)
        Console.WriteLine("Copyleft - GNU GPL v3 or above" & vbNewLine)
        Terminal()
    End Sub

    Sub Terminal()
        Console.Write(Environment.UserName & "@" & Environment.MachineName & ">>>")
        input = Console.ReadLine()
        If input = "" Then
            Terminal()
        Else
            Try
                Shell(input)
            Catch ex As Exception
                Console.WriteLine("'" & input & "' is not a valid command.")
            End Try
        End If
        Terminal()
    End Sub
End Module
