Option Explicit On
Imports System.Data.OleDb
Public Class Editor
    Private Const conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StudentRecord.accdb;"
    ReadOnly con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    ReadOnly dt As DataTable = New DataTable()
    Private Sub SetupListView()
        StudentViewer.View = View.Details
        StudentViewer.FullRowSelect = True

        StudentViewer.Columns.Add("ID", 40)
        StudentViewer.Columns.Add("Name", 50)
        StudentViewer.Columns.Add("Surname", 60)
        StudentViewer.Columns.Add("Mark1", 50)
        StudentViewer.Columns.Add("EG1", 50)
        StudentViewer.Columns.Add("Per1", 50)
        StudentViewer.Columns.Add("Mark2", 50)
        StudentViewer.Columns.Add("EG2", 50)
        StudentViewer.Columns.Add("Per2", 50)
        StudentViewer.Columns.Add("Mark3", 50)
        StudentViewer.Columns.Add("EG3", 50)
        StudentViewer.Columns.Add("Per3", 50)
        StudentViewer.Columns.Add("Mark4", 50)
        StudentViewer.Columns.Add("EG4", 50)
        StudentViewer.Columns.Add("Per4", 50)
        StudentViewer.Columns.Add("Grade", 50)
        StudentViewer.Columns.Add("Remark", 60)
    End Sub
    Public Sub Add()

        Const SQL As String = "INSERT INTO StudentRecordTable(Name,Surname,Mark1,EG1,Per1,Mark2,EG2,Per2,Mark3,EG3,Per3,Mark4,EG4,Per4,Grade,Remarks) VALUES(@Name,@Surname,@Mark1,@EG1,@Per1,@Mark2,@EG2,@Per2,@Mark3,@EG3,@Per3,@Mark4,@EG4,@Per4,@Grade,@Remarks)"
        cmd = New OleDbCommand(SQL, con)

        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
        cmd.Parameters.AddWithValue("@Mark1", txtMark1.Text)
        cmd.Parameters.AddWithValue("@EG1", txtEG1.Text)
        cmd.Parameters.AddWithValue("@Per1", txtPer1.Text)
        cmd.Parameters.AddWithValue("@Mark2", txtMark2.Text)
        cmd.Parameters.AddWithValue("@EG2", txtEG2.Text)
        cmd.Parameters.AddWithValue("@Per2", txtPer2.Text)
        cmd.Parameters.AddWithValue("@Mark3", txtMark3.Text)
        cmd.Parameters.AddWithValue("@EG3", txtEG3.Text)
        cmd.Parameters.AddWithValue("@Per3", txtPer3.Text)
        cmd.Parameters.AddWithValue("@Mark4", txtMark4.Text)
        cmd.Parameters.AddWithValue("@EG4", txtEG4.Text)
        cmd.Parameters.AddWithValue("@Per4", txtPer4.Text)
        cmd.Parameters.AddWithValue("@Grade", txtGrade.Text)
        cmd.Parameters.AddWithValue("@Remarks", txtRemark.Text)

        Try
            con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully Inserted")
                CleartextBoxes()
            End If
            con.Close()
            Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub Populate(ID As String, Name As String, Surname As String, Mark1 As String, EG1 As String, Per1 As String, Mark2 As String, EG2 As String, Per2 As String, Mark3 As String, EG3 As String, Per3 As String, Mark4 As String, EG4 As String, Per4 As String, Grade As String, Remarks As String)

        Dim row As String() = New String() {ID, Name, Surname, Mark1, EG1, Per1, Mark2, EG2, Per2, Mark3, EG3, Per3, Mark4, EG4, Per4, Grade, Remarks}
        Dim item As ListViewItem = New ListViewItem(row)

        StudentViewer.Items.Add(item)
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
                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12), row(13), row(14), row(15), row(16))
            Next

            dt.Rows.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub UpdateLV(ID As String, Name As String, Surname As String, Mark1 As String, EG1 As String, Per1 As String, Mark2 As String, EG2 As String, Per2 As String, Mark3 As String, EG3 As String, Per3 As String, Mark4 As String, EG4 As String, Per4 As String, Grade As String, Remarks As String)
        Dim sql As String = "UPDATE StudentRecordTable SET Name='" + Name + "',Surname='" + Surname + "',Mark1='" + Mark1 + "',EG1='" + EG1 + "',Per1='" + Per1 + "',Mark2='" + Mark2 + "',EG2='" + EG2 + "',Per2='" + Per2 + "',Mark3='" + Mark3 + "',EG3='" + EG3 + "',Per3='" + Per3 + "',Mark4='" + Mark4 + "',EG4='" + EG4 + "',Per4='" + Per4 + "',Grade='" + Grade + "',Remarks='" + Remarks + "' WHERE ID=" + ID + ""
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.UpdateCommand = con.CreateCommand()
            adapter.UpdateCommand.CommandText = sql

            If (adapter.UpdateCommand.ExecuteNonQuery() > 0) Then
                MsgBox("Successfully Updated")
                CleartextBoxes()
            End If
            con.Close()
            Retrieve()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub Delete(id As String)
        Dim sql As String = "DELETE FROM StudentRecordTable WHERE ID=" + id + ""
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.DeleteCommand = con.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            If MessageBox.Show("Are you sure to permanently delete this?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If cmd.ExecuteNonQuery() > 0 Then
                    CleartextBoxes()
                    MsgBox("Successfully deleted")
                End If
            End If
            con.Close()
            Retrieve()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub CleartextBoxes()
        txtName.Text = ""
        txtSurname.Text = ""
        txtMark1.Text = ""
        txtMark2.Text = ""
        txtMark4.Text = ""
        txtMark3.Text = ""
        txtEG1.Text = ""
        txtEG2.Text = ""
        txtEG3.Text = ""
        txtEG4.Text = ""
        txtPer1.Text = ""
        txtPer2.Text = ""
        txtPer3.Text = ""
        txtPer4.Text = ""
        txtGrade.Text = ""
        txtRemark.Text = ""
        txtRemark.BackColor = Color.Lime
        txtGrade.BackColor = Color.Lime
    End Sub
    Private Sub StudentViewer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentViewer.SelectedIndexChanged
        Try
            Dim selectedIndex As Int32 = StudentViewer.SelectedIndices(0)

            If Not selectedIndex = -1 Then

                If StudentViewer.SelectedItems(0).SubItems(0).Text IsNot Nothing Then

                    Dim Name As String = StudentViewer.SelectedItems(0).SubItems(1).Text
                    Dim Surname As String = StudentViewer.SelectedItems(0).SubItems(2).Text
                    Dim Mark1 As String = StudentViewer.SelectedItems(0).SubItems(3).Text
                    Dim Mark2 As String = StudentViewer.SelectedItems(0).SubItems(6).Text
                    Dim Mark3 As String = StudentViewer.SelectedItems(0).SubItems(9).Text
                    Dim Mark4 As String = StudentViewer.SelectedItems(0).SubItems(12).Text
                    Dim EG1 As String = StudentViewer.SelectedItems(0).SubItems(4).Text
                    Dim EG2 As String = StudentViewer.SelectedItems(0).SubItems(7).Text
                    Dim EG3 As String = StudentViewer.SelectedItems(0).SubItems(10).Text
                    Dim EG4 As String = StudentViewer.SelectedItems(0).SubItems(13).Text
                    Dim Per1 As String = StudentViewer.SelectedItems(0).SubItems(5).Text
                    Dim Per2 As String = StudentViewer.SelectedItems(0).SubItems(8).Text
                    Dim Per3 As String = StudentViewer.SelectedItems(0).SubItems(11).Text
                    Dim Per4 As String = StudentViewer.SelectedItems(0).SubItems(14).Text
                    Dim Grade As String = StudentViewer.SelectedItems(0).SubItems(15).Text
                    Dim Remark As String = StudentViewer.SelectedItems(0).SubItems(16).Text

                    txtName.Text = Name
                    txtSurname.Text = Surname
                    txtMark1.Text = Mark1
                    txtMark2.Text = Mark2
                    txtMark3.Text = Mark3
                    txtMark4.Text = Mark4
                    txtEG1.Text = EG1
                    txtEG2.Text = EG2
                    txtEG3.Text = EG3
                    txtEG4.Text = EG4
                    txtPer1.Text = Per1
                    txtPer2.Text = Per2
                    txtPer3.Text = Per3
                    txtPer4.Text = Per4
                    txtGrade.Text = Grade
                    txtRemark.Text = Remark

                End If
            End If

        Catch ex As ArgumentOutOfRangeException

        End Try
    End Sub
    Private Sub Editor_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Retrieve()
        SetupListView()
    End Sub
    Private Sub cmdCalGrades_Click(sender As Object, e As EventArgs) Handles cmdCalGrades.Click
        Dim a As Integer
        Dim b As Decimal

        If IsNumeric(txtMark1.Text) Then
            If txtMark1.Text >= 0 And txtMark1.Text <= 100 Then

                a = txtMark1.Text * 100 / 100
                txtEG1.Text = a
                b = a * 0.26
                txtPer1.Text = CDec(b)

            Else

                MsgBox("Please enter a value between the range 0 - 100!")

            End If
        End If

        If IsNumeric(txtMark2.Text) Then
            If txtMark2.Text >= 0 And txtMark2.Text <= 100 Then

                a = txtMark2.Text * 100 / 100
                txtEG2.Text = a
                b = a * 0.27
                txtPer2.Text = CDec(b)

            Else

                MsgBox("Please enter a value between the range 0 - 100!")

            End If
        End If

        If IsNumeric(txtMark4.Text) Then
            If txtMark4.Text >= 0 And txtMark4.Text <= 100 Then

                a = txtMark4.Text * 100 / 100
                txtEG3.Text = a
                b = a * 0.16
                txtPer3.Text = CDec(b)

            Else

                MsgBox("Please enter a value between the range 0 - 100!")

            End If
        End If

        If IsNumeric(txtMark3.Text) Then
            If txtMark3.Text >= 0 And txtMark3.Text <= 100 Then

                a = txtMark3.Text * 100 / 100
                txtEG4.Text = a
                b = a * 0.31
                txtPer4.Text = CDec(b)

            Else

                MsgBox("Please enter a value between the range 0 - 100!")

            End If
        End If

        Dim MRes As Decimal
        MRes = Val(txtPer1.Text) + Val(txtPer2.Text) + Val(txtPer3.Text) + Val(txtPer4.Text)

        txtGrade.Text = MRes

        If Val(txtGrade.Text) <= 75 Then

            txtRemark.Text = "Failed"
            txtRemark.BackColor = Color.Red
            txtGrade.BackColor = Color.Red
        Else
            txtRemark.Text = "Passed"
            txtRemark.BackColor = Color.Lime
            txtGrade.BackColor = Color.Lime
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        StudentViewer.Items.Clear()
        CleartextBoxes()
    End Sub

    Private Sub cmdRetrieve_Click(sender As Object, e As EventArgs) Handles cmdRetrieve.Click
        Retrieve()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Add()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If StudentViewer.SelectedItems.Count > 0 Then
            Dim selectedIndex As Int32 = StudentViewer.SelectedIndices(0)
            If Not selectedIndex = -1 Then
                Dim id As String = StudentViewer.SelectedItems(0).SubItems(0).Text
                UpdateLV(id, txtName.Text, txtSurname.Text, txtMark1.Text, txtMark2.Text, txtMark4.Text, txtMark3.Text, txtEG1.Text, txtEG2.Text, txtEG3.Text, txtEG4.Text, txtPer1.Text, txtPer2.Text, txtPer3.Text, txtPer4.Text, txtGrade.Text, txtRemark.Text)
            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If StudentViewer.SelectedItems.Count > 0 Then
            Dim selectedIndex As Int32 = StudentViewer.SelectedIndices(0)
            If Not selectedIndex = -1 Then
                Dim id As String = StudentViewer.SelectedItems(0).SubItems(0).Text
                Delete(id)
            End If
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Print.Show()
        Hide()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Main.Show()
        Hide()
    End Sub
End Class