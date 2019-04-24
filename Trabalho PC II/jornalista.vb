Public Class jornalista
    Inherits Pessoa
    Private _empregador As String
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal empregador As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date)
        MyBase.New(nome, sexo, datanascimento)
        Me.Empregador = empregador
    End Sub
#End Region
#Region "properties"
    Public Property Empregador As String
        Get
            Return _empregador
        End Get
        Set(value As String)
            _empregador = value
        End Set
    End Property
#End Region
End Class
