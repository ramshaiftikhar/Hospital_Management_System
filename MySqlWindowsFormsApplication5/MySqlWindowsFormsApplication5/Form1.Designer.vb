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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cmdmain = New System.Windows.Forms.Button()
        Me.Cmdend = New System.Windows.Forms.Button()
        Me.CmdHelp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.MySqlWindowsFormsApplication5.My.Resources.Resources.Hospital_Map_700
        Me.PictureBox1.InitialImage = Global.MySqlWindowsFormsApplication5.My.Resources.Resources.Hospital_Map_700
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 496)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Cmdmain
        '
        Me.Cmdmain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmdmain.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cmdmain.FlatAppearance.BorderSize = 4
        Me.Cmdmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.Cmdmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmdmain.Location = New System.Drawing.Point(894, 12)
        Me.Cmdmain.Name = "Cmdmain"
        Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
        Me.Cmdmain.TabIndex = 53
        Me.Cmdmain.Text = "Return to Main"
        Me.Cmdmain.UseVisualStyleBackColor = True
        '
        'Cmdend
        '
        Me.Cmdend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmdend.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cmdend.FlatAppearance.BorderSize = 4
        Me.Cmdend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.Cmdend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmdend.Location = New System.Drawing.Point(988, 12)
        Me.Cmdend.Name = "Cmdend"
        Me.Cmdend.Size = New System.Drawing.Size(61, 33)
        Me.Cmdend.TabIndex = 52
        Me.Cmdend.Text = "Exit"
        Me.Cmdend.UseVisualStyleBackColor = True
        '
        'CmdHelp
        '
        Me.CmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CmdHelp.FlatAppearance.BorderSize = 4
        Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdHelp.Location = New System.Drawing.Point(851, 12)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
        Me.CmdHelp.TabIndex = 51
        Me.CmdHelp.Text = "Help"
        Me.CmdHelp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 496)
        Me.Controls.Add(Me.Cmdmain)
        Me.Controls.Add(Me.Cmdend)
        Me.Controls.Add(Me.CmdHelp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cmdmain As System.Windows.Forms.Button
    Friend WithEvents Cmdend As System.Windows.Forms.Button
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
End Class
