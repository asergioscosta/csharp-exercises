Public Class FFuncoes
    Private Sub alta()
        TXTAlta.Text = UCase(TXTAlta.Text)
    End Sub


    Private Sub baixa()
        TXTBaixa.Text = LCase(TXTBaixa.Text)
    End Sub

    Private Sub BTNAlta_Click(sender As Object, e As EventArgs) Handles BTNAlta.Click
        alta()
    End Sub

    Private Sub BTNBaixa_Click(sender As Object, e As EventArgs) Handles BTNBaixa.Click
        baixa()
    End Sub
End Class
