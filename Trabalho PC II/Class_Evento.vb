Public Class Class_Evento
    Private _nome_evento As String
    Private _organizador As String
    Private _custo_aluguer As Single
    Private _tipo As String
    Private _data As Date

    Public Sub New()

    End Sub
    Public Sub New(nome As String, organizador As String, custo As Single, data As Date, tipo As String)
        _nome_evento = nome
        _organizador = organizador
        _custo_aluguer = custo
        _tipo = tipo
        Verifica(data)
        _data = data
    End Sub

#Region "Properties"
    Public ReadOnly Property Nome_evento As String
        Get
            Return _nome_evento
        End Get
    End Property

    Public ReadOnly Property Organizador As String
        Get
            Return _organizador
        End Get
    End Property

    Public Property Custo_aluguer As Single
        Get
            Return _custo_aluguer
        End Get
        Set(value As Single)
            _custo_aluguer = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property
#End Region

    Public Function Verifica(ByRef data)
        'acabar o sub de verificar disponibilidade
    End Function
End Class
