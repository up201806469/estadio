Public Class Collection_jornalista

    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newjornalista As jornalista)
        Me.List.Add(Newjornalista)
    End Sub

    Public Sub Remove(ByVal oldjornalista As jornalista)
        Me.List.Remove(oldjornalista)
    End Sub

    Default Public Property item(ByVal index As Integer) As jornalista
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As jornalista)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal Newjornalista As jornalista)
        Me.List.Insert(index, Newjornalista)
    End Sub


End Class

