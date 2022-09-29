Public Class FOperacoes
    Private Sub calcular()

        TXTResultado.Text = CDec(TXTPValor.Text) + CDec(TXTSValor.Text)

    End Sub

    Private Sub BTNResultado_Click(sender As Object, e As EventArgs) Handles BTNResultado.Click
        calcular()
    End Sub

    Private Sub BTNSoma_Click(sender As Object, e As EventArgs) Handles BTNSoma.Click
        calcular()

    End Sub

    Private Sub subtrair()

        TXTResultado.Text = CDec(TXTPValor.Text) - CDec(TXTSValor.Text)
    End Sub


    Private Sub BTNSubtrair_Click(sender As Object, e As EventArgs) Handles BTNSubtrair.Click
        subtrair()
    End Sub

    Private Sub multiplicar()

        TXTResultado.Text = CDec(TXTPValor.Text) * CDec(TXTSValor.Text)
    End Sub


    Private Sub BTNMultiplicacao_Click(sender As Object, e As EventArgs) Handles BTNMultiplicacao.Click
        multiplicar()

    End Sub


    Private Sub dividir()

        TXTResultado.Text = CDec(TXTPValor.Text) / CDec(TXTSValor.Text)
    End Sub

    Private Sub BTNDivisao_Click(sender As Object, e As EventArgs) Handles BTNDivisao.Click
        dividir()

    End Sub
End Class
