Imports System.Text.RegularExpressions

Public Class Form4
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        Dim n1, n2 As Integer

        Try
            n1 = Convert.ToInt32(txtNum1.Text)
            n2 = Convert.ToInt32(txtNum2.Text)
            txtResultado.Text = Convert.ToString(n1 + n2)


        Catch ex As Exception
            lblAviso.Visible = False

            If txtNum1.Text = String.Empty Or txtNum2.Text = String.Empty Then
                lblAviso.Text = "Por favor insira os numeros"
            Else
                If txtNum2.Text = String.Empty Then
                    lblAviso.Text = "Por favor o numero 1"
                Else
                    If txtNum2.Text = String.Empty Then
                        lblAviso.Text = "Por favor insira o numero 2"
                    End If
                End If

                End If
        End Try

    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged
        txtNum1.Text = Regex.Replace(txtNum1.Text, "[^0-9]", "")
    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged
        txtNum2.Text = Regex.Replace(txtNum2.Text, "[^0-9]", "")
    End Sub

    Private Sub txtSubtrair_Click(sender As Object, e As EventArgs) Handles txtSubtrair.Click
        Dim n1, n2 As Integer

        Try
            n1 = Convert.ToInt32(txtNum1.Text)
            n2 = Convert.ToInt32(txtNum2.Text)
            txtResultado.Text = Convert.ToString(n1 - n2)


        Catch ex As Exception
            lblAviso.Visible = False

            If txtNum1.Text = String.Empty Or txtNum2.Text = String.Empty Then
                lblAviso.Text = "Por favor insira os numeros"
            Else
                If txtNum2.Text = String.Empty Then
                    lblAviso.Text = "Por favor o numero 1"
                Else
                    If txtNum2.Text = String.Empty Then
                        lblAviso.Text = "Por favor insira o numero 2"
                    End If
                End If

            End If
        End Try

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim n1, n2 As Integer

        Try
            n1 = Convert.ToInt32(txtNum1.Text)
            n2 = Convert.ToInt32(txtNum2.Text)
            txtResultado.Text = Convert.ToString(n1 * n2)


        Catch ex As Exception
            lblAviso.Visible = False

            If txtNum1.Text = String.Empty Or txtNum2.Text = String.Empty Then
                lblAviso.Text = "Por favor insira os numeros"
            Else
                If txtNum2.Text = String.Empty Then
                    lblAviso.Text = "Por favor o numero 1"
                Else
                    If txtNum2.Text = String.Empty Then
                        lblAviso.Text = "Por favor insira o numero 2"
                    End If
                End If

            End If
        End Try

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim n1, n2 As Integer

        Try
            n1 = Convert.ToInt32(txtNum1.Text)
            n2 = Convert.ToInt32(txtNum2.Text)
            txtResultado.Text = Convert.ToString(n1 / n2)


        Catch ex As Exception
            lblAviso.Visible = False

            If txtNum1.Text = String.Empty Or txtNum2.Text = String.Empty Then
                lblAviso.Text = "Por favor insira os numeros"
            Else
                If txtNum2.Text = String.Empty Then
                    lblAviso.Text = "Por favor o numero 1"
                Else
                    If txtNum2.Text = String.Empty Then
                        lblAviso.Text = "Por favor insira o numero 2"
                    End If
                End If

            End If
        End Try

    End Sub
End Class