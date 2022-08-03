Imports System.Data.SqlClient

Public Class frmViewTables

    Private Sub TablesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet.Student)
        'TODO: This line of code loads data into the 'StudentDataSet._Module' table. You can move, or remove it, as needed.
        Me.ModuleTableAdapter.Fill(Me.StudentDataSet._Module)
        'TODO: This line of code loads data into the 'StudentDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.StudentDataSet.Course)
    End Sub

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.CourseTableAdapter.Fill(Me.StudentDataSet.Course)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub lnkStDt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStDt.LinkClicked
        Me.Hide()
        frmStDt.Show()
    End Sub

    Private Sub lnkCrsMo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrsMo.LinkClicked
        Me.Hide()
        frmModule.Show()
    End Sub

    Private Sub lnkCrs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrs.LinkClicked
        Me.Hide()
        frmCourse.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If rdioSTable.Checked = True Then
            Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.dgvSt.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue) = Me.txtSrcBox.Text).ToArray()
        ElseIf rdioCTable.Checked = True Then
            Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.dgvCt.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue) = Me.txtSrcBox.Text).ToArray()
        ElseIf rdioMTable.Checked = True Then
            Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.dgvMt.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue) = Me.txtSrcBox.Text).ToArray()
        End If

        'Dim temp As Integer = 0
        'For i As Integer = 0 To gv.RowCount - 1
        '    For j As Integer = 0 To gv.ColumnCount - 1
        '        If gv.Rows(i).Cells(j).Value.ToString = TextBox1.Text Then
        '            MsgBox("Item found")
        '            temp = 1
        '        End If
        '    Next
        'Next
        'If temp = 0 Then
        '    MsgBox("Item not found")
        'End If

        'If rdioSTable.Checked = True Then
        '    StudentDataGridviwe.DataSource()
        'End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdioSTable.Checked = False
        rdioCTable.Checked = False
        rdioMTable.Checked = False
        txtSrcBox.Text = ""
    End Sub

End Class