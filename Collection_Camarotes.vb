Public Class Collection_Camarotes

    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_Camarote As Class_Camarote)
        Me.List.Add(NewClass_Camarote)
    End Sub

    Public Sub Remove(ByVal oldClass_Camarote As Class_Camarote)
        Me.List.Remove(oldClass_Camarote)
    End Sub

    Default Public Property item(ByVal index As Integer) As Class_Camarote
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_Camarote)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_Camarote As Class_Camarote)

        Me.List.Insert(index, NewClass_Camarote)
    End Sub
End Class
