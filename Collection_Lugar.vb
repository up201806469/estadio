Public Class Collection_Lugar

#Region "Collection"
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_Lugar As Class_Lugar)
        Me.List.Add(NewClass_Lugar)
    End Sub

    Public Sub Remove(ByVal oldClass_Lugar As Class_Lugar)
        Me.List.Remove(oldClass_Lugar)
    End Sub

    Default Public Property item(ByVal index As Integer) As Class_Lugar
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_Lugar)
            Me.List.Item(index) = value
        End Set
    End Property



    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_Lugar As Class_Lugar)

        Me.List.Insert(index, NewClass_Lugar)
    End Sub

#End Region

End Class
