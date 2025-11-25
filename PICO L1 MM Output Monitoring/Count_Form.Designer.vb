<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Count_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTTC1A = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblFC1A = New System.Windows.Forms.Label()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTC1A = New System.Windows.Forms.Label()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox6 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTTC1B = New System.Windows.Forms.Label()
        Me.Guna2GroupBox7 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblFC1B = New System.Windows.Forms.Label()
        Me.Guna2GroupBox8 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTC1B = New System.Windows.Forms.Label()
        Me.TimerTrig = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2GroupBox9 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox5.SuspendLayout()
        Me.Guna2GroupBox6.SuspendLayout()
        Me.Guna2GroupBox7.SuspendLayout()
        Me.Guna2GroupBox8.SuspendLayout()
        Me.Guna2GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 15
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 35.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(577, 444)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Line 1A"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox4.BorderThickness = 4
        Me.Guna2GroupBox4.Controls.Add(Me.lblTTC1A)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(43, 66)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox4.TabIndex = 2
        Me.Guna2GroupBox4.Text = "Tray Count"
        Me.Guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTTC1A
        '
        Me.lblTTC1A.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTC1A.ForeColor = System.Drawing.Color.Black
        Me.lblTTC1A.Location = New System.Drawing.Point(16, 44)
        Me.lblTTC1A.Name = "lblTTC1A"
        Me.lblTTC1A.Size = New System.Drawing.Size(477, 102)
        Me.lblTTC1A.TabIndex = 0
        Me.lblTTC1A.Text = "0"
        Me.lblTTC1A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Guna2GroupBox2.BorderThickness = 4
        Me.Guna2GroupBox2.Controls.Add(Me.lblFC1A)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(31, 255)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox2.TabIndex = 1
        Me.Guna2GroupBox2.Text = "Fuse Count"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFC1A
        '
        Me.lblFC1A.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFC1A.ForeColor = System.Drawing.Color.Black
        Me.lblFC1A.Location = New System.Drawing.Point(16, 44)
        Me.lblFC1A.Name = "lblFC1A"
        Me.lblFC1A.Size = New System.Drawing.Size(477, 102)
        Me.lblFC1A.TabIndex = 0
        Me.lblFC1A.Text = "0"
        Me.lblFC1A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox3.BorderThickness = 4
        Me.Guna2GroupBox3.Controls.Add(Me.lblTC1A)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(31, 67)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox3.TabIndex = 0
        Me.Guna2GroupBox3.Text = "Tray Count"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTC1A
        '
        Me.lblTC1A.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC1A.ForeColor = System.Drawing.Color.Black
        Me.lblTC1A.Location = New System.Drawing.Point(16, 44)
        Me.lblTC1A.Name = "lblTC1A"
        Me.lblTC1A.Size = New System.Drawing.Size(477, 102)
        Me.lblTC1A.TabIndex = 0
        Me.lblTC1A.Text = "0"
        Me.lblTC1A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox5
        '
        Me.Guna2GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox5.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox5.BorderRadius = 15
        Me.Guna2GroupBox5.BorderThickness = 5
        Me.Guna2GroupBox5.Controls.Add(Me.Guna2GroupBox7)
        Me.Guna2GroupBox5.Controls.Add(Me.Guna2GroupBox8)
        Me.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox5.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox5.Font = New System.Drawing.Font("Segoe UI Black", 35.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(611, 74)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(577, 444)
        Me.Guna2GroupBox5.TabIndex = 3
        Me.Guna2GroupBox5.Text = "Line 1B"
        Me.Guna2GroupBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox5.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Guna2GroupBox6
        '
        Me.Guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox6.BorderThickness = 4
        Me.Guna2GroupBox6.Controls.Add(Me.lblTTC1B)
        Me.Guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox6.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox6.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox6.Location = New System.Drawing.Point(612, 66)
        Me.Guna2GroupBox6.Name = "Guna2GroupBox6"
        Me.Guna2GroupBox6.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox6.TabIndex = 2
        Me.Guna2GroupBox6.Text = "Fuse Count"
        Me.Guna2GroupBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTTC1B
        '
        Me.lblTTC1B.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTC1B.ForeColor = System.Drawing.Color.Black
        Me.lblTTC1B.Location = New System.Drawing.Point(16, 44)
        Me.lblTTC1B.Name = "lblTTC1B"
        Me.lblTTC1B.Size = New System.Drawing.Size(477, 102)
        Me.lblTTC1B.TabIndex = 0
        Me.lblTTC1B.Text = "0"
        Me.lblTTC1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox7
        '
        Me.Guna2GroupBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Guna2GroupBox7.BorderThickness = 4
        Me.Guna2GroupBox7.Controls.Add(Me.lblFC1B)
        Me.Guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Guna2GroupBox7.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox7.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox7.Location = New System.Drawing.Point(31, 255)
        Me.Guna2GroupBox7.Name = "Guna2GroupBox7"
        Me.Guna2GroupBox7.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox7.TabIndex = 1
        Me.Guna2GroupBox7.Text = "Fuse Count"
        Me.Guna2GroupBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFC1B
        '
        Me.lblFC1B.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFC1B.ForeColor = System.Drawing.Color.Black
        Me.lblFC1B.Location = New System.Drawing.Point(16, 44)
        Me.lblFC1B.Name = "lblFC1B"
        Me.lblFC1B.Size = New System.Drawing.Size(477, 102)
        Me.lblFC1B.TabIndex = 0
        Me.lblFC1B.Text = "0"
        Me.lblFC1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox8
        '
        Me.Guna2GroupBox8.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox8.BorderThickness = 4
        Me.Guna2GroupBox8.Controls.Add(Me.lblTC1B)
        Me.Guna2GroupBox8.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox8.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox8.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox8.Location = New System.Drawing.Point(31, 67)
        Me.Guna2GroupBox8.Name = "Guna2GroupBox8"
        Me.Guna2GroupBox8.Size = New System.Drawing.Size(511, 155)
        Me.Guna2GroupBox8.TabIndex = 0
        Me.Guna2GroupBox8.Text = "Tray Count"
        Me.Guna2GroupBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTC1B
        '
        Me.lblTC1B.Font = New System.Drawing.Font("Segoe UI Black", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC1B.ForeColor = System.Drawing.Color.Black
        Me.lblTC1B.Location = New System.Drawing.Point(16, 44)
        Me.lblTC1B.Name = "lblTC1B"
        Me.lblTC1B.Size = New System.Drawing.Size(477, 102)
        Me.lblTC1B.TabIndex = 0
        Me.lblTC1B.Text = "0"
        Me.lblTC1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerTrig
        '
        Me.TimerTrig.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Guna2GroupBox9
        '
        Me.Guna2GroupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox9.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox9.BorderRadius = 15
        Me.Guna2GroupBox9.BorderThickness = 5
        Me.Guna2GroupBox9.Controls.Add(Me.Guna2GroupBox4)
        Me.Guna2GroupBox9.Controls.Add(Me.Guna2GroupBox6)
        Me.Guna2GroupBox9.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox9.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox9.Font = New System.Drawing.Font("Segoe UI Black", 35.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox9.Location = New System.Drawing.Point(12, 567)
        Me.Guna2GroupBox9.Name = "Guna2GroupBox9"
        Me.Guna2GroupBox9.Size = New System.Drawing.Size(1176, 255)
        Me.Guna2GroupBox9.TabIndex = 4
        Me.Guna2GroupBox9.Text = "Line 1 Total"
        Me.Guna2GroupBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox9.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Count_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.ClientSize = New System.Drawing.Size(1200, 919)
        Me.Controls.Add(Me.Guna2GroupBox9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Guna2GroupBox5)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Count_Form"
        Me.Text = "Count_Form"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox5.ResumeLayout(False)
        Me.Guna2GroupBox6.ResumeLayout(False)
        Me.Guna2GroupBox7.ResumeLayout(False)
        Me.Guna2GroupBox8.ResumeLayout(False)
        Me.Guna2GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTC1A As Label
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTTC1A As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblFC1A As Label
    Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox6 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTTC1B As Label
    Friend WithEvents Guna2GroupBox7 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblFC1B As Label
    Friend WithEvents Guna2GroupBox8 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTC1B As Label
    Friend WithEvents TimerTrig As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2GroupBox9 As Guna.UI2.WinForms.Guna2GroupBox
End Class
