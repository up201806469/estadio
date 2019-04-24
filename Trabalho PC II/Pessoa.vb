Public Class Pessoa
    Private _nome As String
    Private _sexo As String
    Private _datanascimento As Date
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date)
        Me.Nome = nome
        Me.Sexo = sexo
        Me.Datanascimento = datanascimento
    End Sub
#End Region
#Region "properties"
    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Property Datanascimento As Date
        Get
            Return _datanascimento
        End Get
        Set(value As Date)
            _datanascimento = value
        End Set
    End Property
#End Region



End Class
