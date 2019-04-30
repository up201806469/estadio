Public Class funcionariovip
    Inherits funcionario
    Private _passwordvip As String
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal id_number As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date, ByVal passwordvip As String)
        MyBase.New(passwordvip, id_number, nome, sexo, datanascimento)
    End Sub
#End Region
#Region "properties"
    Public Property Passwordvip As String
        Get
            Return _passwordvip
        End Get
        Set(value As String)
            _passwordvip = value
        End Set
    End Property
#End Region
End Class
