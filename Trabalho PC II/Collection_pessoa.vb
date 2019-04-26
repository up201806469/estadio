Public Class Collection_pessoa

    Inherits Collections.CollectionBase

    Public Sub Add(ByVal Newpessoa As Pessoa)
        Me.List.Add(Newpessoa)
    End Sub

    Public Sub Remove(ByVal oldpessoa As Pessoa)
        Me.List.Remove(oldpessoa)
    End Sub

    Default Public Property item(ByVal index As Integer) As Pessoa
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Pessoa)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal Newpessoa As Pessoa)
        Me.List.Insert(index, Newpessoa)
    End Sub


    End Class


End Class
