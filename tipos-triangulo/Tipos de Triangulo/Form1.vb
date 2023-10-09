Public Class ftipos

    Private Sub tipostriangulo()
        Dim LadoA, LadoB, LadoC As Integer
        Dim TipoUm, TipoDois, TipoTres As String
        TipoUm = "Triangulo Equilátero 3 lados Iguais"
        TipoDois = "Triangulo Isósceles 2 lados iguais 1 diferente"
        TipoTres = "Triangulo Escaleno 3 lados Diferentes"
        LadoA = TXTladoA.text
        LadoB = TXTLadoB.Text
        LadoC = TXTLadoC.Text

        If (LadoA <> LadoB) And (LadoB <> LadoC) And (LadoC <> LadoA) Then
            TXTSituacao.Text = TipoTres
            escaleno()
        ElseIf (LadoA = LadoB) And (LadoB = LadoC) And (LadoC <= LadoA) Then
            TXTSituacao.Text = TipoUm
            equilatero()
        Else
            TXTSituacao.Text = TipoDois
            isosceles()
        End If
    End Sub

    Private Sub BTNExibir_Click(sender As Object, e As EventArgs) Handles BTNExibir.Click
        tipostriangulo()
    End Sub
    Private Sub equilatero()

        PBEquilatero.Visible = True
        PBEscaleno.Visible = False
        PBIsosceles.Visible = False
    End Sub
    Private Sub escaleno()

        PBEquilatero.Visible = False
        PBEscaleno.Visible = True
        PBIsosceles.Visible = False
    End Sub
    Private Sub isosceles()

        PBEquilatero.Visible = False
        PBEscaleno.Visible = False
        PBIsosceles.Visible = True
    End Sub


End Class
