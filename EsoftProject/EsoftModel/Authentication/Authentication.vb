Public Class AuthenticationReq
    Public Property username As String
    Public Property password As String
    Public Property grant_type As String
End Class

Public Class AuthenticationRes
    Public Property access_token As String
    Public Property token_type As String
    Public Property expires_in As String
End Class

Public Class AuthenticationResErr
    Public Property error_description As String
End Class
