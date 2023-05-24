<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCalcular = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCalcular
        '
        Me.lblCalcular.AutoSize = True
        Me.lblCalcular.Location = New System.Drawing.Point(23, 59)
        Me.lblCalcular.Name = "lblCalcular"
        Me.lblCalcular.Size = New System.Drawing.Size(364, 32)
        Me.lblCalcular.TabIndex = 0
        Me.lblCalcular.Text = "Calcular o volume de um tanque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comprimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Largura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Altura"
        '
        'txtComprimento
        '
        Me.txtComprimento.Location = New System.Drawing.Point(217, 168)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(117, 39)
        Me.txtComprimento.TabIndex = 4
        '
        'txtLargura
        '
        Me.txtLargura.Location = New System.Drawing.Point(217, 223)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(117, 39)
        Me.txtLargura.TabIndex = 5
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(217, 284)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(117, 39)
        Me.txtAltura.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(80, 349)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(115, 91)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular Volume"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(217, 375)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(117, 39)
        Me.txtResultado.TabIndex = 8
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 542)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtLargura)
        Me.Controls.Add(Me.txtComprimento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCalcular)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalcular As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtComprimento As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
End Class
