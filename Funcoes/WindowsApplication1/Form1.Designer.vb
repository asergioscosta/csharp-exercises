<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFuncoes
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
        Me.TXTAlta = New System.Windows.Forms.TextBox()
        Me.TXTBaixa = New System.Windows.Forms.TextBox()
        Me.BTNAlta = New System.Windows.Forms.Button()
        Me.BTNBaixa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTAlta
        '
        Me.TXTAlta.Location = New System.Drawing.Point(32, 48)
        Me.TXTAlta.Name = "TXTAlta"
        Me.TXTAlta.Size = New System.Drawing.Size(100, 20)
        Me.TXTAlta.TabIndex = 0
        '
        'TXTBaixa
        '
        Me.TXTBaixa.Location = New System.Drawing.Point(32, 135)
        Me.TXTBaixa.Name = "TXTBaixa"
        Me.TXTBaixa.Size = New System.Drawing.Size(100, 20)
        Me.TXTBaixa.TabIndex = 1
        '
        'BTNAlta
        '
        Me.BTNAlta.Location = New System.Drawing.Point(182, 48)
        Me.BTNAlta.Name = "BTNAlta"
        Me.BTNAlta.Size = New System.Drawing.Size(75, 23)
        Me.BTNAlta.TabIndex = 2
        Me.BTNAlta.Text = "Caixa Alta"
        Me.BTNAlta.UseVisualStyleBackColor = True
        '
        'BTNBaixa
        '
        Me.BTNBaixa.Location = New System.Drawing.Point(182, 131)
        Me.BTNBaixa.Name = "BTNBaixa"
        Me.BTNBaixa.Size = New System.Drawing.Size(75, 23)
        Me.BTNBaixa.TabIndex = 3
        Me.BTNBaixa.Text = "Baixa"
        Me.BTNBaixa.UseVisualStyleBackColor = True
        '
        'FFuncoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BTNBaixa)
        Me.Controls.Add(Me.BTNAlta)
        Me.Controls.Add(Me.TXTBaixa)
        Me.Controls.Add(Me.TXTAlta)
        Me.Name = "FFuncoes"
        Me.Text = "Funções"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTAlta As System.Windows.Forms.TextBox
    Friend WithEvents TXTBaixa As System.Windows.Forms.TextBox
    Friend WithEvents BTNAlta As System.Windows.Forms.Button
    Friend WithEvents BTNBaixa As System.Windows.Forms.Button

End Class
