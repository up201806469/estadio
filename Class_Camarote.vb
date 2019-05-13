Public Class Class_Camarote

    Private _empresa As String
    Private _estado As Boolean
    Private _capacidade As Integer

    Public Property Empresa As String
        Get
            Return _empresa
        End Get
        Set(value As String)
            _empresa = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Capacidade As Integer
        Get
            Return _capacidade
        End Get
        Set(value As Integer)
            _capacidade = value
        End Set
    End Property

    Public Sub New(capacidade As Integer)
        Me.Capacidade = capacidade
        Estado = False

    End Sub

    Public Sub reservar_anual(Nome As String)

        Estado = True
        Empresa = Nome

    End Sub

    Public Sub cancelar()
        Estado = False
        Empresa = ""
    End Sub
End Class
