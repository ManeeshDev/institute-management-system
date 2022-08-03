<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourse))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.rdioFtime = New System.Windows.Forms.RadioButton()
        Me.rdioPtime = New System.Windows.Forms.RadioButton()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSrchBox = New System.Windows.Forms.TextBox()
        Me.lnkStDt = New System.Windows.Forms.LinkLabel()
        Me.lnkCrsMo = New System.Windows.Forms.LinkLabel()
        Me.lnkClearForm = New System.Windows.Forms.LinkLabel()
        Me.lnkVwTables = New System.Windows.Forms.LinkLabel()
        Me.btnSrchClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Duration"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Course Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Course Fee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NVQ Level"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(150, 145)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(127, 21)
        Me.txtCode.TabIndex = 3
        '
        'txtCName
        '
        Me.txtCName.BackColor = System.Drawing.Color.White
        Me.txtCName.Location = New System.Drawing.Point(150, 186)
        Me.txtCName.Multiline = True
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(127, 21)
        Me.txtCName.TabIndex = 4
        '
        'cmbDuration
        '
        Me.cmbDuration.BackColor = System.Drawing.Color.White
        Me.cmbDuration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDuration.FormattingEnabled = True
        Me.cmbDuration.Items.AddRange(New Object() {"12 months", "06 months", "03 months", "100 hours"})
        Me.cmbDuration.Location = New System.Drawing.Point(150, 229)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.Size = New System.Drawing.Size(127, 21)
        Me.cmbDuration.TabIndex = 5
        '
        'rdioFtime
        '
        Me.rdioFtime.AutoSize = True
        Me.rdioFtime.BackColor = System.Drawing.Color.Transparent
        Me.rdioFtime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioFtime.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioFtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdioFtime.Location = New System.Drawing.Point(161, 274)
        Me.rdioFtime.Name = "rdioFtime"
        Me.rdioFtime.Size = New System.Drawing.Size(69, 21)
        Me.rdioFtime.TabIndex = 6
        Me.rdioFtime.TabStop = True
        Me.rdioFtime.Text = "Full Time"
        Me.rdioFtime.UseVisualStyleBackColor = False
        '
        'rdioPtime
        '
        Me.rdioPtime.AutoSize = True
        Me.rdioPtime.BackColor = System.Drawing.Color.Transparent
        Me.rdioPtime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioPtime.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioPtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdioPtime.Location = New System.Drawing.Point(161, 298)
        Me.rdioPtime.Name = "rdioPtime"
        Me.rdioPtime.Size = New System.Drawing.Size(71, 21)
        Me.rdioPtime.TabIndex = 7
        Me.rdioPtime.TabStop = True
        Me.rdioPtime.Text = "Part Time"
        Me.rdioPtime.UseVisualStyleBackColor = False
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.Color.White
        Me.txtFee.Location = New System.Drawing.Point(150, 341)
        Me.txtFee.Multiline = True
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(127, 21)
        Me.txtFee.TabIndex = 8
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.Color.White
        Me.cmbLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"NVQ Level 3", "NVQ Level 4", "NVQ Level 5", "Other"})
        Me.cmbLevel.Location = New System.Drawing.Point(150, 383)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(127, 21)
        Me.cmbLevel.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(318, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(151, 48)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Silver
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(318, 101)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Silver
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(318, 222)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(151, 33)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Silver
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(318, 286)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(151, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(318, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(99, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "C O U R S E  D E T A I L S "
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(150, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 56)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtSrchBox
        '
        Me.txtSrchBox.BackColor = System.Drawing.Color.White
        Me.txtSrchBox.ForeColor = System.Drawing.Color.DimGray
        Me.txtSrchBox.Location = New System.Drawing.Point(41, 101)
        Me.txtSrchBox.Multiline = True
        Me.txtSrchBox.Name = "txtSrchBox"
        Me.txtSrchBox.Size = New System.Drawing.Size(236, 24)
        Me.txtSrchBox.TabIndex = 1
        Me.txtSrchBox.Text = "Search Course Code Hear :"
        '
        'lnkStDt
        '
        Me.lnkStDt.AutoSize = True
        Me.lnkStDt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkStDt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkStDt.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkStDt.Location = New System.Drawing.Point(391, 395)
        Me.lnkStDt.Name = "lnkStDt"
        Me.lnkStDt.Size = New System.Drawing.Size(79, 13)
        Me.lnkStDt.TabIndex = 15
        Me.lnkStDt.TabStop = True
        Me.lnkStDt.Text = "Student Details"
        '
        'lnkCrsMo
        '
        Me.lnkCrsMo.AutoSize = True
        Me.lnkCrsMo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrsMo.ForeColor = System.Drawing.Color.White
        Me.lnkCrsMo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrsMo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrsMo.Location = New System.Drawing.Point(387, 417)
        Me.lnkCrsMo.Name = "lnkCrsMo"
        Me.lnkCrsMo.Size = New System.Drawing.Size(83, 13)
        Me.lnkCrsMo.TabIndex = 16
        Me.lnkCrsMo.TabStop = True
        Me.lnkCrsMo.Text = "Course Modules"
        '
        'lnkClearForm
        '
        Me.lnkClearForm.AutoSize = True
        Me.lnkClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkClearForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkClearForm.LinkColor = System.Drawing.Color.White
        Me.lnkClearForm.Location = New System.Drawing.Point(223, 417)
        Me.lnkClearForm.Name = "lnkClearForm"
        Me.lnkClearForm.Size = New System.Drawing.Size(57, 13)
        Me.lnkClearForm.TabIndex = 13
        Me.lnkClearForm.TabStop = True
        Me.lnkClearForm.Text = "Clear Form"
        '
        'lnkVwTables
        '
        Me.lnkVwTables.AutoSize = True
        Me.lnkVwTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVwTables.ForeColor = System.Drawing.Color.White
        Me.lnkVwTables.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkVwTables.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkVwTables.Location = New System.Drawing.Point(38, 417)
        Me.lnkVwTables.Name = "lnkVwTables"
        Me.lnkVwTables.Size = New System.Drawing.Size(65, 13)
        Me.lnkVwTables.TabIndex = 17
        Me.lnkVwTables.TabStop = True
        Me.lnkVwTables.Text = "View Tables"
        '
        'btnSrchClear
        '
        Me.btnSrchClear.BackColor = System.Drawing.Color.Silver
        Me.btnSrchClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSrchClear.FlatAppearance.BorderSize = 0
        Me.btnSrchClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnSrchClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSrchClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSrchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrchClear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrchClear.Location = New System.Drawing.Point(439, 101)
        Me.btnSrchClear.Name = "btnSrchClear"
        Me.btnSrchClear.Size = New System.Drawing.Size(30, 24)
        Me.btnSrchClear.TabIndex = 37
        Me.btnSrchClear.Text = "C"
        Me.btnSrchClear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(104, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 10)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSrchClear)
        Me.Controls.Add(Me.lnkVwTables)
        Me.Controls.Add(Me.lnkClearForm)
        Me.Controls.Add(Me.lnkCrsMo)
        Me.Controls.Add(Me.lnkStDt)
        Me.Controls.Add(Me.txtSrchBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rdioPtime)
        Me.Controls.Add(Me.rdioFtime)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.cmbDuration)
        Me.Controls.Add(Me.txtCName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(524, 507)
        Me.MinimumSize = New System.Drawing.Size(524, 507)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCName As System.Windows.Forms.TextBox
    Friend WithEvents cmbDuration As System.Windows.Forms.ComboBox
    Friend WithEvents rdioFtime As System.Windows.Forms.RadioButton
    Friend WithEvents rdioPtime As System.Windows.Forms.RadioButton
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSrchBox As System.Windows.Forms.TextBox
    Friend WithEvents lnkStDt As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCrsMo As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkClearForm As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkVwTables As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSrchClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
