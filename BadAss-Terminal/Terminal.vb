Module Terminal
    Dim input As String = Nothing

    Sub Main()
        'Print thios text to the console on startup of the application
        Console.WriteLine(My.Application.Info.ProductName & " v" & My.Application.Info.Version.ToString)
        Console.WriteLine("Copyleft - GNU GPL v3 or above" & vbNewLine)
        'Start the forever looping terminal
        Terminal()
    End Sub

    Sub Terminal()
        Console.Write(Environment.UserName & "@" & Environment.MachineName & ">>>")
        input = Console.ReadLine()
        If input = "" Then
            Terminal()
        ElseIf input = "exit" Then
            'Exit the application when the user types 'exit' and hits enter
            End
        ElseIf input = "clear" Then
            'Clear the console screen when the user types 'clear' and hits enter
            Console.Clear()
        ElseIf input = "bat -about" Then
            'Displays about information when the user types 'bat -about' and hits enter
            Misc.About()
        ElseIf input = "bat -help" Then
            'Displays help information when the user types 'bat -help' and hits enter
            Misc.Help()
        ElseIf input = "bat -updates" Then
            'Displays update information when the user types 'bat -updates' and hits enter
            Misc.CheckForUpdates()
        Else
            Try
                Shell(input)
            Catch ex As Exception
                Console.WriteLine("'" & input & "' is not a valid command.")
            End Try
        End If
        'Loop the terminal
        Terminal()
    End Sub
End Module
