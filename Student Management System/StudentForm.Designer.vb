<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStDt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStDt))
        Me.rdioFemale = New System.Windows.Forms.RadioButton()
        Me.rdioMale = New System.Windows.Forms.RadioButton()
        Me.cmbPQ = New System.Windows.Forms.ComboBox()
        Me.txtNic = New System.Windows.Forms.TextBox()
        Me.cmbCrsCode = New System.Windows.Forms.ComboBox()
        Me.txtStName = New System.Windows.Forms.TextBox()
        Me.txtStNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chkDeg = New System.Windows.Forms.CheckBox()
        Me.chkAL = New System.Windows.Forms.CheckBox()
        Me.chkOL = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCrsCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lnkClearForm = New System.Windows.Forms.LinkLabel()
        Me.txtSrchBox = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lnkCrs = New System.Windows.Forms.LinkLabel()
        Me.lnkCrsMo = New System.Windows.Forms.LinkLabel()
        Me.lnkVwTables = New System.Windows.Forms.LinkLabel()
        Me.btnSrchClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdioFemale
        '
        Me.rdioFemale.AutoSize = True
        Me.rdioFemale.BackColor = System.Drawing.Color.Transparent
        Me.rdioFemale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioFemale.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdioFemale.Location = New System.Drawing.Point(14, 42)
        Me.rdioFemale.Name = "rdioFemale"
        Me.rdioFemale.Size = New System.Drawing.Size(61, 20)
        Me.rdioFemale.TabIndex = 9
        Me.rdioFemale.TabStop = True
        Me.rdioFemale.Text = "Female"
        Me.rdioFemale.UseVisualStyleBackColor = False
        '
        'rdioMale
        '
        Me.rdioMale.AutoSize = True
        Me.rdioMale.BackColor = System.Drawing.Color.Transparent
        Me.rdioMale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioMale.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdioMale.Location = New System.Drawing.Point(14, 13)
        Me.rdioMale.Name = "rdioMale"
        Me.rdioMale.Size = New System.Drawing.Size(50, 20)
        Me.rdioMale.TabIndex = 8
        Me.rdioMale.TabStop = True
        Me.rdioMale.Text = "Male"
        Me.rdioMale.UseVisualStyleBackColor = False
        '
        'cmbPQ
        '
        Me.cmbPQ.BackColor = System.Drawing.Color.White
        Me.cmbPQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPQ.FormattingEnabled = True
        Me.cmbPQ.Items.AddRange(New Object() {"NVQ Level 3", "NVQ Level 4", "NVQ Level 5", "Other"})
        Me.cmbPQ.Location = New System.Drawing.Point(173, 501)
        Me.cmbPQ.Name = "cmbPQ"
        Me.cmbPQ.Size = New System.Drawing.Size(185, 21)
        Me.cmbPQ.TabIndex = 14
        '
        'txtNic
        '
        Me.txtNic.BackColor = System.Drawing.Color.White
        Me.txtNic.Location = New System.Drawing.Point(173, 185)
        Me.txtNic.Multiline = True
        Me.txtNic.Name = "txtNic"
        Me.txtNic.Size = New System.Drawing.Size(185, 21)
        Me.txtNic.TabIndex = 5
        '
        'cmbCrsCode
        '
        Me.cmbCrsCode.BackColor = System.Drawing.Color.White
        Me.cmbCrsCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCrsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCrsCode.FormattingEnabled = True
        Me.cmbCrsCode.Items.AddRange(New Object() {"12 months", "06 months", "03 months", "100 hours"})
        Me.cmbCrsCode.Location = New System.Drawing.Point(173, 543)
        Me.cmbCrsCode.Name = "cmbCrsCode"
        Me.cmbCrsCode.Size = New System.Drawing.Size(185, 21)
        Me.cmbCrsCode.TabIndex = 2
        '
        'txtStName
        '
        Me.txtStName.BackColor = System.Drawing.Color.White
        Me.txtStName.Location = New System.Drawing.Point(173, 145)
        Me.txtStName.Multiline = True
        Me.txtStName.Name = "txtStName"
        Me.txtStName.Size = New System.Drawing.Size(185, 21)
        Me.txtStName.TabIndex = 4
        '
        'txtStNo
        '
        Me.txtStNo.BackColor = System.Drawing.Color.White
        Me.txtStNo.Location = New System.Drawing.Point(173, 103)
        Me.txtStNo.Multiline = True
        Me.txtStNo.Name = "txtStNo"
        Me.txtStNo.Size = New System.Drawing.Size(185, 21)
        Me.txtStNo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Educational " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Qualifications"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number"
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
        Me.btnExit.Location = New System.Drawing.Point(396, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(163, 29)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(396, 322)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 33)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
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
        Me.btnUpdate.Location = New System.Drawing.Point(396, 263)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 33)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(396, 186)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 53)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdioFemale)
        Me.GroupBox1.Controls.Add(Me.rdioMale)
        Me.GroupBox1.Location = New System.Drawing.Point(173, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 72)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(135, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(310, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "S T U D E N T  D E T A I L S"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(173, 226)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(185, 48)
        Me.txtAddress.TabIndex = 6
        '
        'txtDob
        '
        Me.txtDob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDob.CustomFormat = "7/10/2019 10:58 AM"
        Me.txtDob.Location = New System.Drawing.Point(173, 293)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(185, 20)
        Me.txtDob.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOther)
        Me.GroupBox2.Controls.Add(Me.chkDeg)
        Me.GroupBox2.Controls.Add(Me.chkAL)
        Me.GroupBox2.Controls.Add(Me.chkOL)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 412)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 69)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkOther.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOther.ForeColor = System.Drawing.Color.White
        Me.chkOther.Location = New System.Drawing.Point(104, 43)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(54, 20)
        Me.chkOther.TabIndex = 13
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkDeg
        '
        Me.chkDeg.AutoSize = True
        Me.chkDeg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDeg.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeg.ForeColor = System.Drawing.Color.White
        Me.chkDeg.Location = New System.Drawing.Point(104, 16)
        Me.chkDeg.Name = "chkDeg"
        Me.chkDeg.Size = New System.Drawing.Size(62, 20)
        Me.chkDeg.TabIndex = 12
        Me.chkDeg.Text = "Degree"
        Me.chkDeg.UseVisualStyleBackColor = True
        '
        'chkAL
        '
        Me.chkAL.AutoSize = True
        Me.chkAL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAL.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAL.ForeColor = System.Drawing.Color.White
        Me.chkAL.Location = New System.Drawing.Point(14, 43)
        Me.chkAL.Name = "chkAL"
        Me.chkAL.Size = New System.Drawing.Size(77, 20)
        Me.chkAL.TabIndex = 11
        Me.chkAL.Text = "GCE (A/L)"
        Me.chkAL.UseVisualStyleBackColor = True
        '
        'chkOL
        '
        Me.chkOL.AutoSize = True
        Me.chkOL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkOL.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOL.ForeColor = System.Drawing.Color.White
        Me.chkOL.Location = New System.Drawing.Point(14, 16)
        Me.chkOL.Name = "chkOL"
        Me.chkOL.Size = New System.Drawing.Size(78, 20)
        Me.chkOL.TabIndex = 10
        Me.chkOL.Text = "GCE (O/L)"
        Me.chkOL.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(38, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(38, 545)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Course Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(38, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "NIC No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 34)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Professional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Qualifications"
        '
        'txtCrsCode
        '
        Me.txtCrsCode.BackColor = System.Drawing.Color.White
        Me.txtCrsCode.Location = New System.Drawing.Point(173, 586)
        Me.txtCrsCode.Multiline = True
        Me.txtCrsCode.Name = "txtCrsCode"
        Me.txtCrsCode.Size = New System.Drawing.Size(185, 21)
        Me.txtCrsCode.TabIndex = 14
        Me.txtCrsCode.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 588)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Course Code"
        '
        'lnkClearForm
        '
        Me.lnkClearForm.AutoSize = True
        Me.lnkClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkClearForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkClearForm.LinkColor = System.Drawing.Color.White
        Me.lnkClearForm.Location = New System.Drawing.Point(301, 616)
        Me.lnkClearForm.Name = "lnkClearForm"
        Me.lnkClearForm.Size = New System.Drawing.Size(57, 13)
        Me.lnkClearForm.TabIndex = 18
        Me.lnkClearForm.TabStop = True
        Me.lnkClearForm.Text = "Clear Form"
        '
        'txtSrchBox
        '
        Me.txtSrchBox.BackColor = System.Drawing.Color.White
        Me.txtSrchBox.ForeColor = System.Drawing.Color.DimGray
        Me.txtSrchBox.Location = New System.Drawing.Point(396, 102)
        Me.txtSrchBox.Multiline = True
        Me.txtSrchBox.Name = "txtSrchBox"
        Me.txtSrchBox.Size = New System.Drawing.Size(163, 23)
        Me.txtSrchBox.TabIndex = 0
        Me.txtSrchBox.Text = "Search Student Number Hear :"
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
        Me.btnSearch.Location = New System.Drawing.Point(396, 143)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(127, 24)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lnkCrs
        '
        Me.lnkCrs.AutoSize = True
        Me.lnkCrs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrs.ForeColor = System.Drawing.Color.White
        Me.lnkCrs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrs.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrs.Location = New System.Drawing.Point(516, 418)
        Me.lnkCrs.Name = "lnkCrs"
        Me.lnkCrs.Size = New System.Drawing.Size(43, 13)
        Me.lnkCrs.TabIndex = 21
        Me.lnkCrs.TabStop = True
        Me.lnkCrs.Text = "Course "
        '
        'lnkCrsMo
        '
        Me.lnkCrsMo.AutoSize = True
        Me.lnkCrsMo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrsMo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrsMo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrsMo.Location = New System.Drawing.Point(476, 442)
        Me.lnkCrsMo.Name = "lnkCrsMo"
        Me.lnkCrsMo.Size = New System.Drawing.Size(83, 13)
        Me.lnkCrsMo.TabIndex = 20
        Me.lnkCrsMo.TabStop = True
        Me.lnkCrsMo.Text = "Course Modules"
        '
        'lnkVwTables
        '
        Me.lnkVwTables.AutoSize = True
        Me.lnkVwTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVwTables.ForeColor = System.Drawing.Color.White
        Me.lnkVwTables.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkVwTables.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkVwTables.Location = New System.Drawing.Point(494, 469)
        Me.lnkVwTables.Name = "lnkVwTables"
        Me.lnkVwTables.Size = New System.Drawing.Size(65, 13)
        Me.lnkVwTables.TabIndex = 22
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
        Me.btnSrchClear.Location = New System.Drawing.Point(529, 143)
        Me.btnSrchClear.Name = "btnSrchClear"
        Me.btnSrchClear.Size = New System.Drawing.Size(30, 24)
        Me.btnSrchClear.TabIndex = 1
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
        Me.Button1.Location = New System.Drawing.Point(140, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(305, 10)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmStDt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 665)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSrchClear)
        Me.Controls.Add(Me.lnkVwTables)
        Me.Controls.Add(Me.lnkCrs)
        Me.Controls.Add(Me.lnkCrsMo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lnkClearForm)
        Me.Controls.Add(Me.txtSrchBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCrsCode)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPQ)
        Me.Controls.Add(Me.txtNic)
        Me.Controls.Add(Me.cmbCrsCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtStName)
        Me.Controls.Add(Me.txtStNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(612, 704)
        Me.MinimumSize = New System.Drawing.Size(612, 704)
        Me.Name = "frmStDt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdioMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPQ As System.Windows.Forms.ComboBox
    Friend WithEvents txtNic As System.Windows.Forms.TextBox
    Friend WithEvents cmbCrsCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtStName As System.Windows.Forms.TextBox
    Friend WithEvents txtStNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeg As System.Windows.Forms.CheckBox
    Friend WithEvents chkAL As System.Windows.Forms.CheckBox
    Friend WithEvents chkOL As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCrsCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lnkClearForm As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSrchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lnkCrs As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCrsMo As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkVwTables As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSrchClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
