Public Class dia
    Private _estado As Integer

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal estado)
End Class
