Public Class Collection_Bancada
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_Bancada As Class_Bancada)
        Me.List.Add(NewClass_Bancada)
    End Sub

    Public Sub Remove(ByVal oldClass_Bancada As Class_Bancada)
        Me.List.Remove(oldClass_Bancada)
    End Sub

    Default Public Property item(ByVal index As Integer) As Class_Bancada
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_Bancada)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_Bancada As Class_Bancada)

        Me.List.Insert(index, NewClass_Bancada)
    End Sub
End Class
