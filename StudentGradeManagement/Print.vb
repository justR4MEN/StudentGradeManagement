Imports System.Data.OleDb
Public Class Print
    Private Const conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StudentRecord.accdb;"
    ReadOnly con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    ReadOnly dt As DataTable = New DataTable()
    Dim HH As Integer
    Dim Linenumber As Integer
    Dim Lineperpage As Integer
    Dim I_Start As Integer
    Dim I_Counter As Integer
    Private Sub SetupListView()
        StudentViewer.View = View.Details
        StudentViewer.FullRowSelect = True

        StudentViewer.Columns.Add("ID", 40)
        StudentViewer.Columns.Add("Name", 50)
        StudentViewer.Columns.Add("Surname", 60)
        StudentViewer.Columns.Add("Mark1", 50)
        StudentViewer.Columns.Add("Mark2", 50)
        StudentViewer.Columns.Add("Mark3", 50)
        StudentViewer.Columns.Add("Mark4", 50)
        StudentViewer.Columns.Add("Grade", 50)
        StudentViewer.Columns.Add("Remark", 60)
    End Sub
    Private Sub Retrieve()

        StudentViewer.Items.Clear()

        Dim sql As String = "SELECT * FROM StudentRecordTable "
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            For Each row In dt.Rows
                Populate(row(0), row(1), row(2), row(3), row(6), row(9), row(12), row(15), row(16))
            Next

            dt.Rows.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub Populate(ID As String, Name As String, Surname As String, Mark1 As String, Mark2 As String, Mark3 As String, Mark4 As String, Grade As String, Remarks As String)

        Dim row As String() = New String() {ID, Name, Surname, Mark1, Mark2, Mark3, Mark4, Grade, Remarks}
        Dim item As ListViewItem = New ListViewItem(row)

        StudentViewer.Items.Add(item)
    End Sub
    Private Sub Print_load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.PrinterSettings = PageSetupDialog1.PrinterSettings
        PageSetupDialog1.Document = PrintDocument1
        Retrieve()
        SetupListView()
    End Sub
    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        HH = 50
        e.Graphics.DrawString(Label1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 50, HH)
        HH += 60
        e.Graphics.DrawString("ID    Name    Surname    Mark1    Mark2    Mark3    Mark4    Grade    Remarks    ", New Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, 50, HH)
        HH += 40
        e.Graphics.DrawLine(Pens.Black, 50, 90, 750, 90)

        For I_Counter = I_Start To StudentViewer.Items.Count - 1
            'ID
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).Text, New Font("Times New Roman", 15), Brushes.Black, 52, HH)
            'Name
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(1).Text, New Font("Times New Roman", 15), Brushes.Black, 94, HH)
            'Surname
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(2).Text, New Font("Times New Roman", 15), Brushes.Black, 166, HH)
            'Mark1
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(3).Text, New Font("Times New Roman", 15), Brushes.Black, 272, HH)
            'Mark2
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(4).Text, New Font("Times New Roman", 15), Brushes.Black, 354, HH)
            'Mark3
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(5).Text, New Font("Times New Roman", 15), Brushes.Black, 440, HH)
            'Mark4
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(6).Text, New Font("Times New Roman", 15), Brushes.Black, 527, HH)
            'Grade
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(7).Text, New Font("Times New Roman", 15), Brushes.Black, 610, HH)
            'Remarks
            e.Graphics.DrawString(StudentViewer.Items(I_Counter).SubItems(8).Text, New Font("Times New Roman", 15), Brushes.Black, 687, HH)

            HH += 20
            Linenumber += 1
            If Linenumber = Lineperpage Then
                Linenumber = 0
                I_Start = I_Counter + 1
                HH = 50
                e.HasMorePages = True
                Exit For
            End If
        Next
    End Sub
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Printing Problem" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        Try
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdPageS_Click(sender As Object, e As EventArgs) Handles cmdPageS.Click
        Try
            PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
            PageSetupDialog1.PrinterSettings = PrintDocument1.PrinterSettings

            If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
                PrintDocument1.PrinterSettings = PageSetupDialog1.PrinterSettings
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrintS_Click(sender As Object, e As EventArgs) Handles cmdPrintS.Click
        Try
            PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings()
            End If

        Catch ex As Exception
            MsgBox("Printing Problem" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Main.Show()
        Close()
    End Sub
End Class