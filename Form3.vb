Public Class Form3
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim comprimento, largura, altura, volume As Double

        comprimento = Convert.ToDouble(txtComprimento.Text)
        largura = Convert.ToDouble(txtLargura.Text)
        altura = Convert.ToDouble(txtAltura.Text)

        volume = comprimento * largura * altura
        txtResultado.Text = volume.ToString()

    End Sub
End Class