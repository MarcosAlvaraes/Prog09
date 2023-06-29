<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.txtSubtrair = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insira um Nº"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insira um Nº"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(39, 88)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(139, 39)
        Me.txtNum1.TabIndex = 2
        Me.txtNum1.Text = "5"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(209, 87)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(142, 39)
        Me.txtNum2.TabIndex = 3
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(38, 158)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(118, 32)
        Me.Resultado.TabIndex = 4
        Me.Resultado.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(45, 197)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(133, 39)
        Me.txtResultado.TabIndex = 5
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(43, 327)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(113, 74)
        Me.btnSoma.TabIndex = 6
        Me.btnSoma.Text = "Somar"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'txtSubtrair
        '
        Me.txtSubtrair.Location = New System.Drawing.Point(167, 332)
        Me.txtSubtrair.Name = "txtSubtrair"
        Me.txtSubtrair.Size = New System.Drawing.Size(109, 69)
        Me.txtSubtrair.TabIndex = 7
        Me.txtSubtrair.Text = "Subtrair"
        Me.txtSubtrair.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(45, 420)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(106, 79)
        Me.btnMulti.TabIndex = 8
        Me.btnMulti.Text = "Multiplicar"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(168, 424)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(108, 75)
        Me.btnDiv.TabIndex = 9
        Me.btnDiv.Text = "Dividir"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Location = New System.Drawing.Point(244, 196)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(83, 32)
        Me.lblAviso.TabIndex = 10
        Me.lblAviso.Text = "Label3"
        Me.lblAviso.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 567)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.txtSubtrair)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Resultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSoma As Button
    Friend WithEvents txtSubtrair As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents lblAviso As Label
End Class
