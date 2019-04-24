Public Class Cliente
    Inherits Pessoa
    Private _nif As String
#Region "constructors"

    Public Sub New()

    End Sub
    Public Sub New(ByVal nif As String, ByVal nome As String, ByVal sexo As String, ByVal datanascimento As Date)
        MyBase.New(nome, sexo, datanascimento)
        Me.Nif = nif
    End Sub
#End Region

#Region "propeties"
    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
        End Set
    End Property
#End Region

End Class
