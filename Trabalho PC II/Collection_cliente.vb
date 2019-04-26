Public Class Collection_cliente

    Inherits Collections.CollectionBase

        Public Sub Add(ByVal Newcliente As Cliente)
            Me.List.Add(Newcliente)
        End Sub

        Public Sub Remove(ByVal oldcliente As Cliente)
            Me.List.Remove(oldcliente)
        End Sub

        Default Public Property item(ByVal index As Integer) As Cliente
            Get
                Return Me.List.Item(index)
            End Get
            Set(ByVal value As Cliente)
                Me.List.Item(index) = value
            End Set
        End Property

        Public Shadows Sub clear()
            MyBase.Clear()
        End Sub

        Public Shadows Sub RemoveAt(ByVal index As Integer)
            Remove(item(index))
        End Sub
        Public Sub InsertAt(ByVal index As Integer, ByVal Newcliente As Cliente)
            Me.List.Insert(index, Newcliente)
        End Sub


    End Class

