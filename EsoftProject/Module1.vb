Imports Newtonsoft.Json

Module Module1

    Sub Main()
        Dim _Commands As New Commands
        Dim _InvokeEsoftService As New InvokeEsoftService



        Console.WriteLine("Send to Service? type Y or N")
        Dim UserInput As String = Console.ReadLine()
        If UserInput.ToLower = "n" Then
            Console.WriteLine("Service has now ended")
        Else
            'add service function
            'Post Inv Acc
            '_InvokeEsoftService.RunAsync(_Commands.PostInvoiceAcc).GetAwaiter().GetResult()
            'Post Inv journal
            '_InvokeEsoftService.RunAsync(_Commands.PostInvoiceJournal).GetAwaiter().GetResult()
        End If
        Console.ReadLine()
    End Sub

End Module
