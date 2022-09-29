<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOperacoes
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
        Me.BTNResultado = New System.Windows.Forms.Button()
        Me.BTNSoma = New System.Windows.Forms.Button()
        Me.BTNSubtrair = New System.Windows.Forms.Button()
        Me.BTNMultiplicacao = New System.Windows.Forms.Button()
        Me.BTNDivisao = New System.Windows.Forms.Button()
        Me.TXTPValor = New System.Windows.Forms.TextBox()
        Me.TXTSValor = New System.Windows.Forms.TextBox()
        Me.TXTResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNResultado
        '
        Me.BTNResultado.Location = New System.Drawing.Point(40, 217)
        Me.BTNResultado.Name = "BTNResultado"
        Me.BTNResultado.Size = New System.Drawing.Size(75, 23)
        Me.BTNResultado.TabIndex = 0
        Me.BTNResultado.Text = "Resultado"
        Me.BTNResultado.UseVisualStyleBackColor = True
        '
        'BTNSoma
        '
        Me.BTNSoma.Location = New System.Drawing.Point(188, 37)
        Me.BTNSoma.Name = "BTNSoma"
        Me.BTNSoma.Size = New System.Drawing.Size(75, 23)
        Me.BTNSoma.TabIndex = 1
        Me.BTNSoma.Text = "+"
        Me.BTNSoma.UseVisualStyleBackColor = True
        '
        'BTNSubtrair
        '
        Me.BTNSubtrair.Location = New System.Drawing.Point(188, 86)
        Me.BTNSubtrair.Name = "BTNSubtrair"
        Me.BTNSubtrair.Size = New System.Drawing.Size(75, 23)
        Me.BTNSubtrair.TabIndex = 2
        Me.BTNSubtrair.Text = "-"
        Me.BTNSubtrair.UseVisualStyleBackColor = True
        '
        'BTNMultiplicacao
        '
        Me.BTNMultiplicacao.Location = New System.Drawing.Point(188, 135)
        Me.BTNMultiplicacao.Name = "BTNMultiplicacao"
        Me.BTNMultiplicacao.Size = New System.Drawing.Size(75, 23)
        Me.BTNMultiplicacao.TabIndex = 3
        Me.BTNMultiplicacao.Text = "*"
        Me.BTNMultiplicacao.UseVisualStyleBackColor = True
        '
        'BTNDivisao
        '
        Me.BTNDivisao.Location = New System.Drawing.Point(188, 181)
        Me.BTNDivisao.Name = "BTNDivisao"
        Me.BTNDivisao.Size = New System.Drawing.Size(75, 23)
        Me.BTNDivisao.TabIndex = 4
        Me.BTNDivisao.Text = "/"
        Me.BTNDivisao.UseVisualStyleBackColor = True
        '
        'TXTPValor
        '
        Me.TXTPValor.Location = New System.Drawing.Point(40, 56)
        Me.TXTPValor.Name = "TXTPValor"
        Me.TXTPValor.Size = New System.Drawing.Size(100, 20)
        Me.TXTPValor.TabIndex = 5
        '
        'TXTSValor
        '
        Me.TXTSValor.Location = New System.Drawing.Point(40, 121)
        Me.TXTSValor.Name = "TXTSValor"
        Me.TXTSValor.Size = New System.Drawing.Size(100, 20)
        Me.TXTSValor.TabIndex = 6
        '
        'TXTResultado
        '
        Me.TXTResultado.Location = New System.Drawing.Point(40, 181)
        Me.TXTResultado.Name = "TXTResultado"
        Me.TXTResultado.Size = New System.Drawing.Size(100, 20)
        Me.TXTResultado.TabIndex = 7
        '
        'FOperacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TXTResultado)
        Me.Controls.Add(Me.TXTSValor)
        Me.Controls.Add(Me.TXTPValor)
        Me.Controls.Add(Me.BTNDivisao)
        Me.Controls.Add(Me.BTNMultiplicacao)
        Me.Controls.Add(Me.BTNSubtrair)
        Me.Controls.Add(Me.BTNSoma)
        Me.Controls.Add(Me.BTNResultado)
        Me.Name = "FOperacoes"
        Me.Text = "Operações"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNResultado As System.Windows.Forms.Button
    Friend WithEvents BTNSoma As System.Windows.Forms.Button
    Friend WithEvents BTNSubtrair As System.Windows.Forms.Button
    Friend WithEvents BTNMultiplicacao As System.Windows.Forms.Button
    Friend WithEvents BTNDivisao As System.Windows.Forms.Button
    Friend WithEvents TXTPValor As System.Windows.Forms.TextBox
    Friend WithEvents TXTSValor As System.Windows.Forms.TextBox
    Friend WithEvents TXTResultado As System.Windows.Forms.TextBox

End Class
