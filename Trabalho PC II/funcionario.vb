Public Class funcionario
    Inherits Pessoa

    Private _iD_number As String
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal id_number As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date)
        MyBase.New(nome, sexo, datanascimento)
        Me.ID_number = id_number
    End Sub
#End Region
#Region "properties"
    Public Property ID_number As String
        Get
            Return _iD_number
        End Get
        Set(value As String)
            _iD_number = value
        End Set
    End Property
#End Region
End Class
