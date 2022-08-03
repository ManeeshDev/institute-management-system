Imports System.Data.SqlClient

Public Class frmCourse
    Dim cmd1 As SqlCommand
    Dim fees As Integer
    Dim type, Dur, Lvl, Ans, ExtAns, DuplFound As String
    Dim CrsCode As String    '***For all -save,search,delete,update 

    Private Sub frmCorse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LD()
    End Sub

    Private Sub rdioFtime_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFtime.CheckedChanged
        type = "Full Time"
        txtFee.Enabled = False
        fees = 0
    End Sub

    Private Sub rdioPtime_CheckedChanged(sender As Object, e As EventArgs) Handles rdioPtime.CheckedChanged
        type = "Part Time"
        fees = Val(txtFee.Text)
    End Sub

    Private Sub rdioFtime_Click(sender As Object, e As EventArgs) Handles rdioFtime.Click
        If fees.ToString.Length > 0 Then
            txtFee.Text = 0
        End If
    End Sub

    Private Sub rdioPtime_Click(sender As Object, e As EventArgs) Handles rdioPtime.Click
        txtFee.Enabled = True
    End Sub

    Private Sub RdioChnge()  'To change radio buttons
        If rdioFtime.Checked = True Then
            txtFee.Enabled = False
            txtFee.Text = 0

        ElseIf rdioPtime.Checked = True Then
            txtFee.Enabled = True
            fees = Val(txtFee.Text)
        End If
    End Sub

    Private Sub clear() '******** sub procedure- this should be called in an event procedure ********
        txtCode.Text = ""
        txtCName.Text = ""
        cmbDuration.SelectedIndex = -1
        rdioFtime.Checked = False
        rdioPtime.Checked = False
        txtFee.Text = ""
        txtFee.Enabled = True
        cmbLevel.SelectedIndex = -1
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dur = cmbDuration.Text
        Lvl = cmbLevel.Text
        CrsCode = Trim(txtCode.Text)
        'to assign values for course type and course feee
        RdioChnge()

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        'insert record for course table
        cmd1 = New SqlCommand(" INSERT INTO Course(course_Code,course_Name,Duration,course_Type,course_Fee,Level) VALUES('" & CrsCode & "', '" & txtCName.Text & "','" & Dur & "','" & type & "','" & fees & "','" & Lvl & "' )", cn)

        If CrsCode.Length > 8 Then
            MsgBox("In Course Code allowed is Maximum text length of 8" & vbLf & "" & vbLf & "Please use 8 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
            txtCode.Focus()
        Else
            If CrsCode <> "" Then
                Dim Check As SqlCommand
                Check = New SqlCommand("SELECT count(Course_Code) FROM Course WHERE Course_Code='" & CrsCode & "' ", cn)

                'check if Save Code Exist in Already
                Dim Count = Convert.ToInt32(Check.ExecuteScalar)

                If Count > 0 Then
                    MsgBox("Course Code Already Exist...!", MsgBoxStyle.Exclamation, "Save")
                Else
                    'confirm saving
                    Ans = MsgBox("Do you Want to save Changes..?", vbYesNo + vbQuestion, "Save")

                    If Ans = vbYes Then
                        cmd1.ExecuteNonQuery()
                        MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
                        ' clear the form data
                        clear()
                    Else
                        MsgBox("Save Canceled..", MsgBoxStyle.Information, "Save")
                    End If

                    cn.Close()
                End If
            Else
                MsgBox("Please Enter Course Code", vbOKOnly + vbCritical, "Error..!")
                txtCode.Focus()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSrchBox.Text = "Search Course Code Hear :" Then
            txtSrchBox.Text = ""
        End If  'to search box tital clear

        Dim cmd2 As New SqlCommand
        CrsCode = Trim(txtSrchBox.Text) 'trim - to remove leading spaces in the text box

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        cmd2 = New SqlCommand("SELECT * FROM Course WHERE course_Code='" & CrsCode & "'", cn)

        Dim adapter As New SqlDataAdapter(cmd2)
        Dim table As New DataTable
        adapter.Fill(table)

        clear()

        If CrsCode <> "" Then
            If table.Rows.Count > 0 Then

                txtCode.Text = table.Rows(0)(0).ToString()
                txtCName.Text = table.Rows(0)(1).ToString()
                cmbDuration.Text = table.Rows(0)(2).ToString()

                Dim Type2 As String
                Type2 = table.Rows(0)(3).ToString()
                If Type2 = "Full Time" Then
                    rdioFtime.Checked = True
                ElseIf Type2 = "Part Time" Then
                    rdioPtime.Checked = True
                End If

                txtFee.Text = table.Rows(0)(4).ToString()
                cmbLevel.Text = table.Rows(0)(5).ToString()
            Else
                MsgBox("Details Not Found..!!" & vbLf & "Enter Valid Course Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Sorry...!")
                txtSrchBox.ForeColor = Color.Red
            End If
        Else
            MsgBox("Please Fill the Course Code in Search Box..!!", MsgBoxStyle.Exclamation, "Sorry...!")
            txtSrchBox.Text = "Search Course Code Hear :"
            txtSrchBox.Focus()
        End If
        cn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        CrsCode = Trim(txtCode.Text)

        RdioChnge() 'radio Button Update

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        Dim cmdUpdate As SqlCommand
        Dim UpdateQuery As String
        UpdateQuery = "UPDATE Course SET course_Name='" & txtCName.Text & "', Duration='" & cmbDuration.Text & "',course_Type='" & type & "',course_fee='" & fees & "',Level='" & cmbLevel.Text & "' WHERE course_Code= '" & CrsCode & "' "
        cmdUpdate = New SqlCommand(UpdateQuery, cn)

        If CrsCode <> "" Then
            Dim Check As SqlCommand
            Check = New SqlCommand("SELECT count(Course_Code) FROM Course WHERE course_Code='" & CrsCode & "' ", cn)

            Dim Count = Convert.ToInt32(Check.ExecuteScalar)

            If Count > 0 Then
                Dim UpAns As String
                UpAns = MsgBox("Are you sure..!!" & vbLf & "Do you want to update this Details..?", vbYesNo + vbQuestion, "Update Details")

                If UpAns = vbYes Then
                    cmdUpdate.ExecuteNonQuery()
                    MsgBox("Update Successfully..!!", MsgBoxStyle.Information, "Update Details")
                    clear()
                Else
                    MsgBox("Canceled..!!", MsgBoxStyle.Information, "Update Details")
                End If
            Else
                MsgBox("The Course Code is not Matched.." & vbLf & "Enter Valid Course Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Update Details")
                txtCode.Focus()
            End If

        Else
            MsgBox("Please Fill the Course Code", MsgBoxStyle.Exclamation, "Sorry...!")
            txtCode.Focus()
        End If
        cn.Close()

    End Sub

    Private Sub btnDelete_click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CrsCode = Trim(txtCode.Text)

        If CrsCode = "" Then
            MsgBox("Please Fill the Course Code", MsgBoxStyle.Exclamation, "Sorry...!")
            txtCode.Focus()
        Else
            If cn.State = ConnectionState.Closed Then
                cn.Open() 'To open the data base connection
            End If

            Dim cmdDelete As SqlCommand
            cmdDelete = New SqlCommand("DELETE Course WHERE course_Code= '" & CrsCode & "' ", cn)

            If CrsCode <> "" Then
                Dim cmdCheck As SqlCommand
                cmdCheck = New SqlCommand("SELECT count(Course_Code) FROM Course WHERE Course_Code='" & CrsCode & "' ", cn)

                'check if course Code is Exist 
                Dim Count = Convert.ToInt32(cmdCheck.ExecuteScalar)

                If Count > 0 Then
                    Dim Dans As String
                    Dans = MsgBox("Are you sure..!!" & vbLf & "Do you want to Permanently Delete this Details..?", vbYesNo + vbQuestion, "Delete Data")
                    If Dans = vbYes Then
                        cmdDelete.ExecuteNonQuery()
                        MsgBox("Details Deleted..!!", MsgBoxStyle.Information, "Delete")
                        clear()
                    Else
                        MsgBox("Canceled..", MsgBoxStyle.Information, "Delete")

                    End If
                Else
                    MsgBox("The Course Code is not Matched.." & vbLf & "Enter Valid Course Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Delete")
                    txtCode.Focus()
                End If

                cn.Close()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dur = cmbDuration.Text
        Lvl = cmbLevel.Text
        CrsCode = Trim(txtCode.Text)
        'to assign values for course type and course feee
        RdioChnge()

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        If txtCode.Text = "" And txtCName.Text = "" And cmbDuration.Text = "" And txtFee.Text = "" And cmbLevel.Text = "" Then     '  Or rdioFtime.Checked = False And rdioPtime.Checked = False
            ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
            If ExtAns = vbYes Then
                End
            End If
        Else
            'insert record for course table
                cmd1 = New SqlCommand(" INSERT INTO Course(course_Code,course_Name,Duration,course_Type,course_Fee,Level) VALUES('" & CrsCode & "', '" & txtCName.Text & "','" & Dur & "','" & type & "','" & fees & "','" & Lvl & "' )", cn)

            If CrsCode <> "" Then
                Dim Check As SqlCommand
                Check = New SqlCommand("SELECT count(Course_Code) FROM Course WHERE Course_Code='" & CrsCode & "' ", cn)

                'check if Save Code Exist in Already
                Dim Count = Convert.ToInt32(Check.ExecuteScalar)

                If Count > 0 Then
                    ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
                    If ExtAns = vbYes Then
                        End
                    End If
                Else
                    ExtAns = MsgBox("Do you Want to Save and Exit..?", vbYesNoCancel + vbQuestion, "Exit")
                    If ExtAns = vbYes Then
                        If CrsCode.Length > 8 Then
                            MsgBox("In Course Code allowed is Maximum text length of 8" & vbLf & "" & vbLf & "Please use 8 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
                            txtCode.Focus()
                        Else
                            cmd1.ExecuteNonQuery()
                            MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
                            End
                        End If
                    ElseIf ExtAns = vbNo Then
                        End
                    End If

                    cn.Close()
                End If
            Else
                ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
                If ExtAns = vbYes Then
                    End
                End If
            End If
        End If
    End Sub

    Private Sub txtSrchBox_Click(sender As Object, e As EventArgs) Handles txtSrchBox.Click
        txtSrchBox.ForeColor = Color.Black
        If txtSrchBox.Text = "Search Course Code Hear :" Then
            txtSrchBox.Text = ""
        End If

    End Sub

    Private Sub txtAllBoxes_Click(sender As Object, e As EventArgs) Handles txtFee.Click, txtCode.Click, txtCName.Click, rdioPtime.Click, rdioFtime.Click, cmbLevel.Click, cmbDuration.Click
        If txtSrchBox.Text = "" Then
            txtSrchBox.Text = "Search Course Code Hear :"
            txtSrchBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub lnkClearForm_Click(sender As Object, e As EventArgs) Handles lnkClearForm.Click
        clear()
    End Sub


    'Private Sub frmCourse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    'End Sub

    'Private Sub frmCourse_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    Dur = cmbDuration.Text
    '    Lvl = cmbLevel.Text
    '    CrsCode = Trim(txtCode.Text)
    '    Dim frm As New frmCourse
    '    'to assign values for course type and course feee
    '    RdioChnge()

    '    If cn.State = ConnectionState.Closed Then
    '        cn.Open() 'To open the data base connection
    '    End If

    '    If txtCode.Text = "" And txtCName.Text = "" And cmbDuration.Text = "" And txtFee.Text = "" And cmbLevel.Text = "" Then     '  Or rdioFtime.Checked = False And rdioPtime.Checked = False
    '        ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
    '        If ExtAns = vbYes Then
    '            frm.Close()
    '        ElseIf ExtAns = vbNo Then
    '            frm.Show()
    '        End If
    '    Else
    '        'insert record for course table
    '        cmd1 = New SqlCommand(" INSERT INTO Course(course_Code,course_Name,Duration,course_Type,course_Fee,Level) VALUES('" & CrsCode & "', '" & txtCName.Text & "','" & Dur & "','" & type & "','" & fees & "','" & Lvl & "' )", cn)

    '        If CrsCode <> "" Then
    '            Dim Check As SqlCommand
    '            Check = New SqlCommand("SELECT count(Course_Code) FROM Course WHERE Course_Code='" & CrsCode & "' ", cn)

    '            'check if Save Code Exist in Already
    '            Dim Count = Convert.ToInt32(Check.ExecuteScalar)

    '            If Count > 0 Then
    '                ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
    '                If ExtAns = vbYes Then
    '                    frm.Close()
    '                ElseIf ExtAns = vbNo Then
    '                    frm.Show()
    '                End If
    '            Else
    '                ExtAns = MsgBox("Do you Want to Save and Exit..?", vbYesNoCancel + vbQuestion, "Exit")
    '                If ExtAns = vbYes Then
    '                    If CrsCode.Length > 8 Then
    '                        MsgBox("In Course Code allowed is Maximum text length of 8" & vbLf & "" & vbLf & "Please use 8 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
    '                        txtCode.Focus()
    '                    Else
    '                        cmd1.ExecuteNonQuery()
    '                        MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
    '                        End
    '                    End If
    '                ElseIf ExtAns = vbNo Then
    '                    frm.Close()
    '                End If
    '                cn.Close()
    '            End If
    '        Else
    '            ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
    '            If ExtAns = vbYes Then
    '                frm.Close()
    '            ElseIf ExtAns = vbNo Then
    '                frm.Show()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub lnkStDt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStDt.LinkClicked
        Me.Hide()
        frmStDt.Show()
    End Sub

    Private Sub lnkCrsMo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrsMo.LinkClicked
        Me.Hide()
        frmModule.Show()
    End Sub


    Private Sub lnkVwTables_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkVwTables.LinkClicked
        Me.Hide()
        frmViewTables.Show()
    End Sub

    Private Sub btnSrchClear_Click(sender As Object, e As EventArgs) Handles btnSrchClear.Click
        txtSrchBox.Text = ""
    End Sub

End Class '*********** peper's one ********
