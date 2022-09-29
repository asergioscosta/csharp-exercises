<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOKOnly
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
        Me.BTNInformation = New System.Windows.Forms.Button()
        Me.BTNExclamation = New System.Windows.Forms.Button()
        Me.BTNCritical = New System.Windows.Forms.Button()
        Me.BTNRetryCancel = New System.Windows.Forms.Button()
        Me.BTNYesNo = New System.Windows.Forms.Button()
        Me.BTNYesNoCancel = New System.Windows.Forms.Button()
        Me.BTNAboutRetryIgnore = New System.Windows.Forms.Button()
        Me.BTNOKOnly = New System.Windows.Forms.Button()
        Me.BTNOkCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNInformation
        '
        Me.BTNInformation.Location = New System.Drawing.Point(179, 227)
        Me.BTNInformation.Name = "BTNInformation"
        Me.BTNInformation.Size = New System.Drawing.Size(75, 23)
        Me.BTNInformation.TabIndex = 0
        Me.BTNInformation.Text = "Information"
        Me.BTNInformation.UseVisualStyleBackColor = True
        '
        'BTNExclamation
        '
        Me.BTNExclamation.Location = New System.Drawing.Point(179, 198)
        Me.BTNExclamation.Name = "BTNExclamation"
        Me.BTNExclamation.Size = New System.Drawing.Size(75, 23)
        Me.BTNExclamation.TabIndex = 1
        Me.BTNExclamation.Text = "Exclamation"
        Me.BTNExclamation.UseVisualStyleBackColor = True
        '
        'BTNCritical
        '
        Me.BTNCritical.Location = New System.Drawing.Point(179, 169)
        Me.BTNCritical.Name = "BTNCritical"
        Me.BTNCritical.Size = New System.Drawing.Size(75, 23)
        Me.BTNCritical.TabIndex = 2
        Me.BTNCritical.Text = "Critical"
        Me.BTNCritical.UseVisualStyleBackColor = True
        '
        'BTNRetryCancel
        '
        Me.BTNRetryCancel.Location = New System.Drawing.Point(179, 140)
        Me.BTNRetryCancel.Name = "BTNRetryCancel"
        Me.BTNRetryCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTNRetryCancel.TabIndex = 3
        Me.BTNRetryCancel.Text = "Retry Cancel"
        Me.BTNRetryCancel.UseVisualStyleBackColor = True
        '
        'BTNYesNo
        '
        Me.BTNYesNo.Location = New System.Drawing.Point(179, 111)
        Me.BTNYesNo.Name = "BTNYesNo"
        Me.BTNYesNo.Size = New System.Drawing.Size(75, 23)
        Me.BTNYesNo.TabIndex = 4
        Me.BTNYesNo.Text = "Yes No"
        Me.BTNYesNo.UseVisualStyleBackColor = True
        '
        'BTNYesNoCancel
        '
        Me.BTNYesNoCancel.Location = New System.Drawing.Point(179, 82)
        Me.BTNYesNoCancel.Name = "BTNYesNoCancel"
        Me.BTNYesNoCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTNYesNoCancel.TabIndex = 5
        Me.BTNYesNoCancel.Text = "YN Cancel"
        Me.BTNYesNoCancel.UseVisualStyleBackColor = True
        '
        'BTNAboutRetryIgnore
        '
        Me.BTNAboutRetryIgnore.Location = New System.Drawing.Point(179, 53)
        Me.BTNAboutRetryIgnore.Name = "BTNAboutRetryIgnore"
        Me.BTNAboutRetryIgnore.Size = New System.Drawing.Size(75, 23)
        Me.BTNAboutRetryIgnore.TabIndex = 6
        Me.BTNAboutRetryIgnore.Text = "About RC"
        Me.BTNAboutRetryIgnore.UseVisualStyleBackColor = True
        '
        'BTNOKOnly
        '
        Me.BTNOKOnly.Location = New System.Drawing.Point(179, 24)
        Me.BTNOKOnly.Name = "BTNOKOnly"
        Me.BTNOKOnly.Size = New System.Drawing.Size(75, 23)
        Me.BTNOKOnly.TabIndex = 7
        Me.BTNOKOnly.Text = "OK"
        Me.BTNOKOnly.UseVisualStyleBackColor = True
        '
        'BTNOkCancel
        '
        Me.BTNOkCancel.Location = New System.Drawing.Point(179, -5)
        Me.BTNOkCancel.Name = "BTNOkCancel"
        Me.BTNOkCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTNOkCancel.TabIndex = 8
        Me.BTNOkCancel.Text = "OK Cancel"
        Me.BTNOkCancel.UseVisualStyleBackColor = True
        '
        'FOKOnly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BTNOkCancel)
        Me.Controls.Add(Me.BTNOKOnly)
        Me.Controls.Add(Me.BTNAboutRetryIgnore)
        Me.Controls.Add(Me.BTNYesNoCancel)
        Me.Controls.Add(Me.BTNYesNo)
        Me.Controls.Add(Me.BTNRetryCancel)
        Me.Controls.Add(Me.BTNCritical)
        Me.Controls.Add(Me.BTNExclamation)
        Me.Controls.Add(Me.BTNInformation)
        Me.Name = "FOKOnly"
        Me.Text = "OKOnly"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNInformation As System.Windows.Forms.Button
    Friend WithEvents BTNExclamation As System.Windows.Forms.Button
    Friend WithEvents BTNCritical As System.Windows.Forms.Button
    Friend WithEvents BTNRetryCancel As System.Windows.Forms.Button
    Friend WithEvents BTNYesNo As System.Windows.Forms.Button
    Friend WithEvents BTNYesNoCancel As System.Windows.Forms.Button
    Friend WithEvents BTNAboutRetryIgnore As System.Windows.Forms.Button
    Friend WithEvents BTNOKOnly As System.Windows.Forms.Button
    Friend WithEvents BTNOkCancel As System.Windows.Forms.Button

End Class
