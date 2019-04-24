Public Class Socio
    Inherits Cliente
    Private _telemovel As String
    Private _email As String
#Region "Construtores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal nif As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date, ByVal telemovel As String, ByVal email As String)
        MyBase.New(nif, nome, sexo, datanascimento)
        Me.Telemovel = telemovel
        Me.Email = email
    End Sub
#End Region
#Region "properties"
    Public Property Telemovel As String
        Get
            Return _telemovel
        End Get
        Set(value As String)
            _telemovel = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
#End Region

End Class
