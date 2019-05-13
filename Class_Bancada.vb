Imports Trabalho_PC_II

Public Class Class_Bancada

    Private _sectores As Collection_Sector
    Private _nome As String
    Private _nmax As Integer
    Private _n As Integer

    Public Sub New(nome As String, nmax As Integer)
        Me.Nome = nome
        Me.Nmax = nmax
        N = 0

    End Sub

    Public Property Sectores As Collection_Sector
        Get
            Return _sectores
        End Get
        Set(value As Collection_Sector)
            _sectores = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Nmax As Integer
        Get
            Return _nmax
        End Get
        Set(value As Integer)
            _nmax = value
        End Set
    End Property

    Public Property N As Integer
        Get
            Return _n
        End Get
        Set(value As Integer)
            _n = value
        End Set
    End Property
End Class
