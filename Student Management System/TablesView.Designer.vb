<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTables))
        Me.dgvCt = New System.Windows.Forms.DataGridView()
        Me.CourseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New Student_Management_System.StudentDataSet()
        Me.dgvMt = New System.Windows.Forms.DataGridView()
        Me.ModuleCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSt = New System.Windows.Forms.DataGridView()
        Me.StudentNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProQualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lnkCrsMo = New System.Windows.Forms.LinkLabel()
        Me.lnkStDt = New System.Windows.Forms.LinkLabel()
        Me.lnkCrs = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdioMTable = New System.Windows.Forms.RadioButton()
        Me.rdioCTable = New System.Windows.Forms.RadioButton()
        Me.rdioSTable = New System.Windows.Forms.RadioButton()
        Me.txtSrcBox = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CourseTableAdapter = New Student_Management_System.StudentDataSetTableAdapters.CourseTableAdapter()
        Me.ModuleTableAdapter = New Student_Management_System.StudentDataSetTableAdapters.ModuleTableAdapter()
        Me.StudentTableAdapter = New Student_Management_System.StudentDataSetTableAdapters.StudentTableAdapter()
        CType(Me.dgvCt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCt
        '
        Me.dgvCt.AutoGenerateColumns = False
        Me.dgvCt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvCt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseCodeDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn, Me.CourseTypeDataGridViewTextBoxColumn, Me.CourseFeeDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn})
        Me.dgvCt.DataSource = Me.CourseBindingSource
        Me.dgvCt.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvCt.Location = New System.Drawing.Point(40, 320)
        Me.dgvCt.Name = "dgvCt"
        Me.dgvCt.Size = New System.Drawing.Size(661, 221)
        Me.dgvCt.TabIndex = 0
        '
        'CourseCodeDataGridViewTextBoxColumn
        '
        Me.CourseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn.HeaderText = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn.Name = "CourseCodeDataGridViewTextBoxColumn"
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "Duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "Duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        '
        'CourseTypeDataGridViewTextBoxColumn
        '
        Me.CourseTypeDataGridViewTextBoxColumn.DataPropertyName = "Course_Type"
        Me.CourseTypeDataGridViewTextBoxColumn.HeaderText = "Course_Type"
        Me.CourseTypeDataGridViewTextBoxColumn.Name = "CourseTypeDataGridViewTextBoxColumn"
        '
        'CourseFeeDataGridViewTextBoxColumn
        '
        Me.CourseFeeDataGridViewTextBoxColumn.DataPropertyName = "Course_Fee"
        Me.CourseFeeDataGridViewTextBoxColumn.HeaderText = "Course_Fee"
        Me.CourseFeeDataGridViewTextBoxColumn.Name = "CourseFeeDataGridViewTextBoxColumn"
        '
        'LevelDataGridViewTextBoxColumn
        '
        Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
        Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvMt
        '
        Me.dgvMt.AutoGenerateColumns = False
        Me.dgvMt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvMt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModuleCodeDataGridViewTextBoxColumn, Me.CourseCodeDataGridViewTextBoxColumn1, Me.ModuleNameDataGridViewTextBoxColumn, Me.ModuleHoursDataGridViewTextBoxColumn})
        Me.dgvMt.DataSource = Me.ModuleBindingSource
        Me.dgvMt.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvMt.Location = New System.Drawing.Point(729, 320)
        Me.dgvMt.Name = "dgvMt"
        Me.dgvMt.Size = New System.Drawing.Size(445, 221)
        Me.dgvMt.TabIndex = 0
        '
        'ModuleCodeDataGridViewTextBoxColumn
        '
        Me.ModuleCodeDataGridViewTextBoxColumn.DataPropertyName = "Module_Code"
        Me.ModuleCodeDataGridViewTextBoxColumn.HeaderText = "Module_Code"
        Me.ModuleCodeDataGridViewTextBoxColumn.Name = "ModuleCodeDataGridViewTextBoxColumn"
        '
        'CourseCodeDataGridViewTextBoxColumn1
        '
        Me.CourseCodeDataGridViewTextBoxColumn1.DataPropertyName = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn1.HeaderText = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn1.Name = "CourseCodeDataGridViewTextBoxColumn1"
        '
        'ModuleNameDataGridViewTextBoxColumn
        '
        Me.ModuleNameDataGridViewTextBoxColumn.DataPropertyName = "Module_Name"
        Me.ModuleNameDataGridViewTextBoxColumn.HeaderText = "Module_Name"
        Me.ModuleNameDataGridViewTextBoxColumn.Name = "ModuleNameDataGridViewTextBoxColumn"
        '
        'ModuleHoursDataGridViewTextBoxColumn
        '
        Me.ModuleHoursDataGridViewTextBoxColumn.DataPropertyName = "Module_Hours"
        Me.ModuleHoursDataGridViewTextBoxColumn.HeaderText = "Module_Hours"
        Me.ModuleHoursDataGridViewTextBoxColumn.Name = "ModuleHoursDataGridViewTextBoxColumn"
        '
        'ModuleBindingSource
        '
        Me.ModuleBindingSource.DataMember = "Module"
        Me.ModuleBindingSource.DataSource = Me.StudentDataSet
        '
        'dgvSt
        '
        Me.dgvSt.AutoGenerateColumns = False
        Me.dgvSt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNoDataGridViewTextBoxColumn, Me.CourseCodeDataGridViewTextBoxColumn2, Me.NICDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.OLDataGridViewTextBoxColumn, Me.ALDataGridViewTextBoxColumn, Me.DegreeDataGridViewTextBoxColumn, Me.OtherDataGridViewTextBoxColumn, Me.ProQualificationDataGridViewTextBoxColumn})
        Me.dgvSt.DataSource = Me.StudentBindingSource
        Me.dgvSt.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvSt.Location = New System.Drawing.Point(39, 61)
        Me.dgvSt.Name = "dgvSt"
        Me.dgvSt.Size = New System.Drawing.Size(1245, 205)
        Me.dgvSt.TabIndex = 0
        '
        'StudentNoDataGridViewTextBoxColumn
        '
        Me.StudentNoDataGridViewTextBoxColumn.DataPropertyName = "Student_No"
        Me.StudentNoDataGridViewTextBoxColumn.HeaderText = "Student_No"
        Me.StudentNoDataGridViewTextBoxColumn.Name = "StudentNoDataGridViewTextBoxColumn"
        '
        'CourseCodeDataGridViewTextBoxColumn2
        '
        Me.CourseCodeDataGridViewTextBoxColumn2.DataPropertyName = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn2.HeaderText = "Course_Code"
        Me.CourseCodeDataGridViewTextBoxColumn2.Name = "CourseCodeDataGridViewTextBoxColumn2"
        '
        'NICDataGridViewTextBoxColumn
        '
        Me.NICDataGridViewTextBoxColumn.DataPropertyName = "NIC"
        Me.NICDataGridViewTextBoxColumn.HeaderText = "NIC"
        Me.NICDataGridViewTextBoxColumn.Name = "NICDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'OLDataGridViewTextBoxColumn
        '
        Me.OLDataGridViewTextBoxColumn.DataPropertyName = "OL"
        Me.OLDataGridViewTextBoxColumn.HeaderText = "OL"
        Me.OLDataGridViewTextBoxColumn.Name = "OLDataGridViewTextBoxColumn"
        '
        'ALDataGridViewTextBoxColumn
        '
        Me.ALDataGridViewTextBoxColumn.DataPropertyName = "AL"
        Me.ALDataGridViewTextBoxColumn.HeaderText = "AL"
        Me.ALDataGridViewTextBoxColumn.Name = "ALDataGridViewTextBoxColumn"
        '
        'DegreeDataGridViewTextBoxColumn
        '
        Me.DegreeDataGridViewTextBoxColumn.DataPropertyName = "Degree"
        Me.DegreeDataGridViewTextBoxColumn.HeaderText = "Degree"
        Me.DegreeDataGridViewTextBoxColumn.Name = "DegreeDataGridViewTextBoxColumn"
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        '
        'ProQualificationDataGridViewTextBoxColumn
        '
        Me.ProQualificationDataGridViewTextBoxColumn.DataPropertyName = "Pro_Qualification"
        Me.ProQualificationDataGridViewTextBoxColumn.HeaderText = "Pro_Qualification"
        Me.ProQualificationDataGridViewTextBoxColumn.Name = "ProQualificationDataGridViewTextBoxColumn"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.StudentDataSet
        '
        'lnkCrsMo
        '
        Me.lnkCrsMo.AutoSize = True
        Me.lnkCrsMo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrsMo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCrsMo.ForeColor = System.Drawing.Color.White
        Me.lnkCrsMo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrsMo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrsMo.Location = New System.Drawing.Point(15, 55)
        Me.lnkCrsMo.Name = "lnkCrsMo"
        Me.lnkCrsMo.Size = New System.Drawing.Size(83, 13)
        Me.lnkCrsMo.TabIndex = 17
        Me.lnkCrsMo.TabStop = True
        Me.lnkCrsMo.Text = "Course Modules"
        '
        'lnkStDt
        '
        Me.lnkStDt.AutoSize = True
        Me.lnkStDt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkStDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkStDt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkStDt.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkStDt.Location = New System.Drawing.Point(15, 32)
        Me.lnkStDt.Name = "lnkStDt"
        Me.lnkStDt.Size = New System.Drawing.Size(79, 13)
        Me.lnkStDt.TabIndex = 16
        Me.lnkStDt.TabStop = True
        Me.lnkStDt.Text = "Student Details"
        '
        'lnkCrs
        '
        Me.lnkCrs.AutoSize = True
        Me.lnkCrs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCrs.ForeColor = System.Drawing.Color.White
        Me.lnkCrs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCrs.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkCrs.Location = New System.Drawing.Point(15, 79)
        Me.lnkCrs.Name = "lnkCrs"
        Me.lnkCrs.Size = New System.Drawing.Size(43, 13)
        Me.lnkCrs.TabIndex = 18
        Me.lnkCrs.TabStop = True
        Me.lnkCrs.Text = "Course "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "S t u d e n t   T a b l e  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "C o u r s e   T a b l e  "
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = "z"
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(729, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "M o d u l e   T a b l e  "
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1358, 662)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 28
        Me.LineShape3.X2 = 688
        Me.LineShape3.Y1 = 295
        Me.LineShape3.Y2 = 295
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 28
        Me.LineShape2.X2 = 1288
        Me.LineShape2.Y1 = 36
        Me.LineShape2.Y2 = 37
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 711
        Me.LineShape1.X2 = 1172
        Me.LineShape1.Y1 = 295
        Me.LineShape1.Y2 = 295
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkStDt)
        Me.GroupBox1.Controls.Add(Me.lnkCrsMo)
        Me.GroupBox1.Controls.Add(Me.lnkCrs)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1205, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 110)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To Forms"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdioMTable)
        Me.GroupBox2.Controls.Add(Me.rdioCTable)
        Me.GroupBox2.Controls.Add(Me.rdioSTable)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(1205, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 110)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'rdioMTable
        '
        Me.rdioMTable.AutoSize = True
        Me.rdioMTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioMTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioMTable.Location = New System.Drawing.Point(11, 77)
        Me.rdioMTable.Name = "rdioMTable"
        Me.rdioMTable.Size = New System.Drawing.Size(90, 17)
        Me.rdioMTable.TabIndex = 2
        Me.rdioMTable.TabStop = True
        Me.rdioMTable.Text = "Module Table"
        Me.rdioMTable.UseVisualStyleBackColor = True
        '
        'rdioCTable
        '
        Me.rdioCTable.AutoSize = True
        Me.rdioCTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioCTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioCTable.Location = New System.Drawing.Point(11, 50)
        Me.rdioCTable.Name = "rdioCTable"
        Me.rdioCTable.Size = New System.Drawing.Size(88, 17)
        Me.rdioCTable.TabIndex = 1
        Me.rdioCTable.TabStop = True
        Me.rdioCTable.Text = "Course Table"
        Me.rdioCTable.UseVisualStyleBackColor = True
        '
        'rdioSTable
        '
        Me.rdioSTable.AutoSize = True
        Me.rdioSTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioSTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdioSTable.Location = New System.Drawing.Point(11, 22)
        Me.rdioSTable.Name = "rdioSTable"
        Me.rdioSTable.Size = New System.Drawing.Size(92, 17)
        Me.rdioSTable.TabIndex = 0
        Me.rdioSTable.TabStop = True
        Me.rdioSTable.Text = "Student Table"
        Me.rdioSTable.UseVisualStyleBackColor = True
        '
        'txtSrcBox
        '
        Me.txtSrcBox.Location = New System.Drawing.Point(1010, 564)
        Me.txtSrcBox.Multiline = True
        Me.txtSrcBox.Name = "txtSrcBox"
        Me.txtSrcBox.Size = New System.Drawing.Size(175, 22)
        Me.txtSrcBox.TabIndex = 22
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
        Me.btnSearch.Location = New System.Drawing.Point(1205, 562)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 24)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1205, 595)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 24)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'ModuleTableAdapter
        '
        Me.ModuleTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'frmViewTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1358, 662)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSrcBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSt)
        Me.Controls.Add(Me.dgvMt)
        Me.Controls.Add(Me.dgvCt)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1374, 701)
        Me.MinimumSize = New System.Drawing.Size(1374, 701)
        Me.Name = "frmViewTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Tables"
        CType(Me.dgvCt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModuleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCt As System.Windows.Forms.DataGridView
    Friend WithEvents StudentDataSet As Student_Management_System.StudentDataSet
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter As Student_Management_System.StudentDataSetTableAdapters.CourseTableAdapter
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMt As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSt As System.Windows.Forms.DataGridView
    Friend WithEvents ModuleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModuleTableAdapter As Student_Management_System.StudentDataSetTableAdapters.ModuleTableAdapter
    Friend WithEvents ModuleCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuleHoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As Student_Management_System.StudentDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NICDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DegreeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProQualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnkCrsMo As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkStDt As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCrs As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdioMTable As System.Windows.Forms.RadioButton
    Friend WithEvents rdioCTable As System.Windows.Forms.RadioButton
    Friend WithEvents rdioSTable As System.Windows.Forms.RadioButton
    Friend WithEvents txtSrcBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
