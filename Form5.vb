Public Class Form5
    Private Sub btnEsconder_Click(sender As Object, e As EventArgs) Handles btnEsconder.Click
        lblMainLegenda.Hide()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        lblMainLegenda.Show()
    End Sub

    Private Sub btnResEsconder_Click(sender As Object, e As EventArgs) Handles btnResEsconder.Click
        lblMainLegenda.Visible = True

    End Sub
End Class