Public Class FOKOnly

    Private Sub ok()

        MsgBox("OK", vbOKOnly, "Aviso!")

    End Sub


    Private Sub BTNOKOnly_Click(sender As Object, e As EventArgs) Handles BTNOKOnly.Click
        ok()

    End Sub

    Private Sub okcancelar()

        MsgBox("OK, Cancelar", vbOKCancel, "Aviso!")


    End Sub

    Private Sub BTNOKCancel_Click(sender As Object, e As EventArgs) Handles BTNOKCancel.Click
        okcancelar()
    End Sub

    Private Sub abortarri()

        MsgBox("Abortar, Repetir ou Ignorar", vbAbortRetryIgnore, "Aviso!")


    End Sub


    Private Sub BTNAboutRetryIgnore_Click(sender As Object, e As EventArgs) Handles BTNAboutRetryIgnore.Click
        abortarri()
    End Sub

    Private Sub yesno()

        MsgBox("Sim, Não ou Cancelar", vbYesNoCancel, "Aviso!")


    End Sub

    Private Sub BTNYesNoCancel_Click(sender As Object, e As EventArgs) Handles BTNYesNoCancel.Click
        yesno()
    End Sub

    Private Sub yesn()

        MsgBox("Sim ou Não", vbYesNo, "Aviso!")


    End Sub

    Private Sub BTNYesNo_Click(sender As Object, e As EventArgs) Handles BTNYesNo.Click
        yesn()
    End Sub

    Private Sub retrycancel()

        MsgBox("Repetir ou Cancelar", vbRetryCancel, "Aviso!")


    End Sub

    Private Sub BTNRetryCancel_Click(sender As Object, e As EventArgs) Handles BTNRetryCancel.Click
        retrycancel()
    End Sub

    Private Sub critical()

        MsgBox("Crítica", vbCritical, "Aviso!!")


    End Sub

    Private Sub BTNCritical_Click(sender As Object, e As EventArgs) Handles BTNCritical.Click
        critical()
    End Sub


    Private Sub exclamation()

        MsgBox("!!", vbExclamation, "Aviso")

    End Sub

    Private Sub BTNExclamation_Click(sender As Object, e As EventArgs) Handles BTNExclamation.Click
        exclamation()
    End Sub


    Private Sub information()

        MsgBox("Informação", vbInformation, "Aviso!")

    End Sub


    Private Sub BTNInformation_Click(sender As Object, e As EventArgs) Handles BTNInformation.Click
        information()
    End Sub
End Class
