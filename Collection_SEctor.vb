Public Class Collection_Sector

#Region "Collection"
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_Sector As Class_Sector)
        Me.List.Add(New Class_Sector)
    End Sub

    Public Sub Remove(ByVal oldClass_Sector As Class_Sector)
        Me.List.Remove(oldClass_Sector)
    End Sub
    Default Public Property item(ByVal index As Integer) As Class_Sector
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_Sector)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub
    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_Sector As Class_Sector)

        Me.List.Insert(index, New Class_Sector)
    End Sub

#End Region

End Class
