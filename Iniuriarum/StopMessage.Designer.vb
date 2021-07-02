<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StopMessage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Press Ctrl-Shift-K to stop logging"
        '
        'start
        '
        Me.start.Animated = True
        Me.start.AutoRoundedCorners = True
        Me.start.BorderRadius = 17
        Me.start.CheckedState.Parent = Me.start
        Me.start.CustomImages.Parent = Me.start
        Me.start.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.start.ForeColor = System.Drawing.Color.White
        Me.start.HoverState.Parent = Me.start
        Me.start.Location = New System.Drawing.Point(61, 56)
        Me.start.Name = "start"
        Me.start.ShadowDecoration.Parent = Me.start
        Me.start.Size = New System.Drawing.Size(130, 37)
        Me.start.TabIndex = 3
        Me.start.Text = "OK..."
        '
        'StopMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(264, 115)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StopMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniuriarum - Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents start As Guna.UI2.WinForms.Guna2Button
End Class
