<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmaindoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmaindoctor))
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Cmdmain = New System.Windows.Forms.Button()
        Me.Cmdend = New System.Windows.Forms.Button()
        Me.CmdHelp = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btndocview = New System.Windows.Forms.Button()
        Me.btnpatview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button13
        '
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button13.Location = New System.Drawing.Point(362, -31)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(134, 32)
        Me.Button13.TabIndex = 58
        Me.Button13.Text = "Create appoinment"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button14.Location = New System.Drawing.Point(206, -31)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(134, 32)
        Me.Button14.TabIndex = 57
        Me.Button14.Text = "Admit patient "
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button12.Location = New System.Drawing.Point(540, 382)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(134, 32)
        Me.Button12.TabIndex = 56
        Me.Button12.Text = "Prescription Records"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button10.Location = New System.Drawing.Point(540, 275)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(134, 32)
        Me.Button10.TabIndex = 54
        Me.Button10.Text = " Medicine Database"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Location = New System.Drawing.Point(540, 330)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(134, 32)
        Me.Button9.TabIndex = 53
        Me.Button9.Text = "Operations Database"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button8.Location = New System.Drawing.Point(540, 220)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(134, 32)
        Me.Button8.TabIndex = 52
        Me.Button8.Text = "Tests Database"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Cmdmain
        '
        Me.Cmdmain.Location = New System.Drawing.Point(552, 515)
        Me.Cmdmain.Name = "Cmdmain"
        Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
        Me.Cmdmain.TabIndex = 44
        Me.Cmdmain.Text = "Return to Login"
        Me.Cmdmain.UseVisualStyleBackColor = True
        '
        'Cmdend
        '
        Me.Cmdend.Location = New System.Drawing.Point(646, 515)
        Me.Cmdend.Name = "Cmdend"
        Me.Cmdend.Size = New System.Drawing.Size(61, 33)
        Me.Cmdend.TabIndex = 43
        Me.Cmdend.Text = "Exit"
        Me.Cmdend.UseVisualStyleBackColor = True
        '
        'CmdHelp
        '
        Me.CmdHelp.Location = New System.Drawing.Point(509, 515)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
        Me.CmdHelp.TabIndex = 42
        Me.CmdHelp.Text = "Help"
        Me.CmdHelp.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 566)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1047, 22)
        Me.StatusStrip1.TabIndex = 41
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Felix Titling", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(221, -115)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(265, 47)
        Me.lbltitle.TabIndex = 40
        Me.lbltitle.Text = "Main Menu"
        '
        'btndocview
        '
        Me.btndocview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndocview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btndocview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndocview.Location = New System.Drawing.Point(540, 166)
        Me.btndocview.Name = "btndocview"
        Me.btndocview.Size = New System.Drawing.Size(134, 32)
        Me.btndocview.TabIndex = 39
        Me.btndocview.Text = "View your data"
        Me.btndocview.UseVisualStyleBackColor = True
        '
        'btnpatview
        '
        Me.btnpatview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnpatview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnpatview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnpatview.Location = New System.Drawing.Point(540, 113)
        Me.btnpatview.Name = "btnpatview"
        Me.btnpatview.Size = New System.Drawing.Size(134, 32)
        Me.btnpatview.TabIndex = 38
        Me.btnpatview.Text = "View patient records"
        Me.btnpatview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 47)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Main Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(825, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 208)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'frmmaindoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1047, 588)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Cmdmain)
        Me.Controls.Add(Me.Cmdend)
        Me.Controls.Add(Me.CmdHelp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btndocview)
        Me.Controls.Add(Me.btnpatview)
        Me.Name = "frmmaindoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Cmdmain As System.Windows.Forms.Button
    Friend WithEvents Cmdend As System.Windows.Forms.Button
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btndocview As System.Windows.Forms.Button
    Friend WithEvents btnpatview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
