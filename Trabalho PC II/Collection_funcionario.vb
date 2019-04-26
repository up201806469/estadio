Public Class Collection_funcionario

    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newfuncionario As funcionario)
        Me.List.Add(Newfuncionario)
    End Sub

    Public Sub Remove(ByVal oldfuncionario As funcionario)
        Me.List.Remove(oldfuncionario)
    End Sub

    Default Public Property item(ByVal index As Integer) As funcionario
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As funcionario)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal Newfuncionario As funcionario)
        Me.List.Insert(index, Newfuncionario)
    End Sub



End Class
