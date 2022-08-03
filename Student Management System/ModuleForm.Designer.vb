<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModule))
        Me.txtModCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtModName = New System.Windows.Forms.TextBox()
        Me.txtNHours = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCrsCode = New System.Windows.Forms.ComboBox()
        Me.lnkClearForm = New System.Windows.Forms.LinkLabel()
        Me.lnkCrs = New System.Windows.Forms.LinkLabel()
        Me.lnkStDt = New System.Windows.Forms.LinkLabel()
        Me.txtSrchBox = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCrsCode = New System.Windows.Forms.TextBox()
        Me.lnkVwTables = New System.Windows.Forms.LinkLabel()
        Me.btnSrchClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtModCode
        '
        Me.txtModCode.BackColor = System.Drawing.Color.White
        Me.txtModCode.Location = New System.Drawing.Point(149, 232)
        Me.txtModCode.Multiline = True
        Me.txtModCode.Name = "txtModCode"
        Me.txtModCode.Size = New System.Drawing.Size(127, 21)
        Me.txtModCode.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No of Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Module Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Module Code"
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
        Me.btnExit.Location = New System.Drawing.Point(310, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 31)
        Me.btnExit.TabIndex = 11
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
        Me.btnDelete.Location = New System.Drawing.Point(310, 259)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 31)
        Me.btnDelete.TabIndex = 9
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
        Me.btnUpdate.Location = New System.Drawing.Point(310, 211)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 31)
        Me.btnUpdate.TabIndex = 8
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
        Me.btnSave.Location = New System.Drawing.Point(310, 153)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 42)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtModName
        '
        Me.txtModName.BackColor = System.Drawing.Color.White
        Me.txtModName.Location = New System.Drawing.Point(149, 274)
        Me.txtModName.Multiline = True
        Me.txtModName.Name = "txtModName"
        Me.txtModName.Size = New System.Drawing.Size(127, 21)
        Me.txtModName.TabIndex = 5
        '
        'txtNHours
        '
        Me.txtNHours.BackColor = System.Drawing.Color.White
        Me.txtNHours.Location = New System.Drawing.Point(149, 315)
        Me.txtNHours.Multiline = True
        Me.txtNHours.Name = "txtNHours"
        Me.txtNHours.Size = New System.Drawing.Size(127, 21)
        Me.txtNHours.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(96, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(300, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "M O D U L E  D E T A I L S "
        '
        'cmbCrsCode
        '
        Me.cmbCrsCode.BackColor = System.Drawing.Color.White
        Me.cmbCrsCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCrsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCrsCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCrsCode.FormattingEnabled = True
        Me.cmbCrsCode.Location = New System.Drawing.Point(149, 153)
        Me.cmbCrsCode.Name = "cmbCrsCode"
        Me.cmbCrsCode.Size = New System.Drawing.Size(127, 21)
        Me.cmbCrsCode.TabIndex = 3
        '
        'lnkClearForm
        '
        Me.lnkClearForm.AutoSize = True
        Me.lnkClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkClearForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkClearForm.LinkColor = System.Drawing.Color.White
        Me.lnkClearForm.Location = New System.Drawing.Point(221, 347)
        Me.lnkClearForm.Name = "lnkClearForm"
        Me.lnkClearForm.Size = New System.Drawing.Size(57, 13)
        Me.lnkClearForm.TabIndex = 10
        Me.lnkClearForm.TabStop = True
        Me.lnkClearForm.Text = "Clear Form"
        '
        'lnkCrs
        '
        Me.lnkCrs.AutoSize = True
        Me.lnkCrs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrs.ForeColor = System.Drawing.Color.White
        Me.lnkCrs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrs.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrs.Location = New System.Drawing.Point(412, 347)
        Me.lnkCrs.Name = "lnkCrs"
        Me.lnkCrs.Size = New System.Drawing.Size(43, 13)
        Me.lnkCrs.TabIndex = 13
        Me.lnkCrs.TabStop = True
        Me.lnkCrs.Text = "Course "
        '
        'lnkStDt
        '
        Me.lnkStDt.AutoSize = True
        Me.lnkStDt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkStDt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkStDt.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkStDt.Location = New System.Drawing.Point(376, 370)
        Me.lnkStDt.Name = "lnkStDt"
        Me.lnkStDt.Size = New System.Drawing.Size(79, 13)
        Me.lnkStDt.TabIndex = 12
        Me.lnkStDt.TabStop = True
        Me.lnkStDt.Text = "Student Details"
        '
        'txtSrchBox
        '
        Me.txtSrchBox.BackColor = System.Drawing.Color.White
        Me.txtSrchBox.ForeColor = System.Drawing.Color.DimGray
        Me.txtSrchBox.Location = New System.Drawing.Point(40, 100)
        Me.txtSrchBox.Multiline = True
        Me.txtSrchBox.Name = "txtSrchBox"
        Me.txtSrchBox.Size = New System.Drawing.Size(236, 24)
        Me.txtSrchBox.TabIndex = 1
        Me.txtSrchBox.Text = "Search Module Code Hear :"
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
        Me.btnSearch.Location = New System.Drawing.Point(310, 100)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Course Code"
        '
        'txtCrsCode
        '
        Me.txtCrsCode.BackColor = System.Drawing.Color.White
        Me.txtCrsCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrsCode.Location = New System.Drawing.Point(149, 192)
        Me.txtCrsCode.Multiline = True
        Me.txtCrsCode.Name = "txtCrsCode"
        Me.txtCrsCode.Size = New System.Drawing.Size(127, 21)
        Me.txtCrsCode.TabIndex = 4
        '
        'lnkVwTables
        '
        Me.lnkVwTables.AutoSize = True
        Me.lnkVwTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVwTables.ForeColor = System.Drawing.Color.White
        Me.lnkVwTables.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkVwTables.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkVwTables.Location = New System.Drawing.Point(37, 347)
        Me.lnkVwTables.Name = "lnkVwTables"
        Me.lnkVwTables.Size = New System.Drawing.Size(65, 13)
        Me.lnkVwTables.TabIndex = 14
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
        Me.btnSrchClear.Location = New System.Drawing.Point(419, 100)
        Me.btnSrchClear.Name = "btnSrchClear"
        Me.btnSrchClear.Size = New System.Drawing.Size(32, 24)
        Me.btnSrchClear.TabIndex = 36
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
        Me.Button1.Location = New System.Drawing.Point(101, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 10)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSrchClear)
        Me.Controls.Add(Me.lnkVwTables)
        Me.Controls.Add(Me.txtCrsCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lnkClearForm)
        Me.Controls.Add(Me.lnkCrs)
        Me.Controls.Add(Me.lnkStDt)
        Me.Controls.Add(Me.txtSrchBox)
        Me.Controls.Add(Me.cmbCrsCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNHours)
        Me.Controls.Add(Me.txtModName)
        Me.Controls.Add(Me.txtModCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(508, 457)
        Me.MinimumSize = New System.Drawing.Size(508, 457)
        Me.Name = "frmModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtModCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtModName As System.Windows.Forms.TextBox
    Friend WithEvents txtNHours As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCrsCode As System.Windows.Forms.ComboBox
    Friend WithEvents lnkClearForm As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCrs As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkStDt As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSrchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCrsCode As System.Windows.Forms.TextBox
    Friend WithEvents lnkVwTables As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSrchClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
