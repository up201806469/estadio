Public Class Collection_Jornalista
#Region "Collection"
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClass_jornalista As Class_jornalista)
        Me.List.Add(NewClass_jornalista)
    End Sub

    Public Sub Remove(ByVal oldClass_jornalista As Class_jornalista)
        Me.List.Remove(oldClass_jornalista)
    End Sub

    Default Public Property item(ByVal index As Integer) As Class_jornalista
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Class_jornalista)
            Me.List.Item(index) = value
        End Set
    End Property



    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewClass_jornalista As Class_jornalista)

        Me.List.Insert(index, NewClass_jornalista)
    End Sub

#End Region

End Class
