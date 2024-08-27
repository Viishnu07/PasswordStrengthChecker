<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblProgressbar = New System.Windows.Forms.Label()
        Me.pbStrength = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(255, 132)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(250, 22)
        Me.txtPwd.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(147, 138)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblProgressbar
        '
        Me.lblProgressbar.AutoSize = True
        Me.lblProgressbar.Location = New System.Drawing.Point(147, 342)
        Me.lblProgressbar.Name = "lblProgressbar"
        Me.lblProgressbar.Size = New System.Drawing.Size(119, 16)
        Me.lblProgressbar.TabIndex = 2
        Me.lblProgressbar.Text = "Password Strength"
        '
        'pbStrength
        '
        Me.pbStrength.Location = New System.Drawing.Point(150, 245)
        Me.pbStrength.Name = "pbStrength"
        Me.pbStrength.Size = New System.Drawing.Size(458, 54)
        Me.pbStrength.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbStrength)
        Me.Controls.Add(Me.lblProgressbar)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPwd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPwd As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblProgressbar As Label
    Friend WithEvents pbStrength As ProgressBar
End Class
