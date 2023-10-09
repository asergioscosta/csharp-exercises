<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSistema))
        Me.PBImagem = New System.Windows.Forms.PictureBox()
        Me.BTNCima = New System.Windows.Forms.Button()
        Me.BTNBaixo = New System.Windows.Forms.Button()
        Me.BTNEsquerdo = New System.Windows.Forms.Button()
        Me.BTNDireito = New System.Windows.Forms.Button()
        CType(Me.PBImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBImagem
        '
        Me.PBImagem.Image = CType(resources.GetObject("PBImagem.Image"), System.Drawing.Image)
        Me.PBImagem.Location = New System.Drawing.Point(22, 32)
        Me.PBImagem.Name = "PBImagem"
        Me.PBImagem.Size = New System.Drawing.Size(102, 126)
        Me.PBImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagem.TabIndex = 0
        Me.PBImagem.TabStop = False
        '
        'BTNCima
        '
        Me.BTNCima.Location = New System.Drawing.Point(144, 162)
        Me.BTNCima.Name = "BTNCima"
        Me.BTNCima.Size = New System.Drawing.Size(75, 23)
        Me.BTNCima.TabIndex = 1
        Me.BTNCima.Text = "Cima"
        Me.BTNCima.UseVisualStyleBackColor = True
        '
        'BTNBaixo
        '
        Me.BTNBaixo.Location = New System.Drawing.Point(144, 227)
        Me.BTNBaixo.Name = "BTNBaixo"
        Me.BTNBaixo.Size = New System.Drawing.Size(75, 23)
        Me.BTNBaixo.TabIndex = 2
        Me.BTNBaixo.Text = "Baixo"
        Me.BTNBaixo.UseVisualStyleBackColor = True
        '
        'BTNEsquerdo
        '
        Me.BTNEsquerdo.Location = New System.Drawing.Point(80, 198)
        Me.BTNEsquerdo.Name = "BTNEsquerdo"
        Me.BTNEsquerdo.Size = New System.Drawing.Size(75, 23)
        Me.BTNEsquerdo.TabIndex = 3
        Me.BTNEsquerdo.Text = "Esquerda"
        Me.BTNEsquerdo.UseVisualStyleBackColor = True
        '
        'BTNDireito
        '
        Me.BTNDireito.Location = New System.Drawing.Point(197, 198)
        Me.BTNDireito.Name = "BTNDireito"
        Me.BTNDireito.Size = New System.Drawing.Size(75, 23)
        Me.BTNDireito.TabIndex = 4
        Me.BTNDireito.Text = "Direita"
        Me.BTNDireito.UseVisualStyleBackColor = True
        '
        'FSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BTNDireito)
        Me.Controls.Add(Me.BTNEsquerdo)
        Me.Controls.Add(Me.BTNBaixo)
        Me.Controls.Add(Me.BTNCima)
        Me.Controls.Add(Me.PBImagem)
        Me.Name = "FSistema"
        Me.Text = "Sistema Animado"
        CType(Me.PBImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBImagem As System.Windows.Forms.PictureBox
    Friend WithEvents BTNCima As System.Windows.Forms.Button
    Friend WithEvents BTNBaixo As System.Windows.Forms.Button
    Friend WithEvents BTNEsquerdo As System.Windows.Forms.Button
    Friend WithEvents BTNDireito As System.Windows.Forms.Button

End Class
