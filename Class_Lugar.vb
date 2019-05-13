Public Class Class_Lugar
    Private _estado As Boolean
    'se F então livre
    'se V então ocupado
    Private _cativo As Boolean
    ' se F então não é cativo
    ' se V então é cativo

#Region "properties"



    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Cativo As Boolean
        Get
            Return _cativo
        End Get
        Set(value As Boolean)
            _cativo = value
        End Set
    End Property



#End Region

#Region "sub"

    Public Sub New()
        _cativo = False
    End Sub

    Public Sub New(cativo As Boolean)
        Me._cativo = cativo
    End Sub

    Public Sub alterar_estado(estado As Integer)
        'Se estado= 1--->> ocupar


        If Not Cativo Then
            If estado = 1 Then
                _estado = True
            ElseIf estado = 0 Then
                _estado = False

            End If
        Else
            estado = True
        End If


    End Sub

#End Region




End Class
