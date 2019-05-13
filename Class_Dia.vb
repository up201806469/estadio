Public Class Class_Dia

    Private _ocupado As Boolean

    Public Sub New()
        Ocupado = False
    End Sub

    Public Property Ocupado As Boolean
        Get
            Return _ocupado
        End Get
        Set(value As Boolean)
            _ocupado = value
        End Set
    End Property

    Public Sub marcar()
        If Ocupado = True Then
            'mensagem a dizer que ja esta ocupado
        Else
            Ocupado = True
        End If
    End Sub
    Public Sub desmarcar()

        If Ocupado = True Then
            'mensagem a dizer que foi desmarcado
        Else
            ' mesnagem a dizer que nao estava ocupado
        End If

        Ocupado = False
    End Sub


End Class
