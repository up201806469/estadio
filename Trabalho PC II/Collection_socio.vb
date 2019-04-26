Public Class Collection_socio
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newsocio As Socio)
        Me.List.Add(Newsocio)
    End Sub

    Public Sub Remove(ByVal oldsocio As Socio)
        Me.List.Remove(oldsocio)
    End Sub

    Default Public Property item(ByVal index As Integer) As Socio
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Socio)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal Newsocio As Socio)
        Me.List.Insert(index, Newsocio)
    End Sub



    End Class
