<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPer1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEG1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPer2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEG2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPer3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEG3 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPer4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEG4 = New System.Windows.Forms.TextBox()
        Me.cmdCalGrades = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdRetrieve = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.StudentViewer = New System.Windows.Forms.ListView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMark1 = New System.Windows.Forms.TextBox()
        Me.txtMark2 = New System.Windows.Forms.TextBox()
        Me.txtMark3 = New System.Windows.Forms.TextBox()
        Me.txtMark4 = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(52, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Grade Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPer1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEG1)
        Me.GroupBox1.Controls.Add(Me.txtMark1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(41, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 64)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Term 1      100      EG      26%"
        '
        'txtPer1
        '
        Me.txtPer1.BackColor = System.Drawing.Color.Lime
        Me.txtPer1.Enabled = False
        Me.txtPer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer1.Location = New System.Drawing.Point(180, 25)
        Me.txtPer1.Name = "txtPer1"
        Me.txtPer1.Size = New System.Drawing.Size(47, 26)
        Me.txtPer1.TabIndex = 8
        Me.txtPer1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Score:"
        '
        'txtEG1
        '
        Me.txtEG1.BackColor = System.Drawing.Color.Lime
        Me.txtEG1.Enabled = False
        Me.txtEG1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEG1.Location = New System.Drawing.Point(127, 25)
        Me.txtEG1.Name = "txtEG1"
        Me.txtEG1.Size = New System.Drawing.Size(47, 26)
        Me.txtEG1.TabIndex = 7
        Me.txtEG1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtGrade)
        Me.GroupBox5.Controls.Add(Me.txtRemark)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox5.Location = New System.Drawing.Point(41, 269)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(244, 78)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Grade Finalised"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(120, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Remarks:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Grade:"
        '
        'txtGrade
        '
        Me.txtGrade.BackColor = System.Drawing.Color.Lime
        Me.txtGrade.Enabled = False
        Me.txtGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(17, 45)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(90, 26)
        Me.txtGrade.TabIndex = 15
        Me.txtGrade.TabStop = False
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = System.Drawing.Color.Lime
        Me.txtRemark.Enabled = False
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(124, 45)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(91, 26)
        Me.txtRemark.TabIndex = 16
        Me.txtRemark.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(36, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(299, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Surname:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtPer2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtEG2)
        Me.GroupBox2.Controls.Add(Me.txtMark2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(304, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 64)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Term 2      100      EG      27%"
        '
        'txtPer2
        '
        Me.txtPer2.BackColor = System.Drawing.Color.Lime
        Me.txtPer2.Enabled = False
        Me.txtPer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer2.Location = New System.Drawing.Point(180, 25)
        Me.txtPer2.Name = "txtPer2"
        Me.txtPer2.Size = New System.Drawing.Size(47, 26)
        Me.txtPer2.TabIndex = 10
        Me.txtPer2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Score:"
        '
        'txtEG2
        '
        Me.txtEG2.BackColor = System.Drawing.Color.Lime
        Me.txtEG2.Enabled = False
        Me.txtEG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEG2.Location = New System.Drawing.Point(127, 25)
        Me.txtEG2.Name = "txtEG2"
        Me.txtEG2.Size = New System.Drawing.Size(47, 26)
        Me.txtEG2.TabIndex = 9
        Me.txtEG2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtPer3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtEG3)
        Me.GroupBox3.Controls.Add(Me.txtMark3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(41, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 64)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Term 3      100      EG      16%"
        '
        'txtPer3
        '
        Me.txtPer3.BackColor = System.Drawing.Color.Lime
        Me.txtPer3.Enabled = False
        Me.txtPer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer3.Location = New System.Drawing.Point(180, 25)
        Me.txtPer3.Name = "txtPer3"
        Me.txtPer3.Size = New System.Drawing.Size(47, 26)
        Me.txtPer3.TabIndex = 12
        Me.txtPer3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Score:"
        '
        'txtEG3
        '
        Me.txtEG3.BackColor = System.Drawing.Color.Lime
        Me.txtEG3.Enabled = False
        Me.txtEG3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEG3.Location = New System.Drawing.Point(127, 25)
        Me.txtEG3.Name = "txtEG3"
        Me.txtEG3.Size = New System.Drawing.Size(47, 26)
        Me.txtEG3.TabIndex = 11
        Me.txtEG3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtPer4)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtMark4)
        Me.GroupBox4.Controls.Add(Me.txtEG4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(304, 199)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 64)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Term 4      100      EG      31%"
        '
        'txtPer4
        '
        Me.txtPer4.BackColor = System.Drawing.Color.Lime
        Me.txtPer4.Enabled = False
        Me.txtPer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPer4.Location = New System.Drawing.Point(180, 25)
        Me.txtPer4.Name = "txtPer4"
        Me.txtPer4.Size = New System.Drawing.Size(47, 26)
        Me.txtPer4.TabIndex = 14
        Me.txtPer4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Score:"
        '
        'txtEG4
        '
        Me.txtEG4.BackColor = System.Drawing.Color.Lime
        Me.txtEG4.Enabled = False
        Me.txtEG4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEG4.Location = New System.Drawing.Point(127, 25)
        Me.txtEG4.Name = "txtEG4"
        Me.txtEG4.Size = New System.Drawing.Size(47, 26)
        Me.txtEG4.TabIndex = 13
        Me.txtEG4.TabStop = False
        '
        'cmdCalGrades
        '
        Me.cmdCalGrades.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdCalGrades.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalGrades.Location = New System.Drawing.Point(324, 269)
        Me.cmdCalGrades.Name = "cmdCalGrades"
        Me.cmdCalGrades.Size = New System.Drawing.Size(101, 23)
        Me.cmdCalGrades.TabIndex = 15
        Me.cmdCalGrades.TabStop = False
        Me.cmdCalGrades.Text = "Calculate Grades"
        Me.cmdCalGrades.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(431, 269)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(92, 23)
        Me.cmdClear.TabIndex = 16
        Me.cmdClear.TabStop = False
        Me.cmdClear.Text = "Clear All Fields"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdRetrieve
        '
        Me.cmdRetrieve.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdRetrieve.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRetrieve.Location = New System.Drawing.Point(324, 322)
        Me.cmdRetrieve.Name = "cmdRetrieve"
        Me.cmdRetrieve.Size = New System.Drawing.Size(102, 23)
        Me.cmdRetrieve.TabIndex = 17
        Me.cmdRetrieve.TabStop = False
        Me.cmdRetrieve.Text = "Retrieve Record"
        Me.cmdRetrieve.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(431, 322)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(94, 23)
        Me.cmdAdd.TabIndex = 18
        Me.cmdAdd.TabStop = False
        Me.cmdAdd.Text = "Add to Record"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Location = New System.Drawing.Point(324, 351)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(101, 23)
        Me.cmdUpdate.TabIndex = 19
        Me.cmdUpdate.TabStop = False
        Me.cmdUpdate.Text = "Update Record"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Location = New System.Drawing.Point(431, 351)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(93, 23)
        Me.cmdDelete.TabIndex = 20
        Me.cmdDelete.TabStop = False
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(374, 379)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 21
        Me.cmdPrint.TabStop = False
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBack.Location = New System.Drawing.Point(41, 379)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 22
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'StudentViewer
        '
        Me.StudentViewer.HideSelection = False
        Me.StudentViewer.Location = New System.Drawing.Point(594, 80)
        Me.StudentViewer.Name = "StudentViewer"
        Me.StudentViewer.Size = New System.Drawing.Size(857, 304)
        Me.StudentViewer.TabIndex = 23
        Me.StudentViewer.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(888, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(314, 31)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Student Record Viewer"
        '
        'txtMark1
        '
        Me.txtMark1.Location = New System.Drawing.Point(67, 25)
        Me.txtMark1.Name = "txtMark1"
        Me.txtMark1.Size = New System.Drawing.Size(54, 26)
        Me.txtMark1.TabIndex = 3
        '
        'txtMark2
        '
        Me.txtMark2.Location = New System.Drawing.Point(66, 25)
        Me.txtMark2.Name = "txtMark2"
        Me.txtMark2.Size = New System.Drawing.Size(55, 26)
        Me.txtMark2.TabIndex = 4
        '
        'txtMark3
        '
        Me.txtMark3.Location = New System.Drawing.Point(67, 25)
        Me.txtMark3.Name = "txtMark3"
        Me.txtMark3.Size = New System.Drawing.Size(54, 26)
        Me.txtMark3.TabIndex = 5
        '
        'txtMark4
        '
        Me.txtMark4.Location = New System.Drawing.Point(66, 25)
        Me.txtMark4.Name = "txtMark4"
        Me.txtMark4.Size = New System.Drawing.Size(55, 26)
        Me.txtMark4.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 20)
        Me.txtName.TabIndex = 1
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(409, 87)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(139, 20)
        Me.txtSurname.TabIndex = 2
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = Global.StudentGradeManagement.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1478, 411)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.StudentViewer)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRetrieve)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalGrades)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Editor"
        Me.Text = "Student Grade Management - Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPer1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEG1 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPer2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEG2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPer3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEG3 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPer4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEG4 As TextBox
    Friend WithEvents cmdCalGrades As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdRetrieve As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdBack As Button
    Friend WithEvents StudentViewer As ListView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMark1 As TextBox
    Friend WithEvents txtMark2 As TextBox
    Friend WithEvents txtMark3 As TextBox
    Friend WithEvents txtMark4 As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
End Class
