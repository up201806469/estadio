Imports Trabalho_PC_II

Public Class Class_Sector

#Region "Properties"

    Private _lugares As Collection_Lugar
    Private _nome As String
    Private _nmax As Integer
    Private _n As Integer


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

    Public Property Lugares As Collection_Lugar
        Get
            Return _lugares
        End Get
        Set(value As Collection_Lugar)
            _lugares = value
        End Set
    End Property
#End Region

#Region "New"
    Public Sub New(nome As String, nmax As Integer)
        _nome = nome
        _nmax = nmax
        _n = 0
    End Sub

    Public Sub New()

    End Sub


#End Region


End Class
