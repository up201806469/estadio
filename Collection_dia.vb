Public Class Collection_dia
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_Dia As Class_Dia)
        Me.List.Add(NewClass_Dia)
    End Sub

    Public Sub Remove(ByVal oldClass_Dia As Class_Dia)
        Me.List.Remove(oldClass_Dia)
    End Sub

    Default Public Property item(ByVal index As Integer) As Class_Dia
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_Dia)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_Dia As Class_Dia)

        Me.List.Insert(index, NewClass_Dia)
    End Sub
End Class
