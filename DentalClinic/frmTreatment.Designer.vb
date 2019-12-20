<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreatment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.lblPatientCPNumber = New System.Windows.Forms.Label()
        Me.lblPatientAddress = New System.Windows.Forms.Label()
        Me.lblPatientAge = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblAddEditPatient = New System.Windows.Forms.Label()
        Me.gbxTreatment = New System.Windows.Forms.GroupBox()
        Me.btnSubmitTreatment = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtToothNumber = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.nudTeethQty = New System.Windows.Forms.NumericUpDown()
        Me.dgvTreatment = New System.Windows.Forms.DataGridView()
        Me.btnAddNewTreatment = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboTreatment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTreatmentCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.pbxNewPatient = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbxTreatment.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.nudTeethQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.pbxNewPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.pbxNewPatient)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.lblAddEditPatient)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 179)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.Panel14)
        Me.Panel2.Controls.Add(Me.lblPatientID)
        Me.Panel2.Controls.Add(Me.lblPatientCPNumber)
        Me.Panel2.Controls.Add(Me.lblPatientAddress)
        Me.Panel2.Controls.Add(Me.lblPatientAge)
        Me.Panel2.Controls.Add(Me.lblPatientName)
        Me.Panel2.Location = New System.Drawing.Point(156, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 148)
        Me.Panel2.TabIndex = 2
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatientID.Location = New System.Drawing.Point(101, 11)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(0, 16)
        Me.lblPatientID.TabIndex = 13
        '
        'lblPatientCPNumber
        '
        Me.lblPatientCPNumber.AutoSize = True
        Me.lblPatientCPNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientCPNumber.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientCPNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatientCPNumber.Location = New System.Drawing.Point(101, 125)
        Me.lblPatientCPNumber.Name = "lblPatientCPNumber"
        Me.lblPatientCPNumber.Size = New System.Drawing.Size(0, 16)
        Me.lblPatientCPNumber.TabIndex = 12
        '
        'lblPatientAddress
        '
        Me.lblPatientAddress.AutoSize = True
        Me.lblPatientAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientAddress.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatientAddress.Location = New System.Drawing.Point(101, 98)
        Me.lblPatientAddress.Name = "lblPatientAddress"
        Me.lblPatientAddress.Size = New System.Drawing.Size(0, 16)
        Me.lblPatientAddress.TabIndex = 11
        '
        'lblPatientAge
        '
        Me.lblPatientAge.AutoSize = True
        Me.lblPatientAge.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientAge.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientAge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatientAge.Location = New System.Drawing.Point(101, 70)
        Me.lblPatientAge.Name = "lblPatientAge"
        Me.lblPatientAge.Size = New System.Drawing.Size(0, 16)
        Me.lblPatientAge.TabIndex = 10
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatientName.Location = New System.Drawing.Point(101, 42)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(0, 16)
        Me.lblPatientName.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(40, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "CP # :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(14, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Address :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(45, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 16)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Age :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(33, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Name :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(5, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Patient ID :"
        '
        'lblAddEditPatient
        '
        Me.lblAddEditPatient.AutoSize = True
        Me.lblAddEditPatient.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEditPatient.Location = New System.Drawing.Point(34, 151)
        Me.lblAddEditPatient.Name = "lblAddEditPatient"
        Me.lblAddEditPatient.Size = New System.Drawing.Size(91, 16)
        Me.lblAddEditPatient.TabIndex = 0
        Me.lblAddEditPatient.Text = "New Patient"
        '
        'gbxTreatment
        '
        Me.gbxTreatment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.gbxTreatment.Controls.Add(Me.btnSubmitTreatment)
        Me.gbxTreatment.Controls.Add(Me.DateTimePicker1)
        Me.gbxTreatment.Controls.Add(Me.Label8)
        Me.gbxTreatment.Controls.Add(Me.Panel8)
        Me.gbxTreatment.Controls.Add(Me.Label7)
        Me.gbxTreatment.Controls.Add(Me.Label4)
        Me.gbxTreatment.Controls.Add(Me.Panel7)
        Me.gbxTreatment.Controls.Add(Me.Panel5)
        Me.gbxTreatment.Controls.Add(Me.dgvTreatment)
        Me.gbxTreatment.Controls.Add(Me.btnAddNewTreatment)
        Me.gbxTreatment.Controls.Add(Me.Panel3)
        Me.gbxTreatment.Controls.Add(Me.Label2)
        Me.gbxTreatment.Enabled = False
        Me.gbxTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTreatment.Location = New System.Drawing.Point(12, 206)
        Me.gbxTreatment.Name = "gbxTreatment"
        Me.gbxTreatment.Size = New System.Drawing.Size(668, 381)
        Me.gbxTreatment.TabIndex = 13
        Me.gbxTreatment.TabStop = False
        Me.gbxTreatment.Text = "TREATMENT"
        '
        'btnSubmitTreatment
        '
        Me.btnSubmitTreatment.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSubmitTreatment.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmitTreatment.FlatAppearance.BorderSize = 0
        Me.btnSubmitTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitTreatment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmitTreatment.Location = New System.Drawing.Point(569, 47)
        Me.btnSubmitTreatment.Name = "btnSubmitTreatment"
        Me.btnSubmitTreatment.Size = New System.Drawing.Size(93, 104)
        Me.btnSubmitTreatment.TabIndex = 19
        Me.btnSubmitTreatment.Text = "SUBMIT"
        Me.btnSubmitTreatment.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(500, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 23)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(294, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Remarks"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.txtRemarks)
        Me.Panel8.Location = New System.Drawing.Point(297, 47)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(266, 104)
        Me.Panel8.TabIndex = 16
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(9, 7)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(248, 91)
        Me.txtRemarks.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tooth Number/s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Teeth Qty"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.txtToothNumber)
        Me.Panel7.Location = New System.Drawing.Point(144, 116)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(144, 35)
        Me.Panel7.TabIndex = 15
        '
        'txtToothNumber
        '
        Me.txtToothNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtToothNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToothNumber.Location = New System.Drawing.Point(12, 8)
        Me.txtToothNumber.Name = "txtToothNumber"
        Me.txtToothNumber.Size = New System.Drawing.Size(119, 19)
        Me.txtToothNumber.TabIndex = 1
        Me.txtToothNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.nudTeethQty)
        Me.Panel5.Location = New System.Drawing.Point(9, 116)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(113, 35)
        Me.Panel5.TabIndex = 14
        '
        'nudTeethQty
        '
        Me.nudTeethQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudTeethQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTeethQty.Location = New System.Drawing.Point(14, 7)
        Me.nudTeethQty.Name = "nudTeethQty"
        Me.nudTeethQty.Size = New System.Drawing.Size(96, 22)
        Me.nudTeethQty.TabIndex = 0
        Me.nudTeethQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudTeethQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dgvTreatment
        '
        Me.dgvTreatment.AllowUserToAddRows = False
        Me.dgvTreatment.AllowUserToDeleteRows = False
        Me.dgvTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreatment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTreatment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTreatment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTreatment.Location = New System.Drawing.Point(9, 160)
        Me.dgvTreatment.Name = "dgvTreatment"
        Me.dgvTreatment.ReadOnly = True
        Me.dgvTreatment.RowHeadersVisible = False
        Me.dgvTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreatment.Size = New System.Drawing.Size(650, 211)
        Me.dgvTreatment.TabIndex = 13
        '
        'btnAddNewTreatment
        '
        Me.btnAddNewTreatment.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddNewTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddNewTreatment.FlatAppearance.BorderSize = 0
        Me.btnAddNewTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewTreatment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewTreatment.ForeColor = System.Drawing.Color.White
        Me.btnAddNewTreatment.Location = New System.Drawing.Point(216, 20)
        Me.btnAddNewTreatment.Name = "btnAddNewTreatment"
        Me.btnAddNewTreatment.Size = New System.Drawing.Size(72, 24)
        Me.btnAddNewTreatment.TabIndex = 12
        Me.btnAddNewTreatment.Text = "Add New"
        Me.btnAddNewTreatment.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cboTreatment)
        Me.Panel3.Location = New System.Drawing.Point(9, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 35)
        Me.Panel3.TabIndex = 4
        '
        'cboTreatment
        '
        Me.cboTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTreatment.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTreatment.FormattingEnabled = True
        Me.cboTreatment.Location = New System.Drawing.Point(14, 6)
        Me.cboTreatment.Name = "cboTreatment"
        Me.cboTreatment.Size = New System.Drawing.Size(252, 24)
        Me.cboTreatment.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Treatment"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Orange
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1003, 503)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 51)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(839, 503)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(139, 51)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SUBMIT"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.GroupBox3)
        Me.Panel13.Location = New System.Drawing.Point(695, 12)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(540, 461)
        Me.Panel13.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Panel12)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Panel9)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Panel10)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Panel11)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 432)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Billings"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(167, 358)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 20)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "₱"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.TextBox8)
        Me.Panel12.Location = New System.Drawing.Point(198, 352)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(287, 35)
        Me.Panel12.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(12, 8)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(263, 19)
        Me.TextBox8.TabIndex = 1
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(96, 359)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 20)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Change"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(167, 307)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "₱"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(167, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 20)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "₱"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(167, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "₱"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(167, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(167, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "₱"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(167, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "₱"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.TextBox4)
        Me.Panel9.Location = New System.Drawing.Point(198, 301)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(287, 35)
        Me.Panel9.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(12, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(263, 19)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Balance"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.TextBox5)
        Me.Panel10.Location = New System.Drawing.Point(198, 249)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(287, 35)
        Me.Panel10.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(12, 8)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(263, 19)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cash Amount"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.TextBox6)
        Me.Panel11.Location = New System.Drawing.Point(198, 198)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(287, 35)
        Me.Panel11.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(12, 8)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(263, 19)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Total Charges"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.TextBox3)
        Me.Panel6.Location = New System.Drawing.Point(198, 146)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(287, 35)
        Me.Panel6.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 8)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(263, 19)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Discount"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Location = New System.Drawing.Point(198, 94)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 35)
        Me.Panel4.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(263, 19)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Additional Charges"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtTreatmentCost)
        Me.Panel1.Location = New System.Drawing.Point(198, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 35)
        Me.Panel1.TabIndex = 6
        '
        'txtTreatmentCost
        '
        Me.txtTreatmentCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTreatmentCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTreatmentCost.Location = New System.Drawing.Point(12, 8)
        Me.txtTreatmentCost.Name = "txtTreatmentCost"
        Me.txtTreatmentCost.Size = New System.Drawing.Size(263, 19)
        Me.txtTreatmentCost.TabIndex = 1
        Me.txtTreatmentCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Treatment Cost"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel14.Controls.Add(Me.Label18)
        Me.Panel14.Controls.Add(Me.Label22)
        Me.Panel14.Controls.Add(Me.Label19)
        Me.Panel14.Controls.Add(Me.Label21)
        Me.Panel14.Controls.Add(Me.Label20)
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(89, 148)
        Me.Panel14.TabIndex = 20
        '
        'pbxNewPatient
        '
        Me.pbxNewPatient.BackgroundImage = Global.DentalClinic.My.Resources.Resources.user1
        Me.pbxNewPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNewPatient.Location = New System.Drawing.Point(21, 33)
        Me.pbxNewPatient.Name = "pbxNewPatient"
        Me.pbxNewPatient.Size = New System.Drawing.Size(120, 116)
        Me.pbxNewPatient.TabIndex = 3
        Me.pbxNewPatient.TabStop = False
        '
        'frmTreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 599)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxTreatment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTreatment"
        Me.Text = "frmTreatment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbxTreatment.ResumeLayout(False)
        Me.gbxTreatment.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.nudTeethQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.pbxNewPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboTreatment As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddNewTreatment As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnCancel As Button
    Public WithEvents btnSave As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTreatmentCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbxTreatment As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents nudTeethQty As NumericUpDown
    Friend WithEvents dgvTreatment As DataGridView
    Friend WithEvents btnSubmitTreatment As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtToothNumber As TextBox
    Friend WithEvents pbxNewPatient As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label24 As Label
    Public WithEvents lblPatientCPNumber As Label
    Public WithEvents lblPatientAddress As Label
    Public WithEvents lblPatientAge As Label
    Public WithEvents lblPatientName As Label
    Public WithEvents lblPatientID As Label
    Friend WithEvents Panel14 As Panel
    Public WithEvents lblAddEditPatient As Label
End Class
