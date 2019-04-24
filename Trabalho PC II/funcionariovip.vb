Public Class funcionariovip
    Inherits funcionario
    Private _password As String
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal id_number As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date, ByVal password As String)
        MyBase.New(id_number, nome, sexo, datanascimento)
        Me.Password = password
    End Sub
#End Region
#Region "properties"
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
#End Region
End Class
