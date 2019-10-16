Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json

Public Class InvokeEsoftService
    Dim client As HttpClient = New HttpClient()
    Dim token As String = ""
    'Function for Token

    Public Async Function RunAsync(ByVal Command As String) As Task
        Try
            '1. First Phase of Run async service is to get token
            Dim AuthRes As New AuthenticationRes
            'Get token!!
            AuthRes = Await GetToken()
            If AuthRes.access_token = "" Then
                'Not authenticated
            Else
                token = AuthRes.access_token
            End If

            Await PostAccServiceAsync(Command)
            Await PostJournalServiceAsync(Command)

        Catch ex As Exception
            Dim a = ex.Message
        End Try
    End Function

    Private Async Function GetToken() As Task(Of AuthenticationRes)

        'URL where token will be retrieve. Remember 192.168.10.9 is where esofwebapi is installed
        client.BaseAddress = New Uri("http://192.168.10.9:12000/EsoftwebAPI/api/token")
        client.DefaultRequestHeaders.Accept.Clear()

        Dim res As AuthenticationRes = New AuthenticationRes()
        Dim username As String = "TestUserMoeb"
        Dim password As String = "testPassMoeb"

        'Posting to the URL with its parameters (username, password, grant_type) in order to receive TOKEN!
        Dim response As HttpResponseMessage = Await client.PostAsync(client.BaseAddress, New StringContent(String.Format("grant_type=password&username={0}&password={1}", HttpUtility.UrlEncode(username),
        HttpUtility.UrlEncode(password)), Encoding.UTF8, "application/x-www-form-urlencoded"))

        If response.IsSuccessStatusCode Then
            'Reading response in regards to AuthenticationRes properties.
            res = Await response.Content.ReadAsAsync(Of AuthenticationRes)()
        End If

        Return res
    End Function

    'Post Account -- that can be invoice acc / expense account / anything account
    Private Async Function PostAccServiceAsync(ByVal PostAcc As String) As Task(Of MsgControl)
        client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("bearer", token)
        Dim Res As New MsgControl

        Dim response As HttpResponseMessage = Await client.PostAsync("http://192.168.10.9:12000/EsoftwebAPI/api/AccAccounts", New StringContent(PostAcc, Encoding.UTF8, "application/json"))
        If response.IsSuccessStatusCode Then
            'Reading response in regards to account properties.
            Res = Await response.Content.ReadAsAsync(Of MsgControl)()
        End If
        Return Res
    End Function

    'Post Journal -- that can be invoice Journal   / expense journal / anything journal
    Private Async Function PostJournalServiceAsync(ByVal PostJournal As String) As Task(Of MsgControl)
        client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("bearer", token)
        Dim Res As New MsgControl

        Dim response As HttpResponseMessage = Await client.PostAsync("http://192.168.10.9:12000/EsoftwebAPI/api/AccTrans", New StringContent(PostJournal, Encoding.UTF8, "application/json"))
        If response.IsSuccessStatusCode Then
            'Reading response in regards to account properties.
            Res = Await response.Content.ReadAsAsync(Of MsgControl)()
        End If
        Return Res
    End Function

End Class
