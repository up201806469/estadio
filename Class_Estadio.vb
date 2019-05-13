Imports Trabalho_PC_II

Public Class Class_Estadio

    Private ReadOnly bancadas As Collection_Bancada

    Public ReadOnly Property Bancadas1 As Collection_Bancada
        Get
            Return bancadas
        End Get
    End Property

    Public Sub marcar(bancada As String, sector As String, lugar As Integer)
        For a = 1 To Bancadas1.Count

            If bancada = Bancadas1.item(a).Nome Then

                For b = 1 To Bancadas1(a).Sectores.Count

                    If sector = Bancadas1(a).Sectores(b).Nome Then

                        For c = 1 To Bancadas1(a).Sectores(b).Lugares.Count

                            If lugar = c Then

                                If Not Bancadas1(a).Sectores(b).Lugares(lugar).Estado And Not Bancadas1(a).Sectores(b).Lugares(lugar).Cativo Then

                                    Bancadas1(a).Sectores(b).Lugares(lugar).alterar_estado(True)
                                    Bancadas1(a).Sectores(b).N += 1

                                End If

                            End If

                        Next

                    End If

                Next

            End If

        Next

    End Sub

    Public Sub cancelar(bancada As String, sector As String, lugar As Integer)
        For a = 1 To Bancadas1.Count

            If bancada = Bancadas1.item(a).Nome Then

                For b = 1 To Bancadas1(a).Sectores.Count

                    If sector = Bancadas1(a).Sectores(b).Nome Then

                        For c = 1 To Bancadas1(a).Sectores(b).Lugares.Count

                            If lugar = c Then

                                If Bancadas1(a).Sectores(b).Lugares(lugar).Estado And Not Bancadas1(a).Sectores(b).Lugares(lugar).Cativo Then

                                    Bancadas1(a).Sectores(b).Lugares(lugar).alterar_estado(False)
                                    Bancadas1(a).Sectores(b).N -= 1

                                End If

                            End If

                        Next

                    End If

                Next

            End If

        Next

    End Sub

End Class
