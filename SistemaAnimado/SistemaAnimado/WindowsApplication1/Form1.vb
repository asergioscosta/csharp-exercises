Public Class FSistema


    Private Sub cima()
        PBImagem.Top = PBImagem.Top - 10

    End Sub

    Private Sub BTNCima_Click(sender As Object, e As EventArgs) Handles BTNCima.Click
        cima()

    End Sub

    Private Sub esquerdo()
        PBImagem.Left = PBImagem.Left - 10

    End Sub

    Private Sub BTNEsquerdo_Click(sender As Object, e As EventArgs) Handles BTNEsquerdo.Click
        esquerdo()
    End Sub

    Private Sub baixo()
        PBImagem.Top = PBImagem.Top + 10

    End Sub

    Private Sub BTNBaixo_Click(sender As Object, e As EventArgs) Handles BTNBaixo.Click
        baixo()
    End Sub

    Private Sub direito()
        PBImagem.Left = PBImagem.Left + 10

    End Sub

    Private Sub BTNDireito_Click(sender As Object, e As EventArgs) Handles BTNDireito.Click
        direito()
    End Sub
End Class


