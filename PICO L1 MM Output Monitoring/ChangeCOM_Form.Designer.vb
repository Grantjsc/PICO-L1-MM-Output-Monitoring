<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeCOM_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeCOM_Form))
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnChange = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCOM = New System.Windows.Forms.ComboBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.BorderThickness = 7
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GroupBoxTitle)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(469, 373)
        Me.Guna2CustomGradientPanel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnClose.Location = New System.Drawing.Point(408, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.DarkGray
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(45, 45)
        Me.btnClose.TabIndex = 9
        '
        'GroupBoxTitle
        '
        Me.GroupBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.BorderColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.BorderRadius = 10
        Me.GroupBoxTitle.BorderThickness = 5
        Me.GroupBoxTitle.Controls.Add(Me.btnChange)
        Me.GroupBoxTitle.Controls.Add(Me.Label1)
        Me.GroupBoxTitle.Controls.Add(Me.cboCOM)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.Location = New System.Drawing.Point(72, 89)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(316, 204)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.Text = "Change COM name"
        Me.GroupBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnChange.BorderRadius = 10
        Me.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChange.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChange.FillColor = System.Drawing.Color.Orange
        Me.btnChange.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.Black
        Me.btnChange.Location = New System.Drawing.Point(113, 118)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.ShadowDecoration.BorderRadius = 10
        Me.btnChange.ShadowDecoration.Depth = 17
        Me.btnChange.ShadowDecoration.Enabled = True
        Me.btnChange.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnChange.Size = New System.Drawing.Size(104, 38)
        Me.btnChange.TabIndex = 82
        Me.btnChange.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Available COM:"
        '
        'cboCOM
        '
        Me.cboCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOM.FormattingEnabled = True
        Me.cboCOM.Location = New System.Drawing.Point(88, 73)
        Me.cboCOM.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCOM.Name = "cboCOM"
        Me.cboCOM.Size = New System.Drawing.Size(152, 28)
        Me.cboCOM.TabIndex = 83
        '
        'ChangeCOM_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 373)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangeCOM_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangeCOM_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCOM As ComboBox
End Class
