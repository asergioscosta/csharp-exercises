<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftipos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ftipos))
        Me.TXTLadoA = New System.Windows.Forms.TextBox()
        Me.LLadoA = New System.Windows.Forms.Label()
        Me.LLadoB = New System.Windows.Forms.Label()
        Me.LLadoC = New System.Windows.Forms.Label()
        Me.BTNExibir = New System.Windows.Forms.Button()
        Me.TXTLadoB = New System.Windows.Forms.TextBox()
        Me.TXTLadoC = New System.Windows.Forms.TextBox()
        Me.TXTSituacao = New System.Windows.Forms.TextBox()
        Me.LTipo = New System.Windows.Forms.Label()
        Me.PBIsosceles = New System.Windows.Forms.PictureBox()
        Me.PBEscaleno = New System.Windows.Forms.PictureBox()
        Me.PBEquilatero = New System.Windows.Forms.PictureBox()
        CType(Me.PBIsosceles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEscaleno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEquilatero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTLadoA
        '
        Me.TXTLadoA.Location = New System.Drawing.Point(16, 36)
        Me.TXTLadoA.Name = "TXTLadoA"
        Me.TXTLadoA.Size = New System.Drawing.Size(100, 20)
        Me.TXTLadoA.TabIndex = 0
        '
        'LLadoA
        '
        Me.LLadoA.AutoSize = True
        Me.LLadoA.Location = New System.Drawing.Point(13, 9)
        Me.LLadoA.Name = "LLadoA"
        Me.LLadoA.Size = New System.Drawing.Size(143, 13)
        Me.LLadoA.TabIndex = 1
        Me.LLadoA.Text = "Digite um valor para o lado A"
        '
        'LLadoB
        '
        Me.LLadoB.AutoSize = True
        Me.LLadoB.Location = New System.Drawing.Point(12, 73)
        Me.LLadoB.Name = "LLadoB"
        Me.LLadoB.Size = New System.Drawing.Size(143, 13)
        Me.LLadoB.TabIndex = 2
        Me.LLadoB.Text = "Digite um valor para o lado B"
        '
        'LLadoC
        '
        Me.LLadoC.AutoSize = True
        Me.LLadoC.Location = New System.Drawing.Point(16, 131)
        Me.LLadoC.Name = "LLadoC"
        Me.LLadoC.Size = New System.Drawing.Size(143, 13)
        Me.LLadoC.TabIndex = 3
        Me.LLadoC.Text = "Digite um valor para o lado C"
        '
        'BTNExibir
        '
        Me.BTNExibir.Location = New System.Drawing.Point(300, 159)
        Me.BTNExibir.Name = "BTNExibir"
        Me.BTNExibir.Size = New System.Drawing.Size(75, 23)
        Me.BTNExibir.TabIndex = 4
        Me.BTNExibir.Text = "Exibir"
        Me.BTNExibir.UseVisualStyleBackColor = True
        '
        'TXTLadoB
        '
        Me.TXTLadoB.Location = New System.Drawing.Point(16, 99)
        Me.TXTLadoB.Name = "TXTLadoB"
        Me.TXTLadoB.Size = New System.Drawing.Size(100, 20)
        Me.TXTLadoB.TabIndex = 5
        '
        'TXTLadoC
        '
        Me.TXTLadoC.Location = New System.Drawing.Point(16, 159)
        Me.TXTLadoC.Name = "TXTLadoC"
        Me.TXTLadoC.Size = New System.Drawing.Size(100, 20)
        Me.TXTLadoC.TabIndex = 6
        '
        'TXTSituacao
        '
        Me.TXTSituacao.Location = New System.Drawing.Point(16, 218)
        Me.TXTSituacao.Multiline = True
        Me.TXTSituacao.Name = "TXTSituacao"
        Me.TXTSituacao.Size = New System.Drawing.Size(382, 20)
        Me.TXTSituacao.TabIndex = 7
        '
        'LTipo
        '
        Me.LTipo.AutoSize = True
        Me.LTipo.Location = New System.Drawing.Point(16, 199)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(90, 13)
        Me.LTipo.TabIndex = 8
        Me.LTipo.Text = "Tipo de Triângulo"
        '
        'PBIsosceles
        '
        Me.PBIsosceles.Image = CType(resources.GetObject("PBIsosceles.Image"), System.Drawing.Image)
        Me.PBIsosceles.Location = New System.Drawing.Point(288, 35)
        Me.PBIsosceles.Name = "PBIsosceles"
        Me.PBIsosceles.Size = New System.Drawing.Size(87, 84)
        Me.PBIsosceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBIsosceles.TabIndex = 9
        Me.PBIsosceles.TabStop = False
        Me.PBIsosceles.Visible = False
        '
        'PBEscaleno
        '
        Me.PBEscaleno.Image = CType(resources.GetObject("PBEscaleno.Image"), System.Drawing.Image)
        Me.PBEscaleno.Location = New System.Drawing.Point(288, 35)
        Me.PBEscaleno.Name = "PBEscaleno"
        Me.PBEscaleno.Size = New System.Drawing.Size(87, 84)
        Me.PBEscaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBEscaleno.TabIndex = 10
        Me.PBEscaleno.TabStop = False
        Me.PBEscaleno.Visible = False
        '
        'PBEquilatero
        '
        Me.PBEquilatero.Image = CType(resources.GetObject("PBEquilatero.Image"), System.Drawing.Image)
        Me.PBEquilatero.Location = New System.Drawing.Point(288, 36)
        Me.PBEquilatero.Name = "PBEquilatero"
        Me.PBEquilatero.Size = New System.Drawing.Size(87, 84)
        Me.PBEquilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBEquilatero.TabIndex = 11
        Me.PBEquilatero.TabStop = False
        Me.PBEquilatero.Visible = False
        '
        'ftipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 262)
        Me.Controls.Add(Me.PBEquilatero)
        Me.Controls.Add(Me.PBEscaleno)
        Me.Controls.Add(Me.PBIsosceles)
        Me.Controls.Add(Me.LTipo)
        Me.Controls.Add(Me.TXTSituacao)
        Me.Controls.Add(Me.TXTLadoC)
        Me.Controls.Add(Me.TXTLadoB)
        Me.Controls.Add(Me.BTNExibir)
        Me.Controls.Add(Me.LLadoC)
        Me.Controls.Add(Me.LLadoB)
        Me.Controls.Add(Me.LLadoA)
        Me.Controls.Add(Me.TXTLadoA)
        Me.Name = "ftipos"
        Me.Text = "Tipos de Triângulo"
        CType(Me.PBIsosceles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEscaleno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEquilatero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTLadoA As System.Windows.Forms.TextBox
    Friend WithEvents LLadoA As System.Windows.Forms.Label
    Friend WithEvents LLadoB As System.Windows.Forms.Label
    Friend WithEvents LLadoC As System.Windows.Forms.Label
    Friend WithEvents BTNExibir As System.Windows.Forms.Button
    Friend WithEvents TXTLadoB As System.Windows.Forms.TextBox
    Friend WithEvents TXTLadoC As System.Windows.Forms.TextBox
    Friend WithEvents TXTSituacao As System.Windows.Forms.TextBox
    Friend WithEvents LTipo As System.Windows.Forms.Label
    Friend WithEvents PBIsosceles As System.Windows.Forms.PictureBox
    Friend WithEvents PBEscaleno As System.Windows.Forms.PictureBox
    Friend WithEvents PBEquilatero As System.Windows.Forms.PictureBox

End Class
