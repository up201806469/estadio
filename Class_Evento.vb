Imports Trabalho_PC_II

Public Class Class_Evento
    Private _nome_evento As String
    Private _organizador As String
    Private _custo_aluguer As Single
    Private _tipo As String
    Private _data As Date
    Private _dias As Collection_dia

    Public Sub New()

    End Sub
    Public Sub New(nome As String, organizador As String, data As Integer, custo As Single, tipo As String)
        _nome_evento = nome
        _organizador = organizador
        _tipo = tipo
        If tipo = "solidario" Then
            If custo > 1500 Then
                'mensagem a dizer que o custo é elevado
            End If
        Else
            _custo_aluguer = custo
        End If

        Dias(data).marcar()


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

    Public Property Dias As Collection_dia
        Get
            Return _dias
        End Get
        Set(value As Collection_dia)
            _dias = value
        End Set
    End Property
#End Region

    Public Function Verifica(ByRef data) As ArrayList
        Dim vetor As New ArrayList

        For a = 1 To 365
            If Dias(a).Ocupado = False Then
                vetor.Add(a)
            End If
        Next
        'depois vamos ter de fazer uma string no form para saber os dias possiveis
        Return vetor

    End Function

    Public Sub criar_dias()

        Dim dia As New Class_Dia
        For a = 1 To 365
            Dias.Add(dia)
        Next

    End Sub

    Public Sub marcar(dia As Integer, t As String)
        Dias(dia).marcar()
    End Sub

End Class
