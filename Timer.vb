Imports System.Timers

Module Timer
    Dim blink As Boolean = False

    Sub Main()

        Dim t As New Timers.Timer
        AddHandler t.Elapsed, AddressOf tick
        t.Interval = 1000
        t.Start()

        While True
        End While

    End Sub

    Private Sub tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)

        If blink Then
            Console.ForegroundColor = ConsoleColor.Cyan
            blink = False
        Else
            Console.ForegroundColor = ConsoleColor.DarkRed
            blink = True
        End If

        Console.Clear()
        Console.WriteLine("[ ]")

    End Sub

End Module
