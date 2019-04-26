Public Class Collection_funcionariovip

    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newfuncionariovip As funcionariovip)
        Me.List.Add(Newfuncionariovip)
    End Sub

    Public Sub Remove(ByVal oldfuncionariovip As funcionariovip)
        Me.List.Remove(oldfuncionariovip)
    End Sub

    Default Public Property item(ByVal index As Integer) As funcionariovip
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As funcionariovip)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal Newfuncionariovip As funcionariovip)
        Me.List.Insert(index, Newfuncionariovip)
    End Sub


    End Class

