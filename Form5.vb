Imports System.Runtime.CompilerServices
Imports System.Drawing

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
        Dim rnd As Random = New Random()
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer

        r = rnd.Next(255)
        g = rnd.Next(255)
        b = rnd.Next(255)

        lblMainLegenda.BackColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub btnResCor_Click(sender As Object, e As EventArgs) Handles btnResCor.Click
        lblMainLegenda.BackColor = SystemColors.Control
    End Sub

    Private Sub btnMudarFundoForm_Click(sender As Object, e As EventArgs) Handles btnMudarFundoForm.Click
        Dim rnd As Random = New Random()
        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255))
    End Sub

    Private Sub btnEscreverNum_Click(sender As Object, e As EventArgs) Handles btnEscreverNum.Click
        Dim rnd As Random = New Random()
        lblMainLegenda.Text = rnd.Next(1, 100).ToString()
    End Sub

    Private Sub btnResCorForm_Click(sender As Object, e As EventArgs) Handles btnResCorForm.Click

        Me.BackColor = SystemColors.Control

    End Sub
End Class