<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lblMainLegenda = New System.Windows.Forms.Label()
        Me.btnEsconder = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnMudarCorLegenda = New System.Windows.Forms.Button()
        Me.btnMudarFundoForm = New System.Windows.Forms.Button()
        Me.btnEscreverNum = New System.Windows.Forms.Button()
        Me.btnResEsconder = New System.Windows.Forms.Button()
        Me.btnResMostrar = New System.Windows.Forms.Button()
        Me.btnResCor = New System.Windows.Forms.Button()
        Me.btnResCorForm = New System.Windows.Forms.Button()
        Me.btnResRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMainLegenda
        '
        Me.lblMainLegenda.AutoSize = True
        Me.lblMainLegenda.Location = New System.Drawing.Point(154, 34)
        Me.lblMainLegenda.Name = "lblMainLegenda"
        Me.lblMainLegenda.Size = New System.Drawing.Size(224, 32)
        Me.lblMainLegenda.TabIndex = 0
        Me.lblMainLegenda.Text = "Isto é uma Legenda"
        '
        'btnEsconder
        '
        Me.btnEsconder.Location = New System.Drawing.Point(51, 169)
        Me.btnEsconder.Name = "btnEsconder"
        Me.btnEsconder.Size = New System.Drawing.Size(212, 114)
        Me.btnEsconder.TabIndex = 1
        Me.btnEsconder.Text = "Esconder a Legenda"
        Me.btnEsconder.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(286, 169)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(192, 114)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar a Legenda"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnMudarCorLegenda
        '
        Me.btnMudarCorLegenda.Location = New System.Drawing.Point(51, 345)
        Me.btnMudarCorLegenda.Name = "btnMudarCorLegenda"
        Me.btnMudarCorLegenda.Size = New System.Drawing.Size(212, 110)
        Me.btnMudarCorLegenda.TabIndex = 3
        Me.btnMudarCorLegenda.Text = "Mudar a Cor de Fundo da Legenda"
        Me.btnMudarCorLegenda.UseVisualStyleBackColor = True
        '
        'btnMudarFundoForm
        '
        Me.btnMudarFundoForm.Location = New System.Drawing.Point(286, 345)
        Me.btnMudarFundoForm.Name = "btnMudarFundoForm"
        Me.btnMudarFundoForm.Size = New System.Drawing.Size(192, 110)
        Me.btnMudarFundoForm.TabIndex = 4
        Me.btnMudarFundoForm.Text = "Mudar a Cor de Fundo do Formulario"
        Me.btnMudarFundoForm.UseVisualStyleBackColor = True
        '
        'btnEscreverNum
        '
        Me.btnEscreverNum.Location = New System.Drawing.Point(51, 518)
        Me.btnEscreverNum.Name = "btnEscreverNum"
        Me.btnEscreverNum.Size = New System.Drawing.Size(427, 112)
        Me.btnEscreverNum.TabIndex = 5
        Me.btnEscreverNum.Text = "Escrever na Legenda um numero aleatorio entre 1 e 100"
        Me.btnEscreverNum.UseVisualStyleBackColor = True
        '
        'btnResEsconder
        '
        Me.btnResEsconder.Location = New System.Drawing.Point(51, 117)
        Me.btnResEsconder.Name = "btnResEsconder"
        Me.btnResEsconder.Size = New System.Drawing.Size(100, 46)
        Me.btnResEsconder.TabIndex = 6
        Me.btnResEsconder.Text = "Res"
        Me.btnResEsconder.UseVisualStyleBackColor = True
        '
        'btnResMostrar
        '
        Me.btnResMostrar.Location = New System.Drawing.Point(286, 117)
        Me.btnResMostrar.Name = "btnResMostrar"
        Me.btnResMostrar.Size = New System.Drawing.Size(83, 46)
        Me.btnResMostrar.TabIndex = 7
        Me.btnResMostrar.Text = "Res"
        Me.btnResMostrar.UseVisualStyleBackColor = True
        '
        'btnResCor
        '
        Me.btnResCor.Location = New System.Drawing.Point(51, 293)
        Me.btnResCor.Name = "btnResCor"
        Me.btnResCor.Size = New System.Drawing.Size(100, 46)
        Me.btnResCor.TabIndex = 8
        Me.btnResCor.Text = "Res"
        Me.btnResCor.UseVisualStyleBackColor = True
        '
        'btnResCorForm
        '
        Me.btnResCorForm.Location = New System.Drawing.Point(286, 293)
        Me.btnResCorForm.Name = "btnResCorForm"
        Me.btnResCorForm.Size = New System.Drawing.Size(83, 46)
        Me.btnResCorForm.TabIndex = 9
        Me.btnResCorForm.Text = "Res"
        Me.btnResCorForm.UseVisualStyleBackColor = True
        '
        'btnResRandom
        '
        Me.btnResRandom.Location = New System.Drawing.Point(51, 466)
        Me.btnResRandom.Name = "btnResRandom"
        Me.btnResRandom.Size = New System.Drawing.Size(100, 46)
        Me.btnResRandom.TabIndex = 10
        Me.btnResRandom.Text = "Res"
        Me.btnResRandom.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 662)
        Me.Controls.Add(Me.btnResRandom)
        Me.Controls.Add(Me.btnResCorForm)
        Me.Controls.Add(Me.btnResCor)
        Me.Controls.Add(Me.btnResMostrar)
        Me.Controls.Add(Me.btnResEsconder)
        Me.Controls.Add(Me.btnEscreverNum)
        Me.Controls.Add(Me.btnMudarFundoForm)
        Me.Controls.Add(Me.btnMudarCorLegenda)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnEsconder)
        Me.Controls.Add(Me.lblMainLegenda)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMainLegenda As Label
    Friend WithEvents btnEsconder As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnMudarCorLegenda As Button
    Friend WithEvents btnMudarFundoForm As Button
    Friend WithEvents btnEscreverNum As Button
    Friend WithEvents btnResEsconder As Button
    Friend WithEvents btnResMostrar As Button
    Friend WithEvents btnResCor As Button
    Friend WithEvents btnResCorForm As Button
    Friend WithEvents btnResRandom As Button
End Class
