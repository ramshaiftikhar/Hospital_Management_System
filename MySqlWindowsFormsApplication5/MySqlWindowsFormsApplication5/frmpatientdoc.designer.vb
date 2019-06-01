' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Namespace MySqlWindowsFormsApplication5
	
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmpatientdoc
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpatientdoc))
            Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
            Me.patientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.newDataSet = New NewDataSet()
            Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
            Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
            Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Cmdmain = New System.Windows.Forms.Button()
            Me.Cmdend = New System.Windows.Forms.Button()
            Me.CmdHelp = New System.Windows.Forms.Button()
            Me.Patview1ToolStrip = New System.Windows.Forms.ToolStrip()
            Me.Patient_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
            Me.Patient_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
            Me.Patview1ToolStripButton = New System.Windows.Forms.ToolStripButton()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MobnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DichargedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PatientBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
            Me.HospitalDataSet1 = New hospitalDataSet1()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            Me.PatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.PatientTableAdapter = New hospitalDataSet1TableAdapters.patientTableAdapter()
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.BindingNavigator1.SuspendLayout()
            CType(Me.patientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Patview1ToolStrip.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BindingNavigator1
            '
            Me.BindingNavigator1.AddNewItem = Nothing
            Me.BindingNavigator1.BindingSource = Me.patientBindingSource
            Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
            Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
            Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
            Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
            Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
            Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
            Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
            Me.BindingNavigator1.Name = "BindingNavigator1"
            Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
            Me.BindingNavigator1.Size = New System.Drawing.Size(1078, 25)
            Me.BindingNavigator1.TabIndex = 0
            Me.BindingNavigator1.Text = "BindingNavigator1"
            '
            'patientBindingSource
            '
            Me.patientBindingSource.DataMember = "patient"
            Me.patientBindingSource.DataSource = Me.newDataSet
            '
            'newDataSet
            '
            Me.newDataSet.DataSetName = "NewDataSet"
            Me.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'BindingNavigatorCountItem
            '
            Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
            Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
            Me.BindingNavigatorCountItem.Text = "of {0}"
            Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
            '
            'BindingNavigatorDeleteItem
            '
            Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorDeleteItem.Enabled = False
            Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
            Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorDeleteItem.Text = "Delete"
            '
            'BindingNavigatorMoveFirstItem
            '
            Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
            Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorMoveFirstItem.Text = "Move first"
            '
            'BindingNavigatorMovePreviousItem
            '
            Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
            Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
            '
            'BindingNavigatorSeparator
            '
            Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
            Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
            '
            'BindingNavigatorPositionItem
            '
            Me.BindingNavigatorPositionItem.AccessibleName = "Position"
            Me.BindingNavigatorPositionItem.AutoSize = False
            Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
            Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
            Me.BindingNavigatorPositionItem.Text = "0"
            Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
            '
            'BindingNavigatorSeparator1
            '
            Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
            Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'BindingNavigatorMoveNextItem
            '
            Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
            Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorMoveNextItem.Text = "Move next"
            '
            'BindingNavigatorMoveLastItem
            '
            Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
            Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorMoveLastItem.Text = "Move last"
            '
            'BindingNavigatorSeparator2
            '
            Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
            Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'BindingNavigatorAddNewItem
            '
            Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorAddNewItem.Enabled = False
            Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
            Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorAddNewItem.Text = "Add new"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Enabled = False
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButton1.Text = "Save"
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.Panel1)
            Me.panel3.Controls.Add(Me.panel4)
            Me.panel3.Controls.Add(Me.panel5)
            Me.panel3.Controls.Add(Me.panel6)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(0, 25)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1078, 433)
            Me.panel3.TabIndex = 19
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.AutoSize = True
            Me.Panel1.BackgroundImage = Global.MySqlWindowsFormsApplication5.My.Resources.Resources._6800415_light_blue_backgrounds
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.Cmdmain)
            Me.Panel1.Controls.Add(Me.Cmdend)
            Me.Panel1.Controls.Add(Me.CmdHelp)
            Me.Panel1.Controls.Add(Me.Patview1ToolStrip)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(10, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1058, 423)
            Me.Panel1.TabIndex = 1
            '
            'Cmdmain
            '
            Me.Cmdmain.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdmain.FlatAppearance.BorderSize = 4
            Me.Cmdmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdmain.Location = New System.Drawing.Point(551, 364)
            Me.Cmdmain.Name = "Cmdmain"
            Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
            Me.Cmdmain.TabIndex = 50
            Me.Cmdmain.Text = "Return to Main"
            Me.Cmdmain.UseVisualStyleBackColor = True
            '
            'Cmdend
            '
            Me.Cmdend.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdend.FlatAppearance.BorderSize = 4
            Me.Cmdend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdend.Location = New System.Drawing.Point(645, 364)
            Me.Cmdend.Name = "Cmdend"
            Me.Cmdend.Size = New System.Drawing.Size(61, 33)
            Me.Cmdend.TabIndex = 49
            Me.Cmdend.Text = "Exit"
            Me.Cmdend.UseVisualStyleBackColor = True
            '
            'CmdHelp
            '
            Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.CmdHelp.FlatAppearance.BorderSize = 4
            Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CmdHelp.Location = New System.Drawing.Point(508, 364)
            Me.CmdHelp.Name = "CmdHelp"
            Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
            Me.CmdHelp.TabIndex = 48
            Me.CmdHelp.Text = "Help"
            Me.CmdHelp.UseVisualStyleBackColor = True
            '
            'Patview1ToolStrip
            '
            Me.Patview1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
            Me.Patview1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Patient_IDToolStripLabel, Me.Patient_IDToolStripTextBox, Me.Patview1ToolStripButton})
            Me.Patview1ToolStrip.Location = New System.Drawing.Point(448, 71)
            Me.Patview1ToolStrip.Name = "Patview1ToolStrip"
            Me.Patview1ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.Patview1ToolStrip.Size = New System.Drawing.Size(285, 25)
            Me.Patview1ToolStrip.TabIndex = 21
            Me.Patview1ToolStrip.Text = "Patview1ToolStrip"
            '
            'Patient_IDToolStripLabel
            '
            Me.Patient_IDToolStripLabel.Name = "Patient_IDToolStripLabel"
            Me.Patient_IDToolStripLabel.Size = New System.Drawing.Size(63, 22)
            Me.Patient_IDToolStripLabel.Text = "Patient_ID:"
            '
            'Patient_IDToolStripTextBox
            '
            Me.Patient_IDToolStripTextBox.Name = "Patient_IDToolStripTextBox"
            Me.Patient_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
            '
            'Patview1ToolStripButton
            '
            Me.Patview1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.Patview1ToolStripButton.Name = "Patview1ToolStripButton"
            Me.Patview1ToolStripButton.Size = New System.Drawing.Size(77, 22)
            Me.Patview1ToolStripButton.Text = "Load Patient"
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.MobnumDataGridViewTextBoxColumn, Me.DichargedDataGridViewTextBoxColumn})
            Me.DataGridView1.DataSource = Me.PatientBindingSource2
            Me.DataGridView1.Location = New System.Drawing.Point(193, 120)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(826, 219)
            Me.DataGridView1.TabIndex = 18
            '
            'PatientIDDataGridViewTextBoxColumn
            '
            Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID"
            Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID"
            Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
            Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
            '
            'PatientNameDataGridViewTextBoxColumn
            '
            Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name"
            Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient_Name"
            Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
            Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AgeDataGridViewTextBoxColumn
            '
            Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
            Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
            Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
            Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
            '
            'GenderDataGridViewTextBoxColumn
            '
            Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
            Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
            Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
            Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AddressDataGridViewTextBoxColumn
            '
            Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
            Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
            Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
            Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
            '
            'DOBDataGridViewTextBoxColumn
            '
            Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "D-O-B"
            Me.DOBDataGridViewTextBoxColumn.HeaderText = "D-O-B"
            Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
            Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
            '
            'MobnumDataGridViewTextBoxColumn
            '
            Me.MobnumDataGridViewTextBoxColumn.DataPropertyName = "Mob_num"
            Me.MobnumDataGridViewTextBoxColumn.HeaderText = "Mob_num"
            Me.MobnumDataGridViewTextBoxColumn.Name = "MobnumDataGridViewTextBoxColumn"
            Me.MobnumDataGridViewTextBoxColumn.ReadOnly = True
            '
            'DichargedDataGridViewTextBoxColumn
            '
            Me.DichargedDataGridViewTextBoxColumn.DataPropertyName = "Dicharged"
            Me.DichargedDataGridViewTextBoxColumn.HeaderText = "Dicharged"
            Me.DichargedDataGridViewTextBoxColumn.Name = "DichargedDataGridViewTextBoxColumn"
            Me.DichargedDataGridViewTextBoxColumn.ReadOnly = True
            '
            'PatientBindingSource2
            '
            Me.PatientBindingSource2.DataMember = "patient"
            Me.PatientBindingSource2.DataSource = Me.HospitalDataSet1
            '
            'HospitalDataSet1
            '
            Me.HospitalDataSet1.DataSetName = "hospitalDataSet1"
            Me.HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(417, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(365, 41)
            Me.Label1.TabIndex = 17
            Me.Label1.Text = "Patient Information"
            '
            'panel4
            '
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel4.Location = New System.Drawing.Point(1068, 0)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(10, 423)
            Me.panel4.TabIndex = 3
            '
            'panel5
            '
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(10, 423)
            Me.panel5.TabIndex = 5
            '
            'panel6
            '
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel6.Location = New System.Drawing.Point(0, 423)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(1078, 10)
            Me.panel6.TabIndex = 6
            '
            'PatientBindingSource1
            '
            Me.PatientBindingSource1.DataMember = "patient"
            Me.PatientBindingSource1.DataSource = Me.newDataSet
            '
            'PatientTableAdapter
            '
            Me.PatientTableAdapter.ClearBeforeFill = True
            '
            'frmpatientdoc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1078, 458)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.BindingNavigator1)
            Me.Name = "frmpatientdoc"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Patient"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.BindingNavigator1.ResumeLayout(False)
            Me.BindingNavigator1.PerformLayout()
            CType(Me.patientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Patview1ToolStrip.ResumeLayout(False)
            Me.Patview1ToolStrip.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
        Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
        Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents newDataSet As NewDataSet
        Friend WithEvents patientBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents panel4 As System.Windows.Forms.Panel
        Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents panel6 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents PatientBindingSource1 As System.Windows.Forms.BindingSource
        Friend WithEvents HospitalDataSet1 As hospitalDataSet1
        Friend WithEvents PatientBindingSource2 As System.Windows.Forms.BindingSource
        Friend WithEvents PatientTableAdapter As hospitalDataSet1TableAdapters.patientTableAdapter
        Friend WithEvents PatientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PatientNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents MobnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DichargedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Patview1ToolStrip As System.Windows.Forms.ToolStrip
        Friend WithEvents Patient_IDToolStripLabel As System.Windows.Forms.ToolStripLabel
        Friend WithEvents Patient_IDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents Patview1ToolStripButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents Cmdmain As System.Windows.Forms.Button
        Friend WithEvents Cmdend As System.Windows.Forms.Button
        Friend WithEvents CmdHelp As System.Windows.Forms.Button

    End Class
	
End Namespace