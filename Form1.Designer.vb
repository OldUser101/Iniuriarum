<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation7 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.writePath = New Guna.UI2.WinForms.Guna2TextBox()
        Me.logStart = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Transition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Iniuriarum"
        '
        'start
        '
        Me.start.Animated = True
        Me.start.AutoRoundedCorners = True
        Me.start.BorderRadius = 17
        Me.start.CheckedState.Parent = Me.start
        Me.start.CustomImages.Parent = Me.start
        Me.Guna2Transition1.SetDecoration(Me.start, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.start.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.start.ForeColor = System.Drawing.Color.White
        Me.start.HoverState.Parent = Me.start
        Me.start.Location = New System.Drawing.Point(125, 68)
        Me.start.Name = "start"
        Me.start.ShadowDecoration.Parent = Me.start
        Me.start.Size = New System.Drawing.Size(130, 37)
        Me.start.TabIndex = 2
        Me.start.Text = "Start..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.start)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 124)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.writePath)
        Me.Panel2.Controls.Add(Me.logStart)
        Me.Guna2Transition1.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 124)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keylogging will be saved at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the following path : "
        '
        'writePath
        '
        Me.writePath.Animated = True
        Me.writePath.AutoRoundedCorners = True
        Me.writePath.BorderRadius = 17
        Me.writePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.writePath, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.writePath.DefaultText = ""
        Me.writePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.writePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.writePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.writePath.DisabledState.Parent = Me.writePath
        Me.writePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.writePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.writePath.FocusedState.Parent = Me.writePath
        Me.writePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.writePath.HoverState.Parent = Me.writePath
        Me.writePath.Location = New System.Drawing.Point(12, 79)
        Me.writePath.Name = "writePath"
        Me.writePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.writePath.PlaceholderText = ""
        Me.writePath.SelectedText = ""
        Me.writePath.ShadowDecoration.Parent = Me.writePath
        Me.writePath.Size = New System.Drawing.Size(140, 37)
        Me.writePath.TabIndex = 3
        '
        'logStart
        '
        Me.logStart.Animated = True
        Me.logStart.AutoRoundedCorners = True
        Me.logStart.BorderRadius = 17
        Me.logStart.CheckedState.Parent = Me.logStart
        Me.logStart.CustomImages.Parent = Me.logStart
        Me.Guna2Transition1.SetDecoration(Me.logStart, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.logStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.logStart.ForeColor = System.Drawing.Color.White
        Me.logStart.HoverState.Parent = Me.logStart
        Me.logStart.Location = New System.Drawing.Point(168, 79)
        Me.logStart.Name = "logStart"
        Me.logStart.ShadowDecoration.Parent = Me.logStart
        Me.logStart.Size = New System.Drawing.Size(115, 37)
        Me.logStart.TabIndex = 2
        Me.logStart.Text = "Begin Logging..."
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation7
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Iniuriarum started keylogging."
        Me.NotifyIcon1.BalloonTipTitle = "Iniuriarum"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Iniuriarum"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(291, 124)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniuriarum"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents writePath As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents logStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
