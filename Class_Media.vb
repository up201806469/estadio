Imports Trabalho_PC_II

Public Class Class_Media
    Private _n As Integer
    Private _nmax As Integer
    Private _jorn As Collection_Jornalista

#Region "Properties"

    Public Property N As Integer
        Get
            Return _n
        End Get
        Set(value As Integer)
            _n = value
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

    Public Property Jorn As Collection_Jornalista
        Get
            Return _jorn
        End Get
        Set(value As Collection_Jornalista)
            _jorn = value
        End Set
    End Property

#End Region

    Public Sub add(jornalista As Class_jornalista)

        If N < Nmax Then
            Jorn.Add(jornalista)
            N += 1
        End If

    End Sub
    Public Sub retirar(jornalista As Class_jornalista)

        If N > 0 Then

            Jorn.Remove(jornalista)
            N -= 1

        End If


    End Sub


End Class
