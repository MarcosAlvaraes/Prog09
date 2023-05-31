Imports System.Runtime.CompilerServices

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

    Private Sub btnResMostrar_Click(sender As Object, e As EventArgs) Handles btnResMostrar.Click
        lblMainLegenda.Visible = False
    End Sub

    Private Sub btnMudarCorLegenda_Click(sender As Object, e As EventArgs) Handles btnMudarCorLegenda.Click
        Dim rnd As Random
        lblMainLegenda.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255))
    End Sub

    Private Sub btnResCor_Click(sender As Object, e As EventArgs) Handles btnResCor.Click
        lblMainLegenda.BackColor = SystemColors.Control
    End Sub

    Private Sub btnMudarFundoForm_Click(sender As Object, e As EventArgs) Handles btnMudarFundoForm.Click
        Dim rnd As Random
        Form5.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255))
    End Sub
End Class