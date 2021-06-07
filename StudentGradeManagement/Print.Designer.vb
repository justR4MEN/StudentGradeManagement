<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cmdPageS = New System.Windows.Forms.Button()
        Me.cmdPrintS = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.StudentViewer = New System.Windows.Forms.ListView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(125, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Grade Management - Students"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(23, 93)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(83, 23)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(23, 123)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(83, 23)
        Me.cmdPreview.TabIndex = 4
        Me.cmdPreview.Text = "Print Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdPageS
        '
        Me.cmdPageS.Location = New System.Drawing.Point(23, 153)
        Me.cmdPageS.Name = "cmdPageS"
        Me.cmdPageS.Size = New System.Drawing.Size(83, 23)
        Me.cmdPageS.TabIndex = 5
        Me.cmdPageS.Text = "Page Setup"
        Me.cmdPageS.UseVisualStyleBackColor = True
        '
        'cmdPrintS
        '
        Me.cmdPrintS.Location = New System.Drawing.Point(23, 183)
        Me.cmdPrintS.Name = "cmdPrintS"
        Me.cmdPrintS.Size = New System.Drawing.Size(83, 23)
        Me.cmdPrintS.TabIndex = 6
        Me.cmdPrintS.Text = "Printer Setup"
        Me.cmdPrintS.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(23, 365)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(83, 23)
        Me.cmdBack.TabIndex = 7
        Me.cmdBack.Text = "Back to Menu"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'StudentViewer
        '
        Me.StudentViewer.HideSelection = False
        Me.StudentViewer.Location = New System.Drawing.Point(128, 76)
        Me.StudentViewer.Name = "StudentViewer"
        Me.StudentViewer.Size = New System.Drawing.Size(460, 312)
        Me.StudentViewer.TabIndex = 8
        Me.StudentViewer.UseCompatibleStateImageBehavior = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StudentGradeManagement.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(606, 399)
        Me.Controls.Add(Me.StudentViewer)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdPrintS)
        Me.Controls.Add(Me.cmdPageS)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Print"
        Me.Text = "Student Grade Management - Print"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdPreview As Button
    Friend WithEvents cmdPageS As Button
    Friend WithEvents cmdPrintS As Button
    Friend WithEvents cmdBack As Button
    Friend WithEvents StudentViewer As ListView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
