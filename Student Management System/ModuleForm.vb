Imports System.Data.SqlClient '******** First: Change Database Path (cn) *********

Public Class frmModule

    Dim ModCode, CrsCode As String

    Private Sub frmModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LD()

        Dim CoBoxFill As New SqlCommand

        CoBoxFill = New SqlCommand("SELECT * FROM Course;", cn)

        Dim adapter As New SqlDataAdapter(CoBoxFill)
        Dim table As New DataTable
        adapter.Fill(table)

        cmbCrsCode.DataSource = table

        cmbCrsCode.DisplayMember = "Course_Name"
        cmbCrsCode.ValueMember = "Course_Code"

        cmbCrsCode.SelectedIndex = -1
        'cmbCrsCode.Items.Add()
    End Sub

    Private Sub clear() '******** sub procedure- this should be called in an event procedure ********
        cmbCrsCode.SelectedIndex = -1
        txtCrsCode.Text = ""
        txtModCode.Text = ""
        txtModName.Text = ""
        txtNHours.Text = ""
    End Sub

    Private Sub cmbCrsCode_DropDownClosed(sender As Object, e As EventArgs) Handles cmbCrsCode.DropDownClosed
        txtCrsCode.Text = cmbCrsCode.SelectedValue
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd1 As SqlCommand
        Dim Ans, ModCode As String
        ModCode = Trim(txtModCode.Text)
        CrsCode = cmbCrsCode.SelectedValue

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        'insert record for course table
        cmd1 = New SqlCommand("INSERT INTO Module(Module_Code,Course_Code,Module_Name,Module_Hours) VALUES('" & txtModCode.Text & "','" & cmbCrsCode.SelectedValue & "','" & txtModName.Text & "','" & txtNHours.Text & "')", cn)
        If CrsCode <> "" Then
            If ModCode.Length > 10 Then
                MsgBox("In Module Code allowed is Maximum text length of 10" & vbLf & "" & vbLf & "Please use 10 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
                txtModCode.Focus()
            Else
                If ModCode <> "" Then
                    Dim Check As SqlCommand
                    Check = New SqlCommand("SELECT count(Module_Code) FROM Module WHERE Module_Code='" & ModCode & "' ", cn)

                    'check if Save Code Exist in Already
                    Dim Count = Convert.ToInt32(Check.ExecuteScalar)

                    If Count > 0 Then
                        MsgBox("Module Code Already Exist...!", MsgBoxStyle.Exclamation, "Save")
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
                    MsgBox("Please Enter Module Code", vbOKOnly + vbCritical, "Error..!")
                    txtModCode.Focus()
                End If
            End If
        Else
            MsgBox("Please Select Course Name", vbOKOnly + vbCritical, "Error..!")
            cmbCrsCode.Focus()
        End If
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSrchBox.Text = "Search Module Code Hear :" Then
            txtSrchBox.Text = ""
        End If  'to search box tital clear

        Dim cmd2 As New SqlCommand
        ModCode = Trim(txtSrchBox.Text) 'trim - to remove leading spaces in the text box

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        cmd2 = New SqlCommand("SELECT * FROM Module WHERE Module_Code='" & ModCode & "'", cn)

        Dim adapter As New SqlDataAdapter(cmd2)
        Dim table As New DataTable
        adapter.Fill(table)

        clear()

        If ModCode <> "" Then
            If table.Rows.Count > 0 Then

                txtModCode.Text = table.Rows(0)(0).ToString()
                cmbCrsCode.SelectedValue = table.Rows(0)(1).ToString()
                txtModName.Text = table.Rows(0)(2).ToString()
                txtNHours.Text = table.Rows(0)(3).ToString()

                txtCrsCode.Text = cmbCrsCode.SelectedValue
            Else
                MsgBox("Details Not Found..!!" & vbLf & "Enter Valid Module Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Sorry...!")
                txtSrchBox.ForeColor = Color.Red
            End If
        Else
            MsgBox("Please Fill the Module Code in Search Box..!!", MsgBoxStyle.Exclamation, "Sorry...!")
            txtSrchBox.Text = "Search Module Code Hear :"
            txtSrchBox.Focus()
        End If
        cn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ModCode = Trim(txtModCode.Text)

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        Dim cmdUpdate As SqlCommand
        Dim UpdateQuery As String
        UpdateQuery = "UPDATE Module SET Module_Name='" & txtModName.Text & "', Course_Code='" & cmbCrsCode.SelectedValue & "',Module_Hours='" & CInt(txtNHours.Text) & "' WHERE Module_Code= '" & ModCode & "' "
        cmdUpdate = New SqlCommand(UpdateQuery, cn)

        If ModCode <> "" Then
            Dim Check As SqlCommand
            Check = New SqlCommand("SELECT count(Module_Code) FROM Module WHERE Module_Code='" & ModCode & "' ", cn)

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
                MsgBox("The Module Code is not Matched.." & vbLf & "Enter Valid Module Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Update Details")
                txtModCode.Focus()
            End If

        Else
            MsgBox("Please Fill the Module Code", MsgBoxStyle.Exclamation, "Sorry...!")
            txtModCode.Focus()
        End If
        cn.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ModCode = Trim(txtModCode.Text)

        If ModCode = "" Then
            MsgBox("Please Fill the Module Code", MsgBoxStyle.Exclamation, "Sorry...!")
            txtModCode.Focus()
        Else
            If cn.State = ConnectionState.Closed Then
                cn.Open() 'To open the data base connection
            End If

            Dim cmdDelete As SqlCommand
            cmdDelete = New SqlCommand("DELETE Module WHERE Module_Code= '" & ModCode & "' ", cn)

            If ModCode <> "" Then
                Dim cmdCheck As SqlCommand
                cmdCheck = New SqlCommand("SELECT count(Module_Code) FROM Module WHERE Module_Code='" & ModCode & "' ", cn)

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
                    MsgBox("The Module Code is not Matched.." & vbLf & "Enter Valid Module Code.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Delete")
                    txtModCode.Focus()
                End If
                cn.Close()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim cmd1 As SqlCommand
        Dim ExtAns, ModCode As String
        ModCode = Trim(txtModCode.Text)
        CrsCode = cmbCrsCode.SelectedValue

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        If txtModCode.Text = "" And cmbCrsCode.SelectedIndex = -1 And txtModName.Text = "" And txtNHours.Text = "" Then     '  Or rdioFtime.Checked = False And rdioPtime.Checked = False
            ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
            If ExtAns = vbYes Then
                End
            End If
        Else
            'insert record for course table
            cmd1 = New SqlCommand("INSERT INTO Module(Module_Code,Course_Code,Module_Name,Module_Hours) VALUES('" & txtModCode.Text & "','" & cmbCrsCode.SelectedValue & "','" & txtModName.Text & "','" & txtNHours.Text & "')", cn)

            If ModCode <> "" Then
                Dim Check As SqlCommand
                Check = New SqlCommand("SELECT count(Module_Code) FROM Module WHERE Module_Code='" & ModCode & "' ", cn)

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
                        If CrsCode <> "" Then
                            If ModCode.Length > 10 Then
                                MsgBox("In Module Code allowed is Maximum text length of 10" & vbLf & "" & vbLf & "Please use 10 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
                                txtModCode.Focus()
                            Else
                                cmd1.ExecuteNonQuery()
                                MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
                                End
                            End If
                        Else
                            MsgBox("Please Select Course Name", vbOKOnly + vbCritical, "Error..!")
                            cmbCrsCode.Focus()
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
        If txtSrchBox.Text = "Search Module Code Hear :" Then
            txtSrchBox.Text = ""
        End If
    End Sub

    Private Sub txtAllBoxes_Click(sender As Object, e As EventArgs) Handles txtNHours.Click, txtModName.Click, txtModCode.Click, txtCrsCode.Click, cmbCrsCode.Click
        If txtSrchBox.Text = "" Then
            txtSrchBox.Text = "Search Module Code Hear :"
            txtSrchBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub lnkClearForm_Click(sender As Object, e As EventArgs) Handles lnkClearForm.Click
        clear()
    End Sub


    Private Sub lnkStDt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStDt.LinkClicked
        Me.Hide()
        frmStDt.Show()
    End Sub

    Private Sub lnkCrs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrs.LinkClicked
        Me.Hide()
        frmCourse.Show()
    End Sub

    Private Sub lnkVwTables_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkVwTables.LinkClicked
        Me.Hide()
        frmViewTables.Show()
    End Sub

    Private Sub btnSrchClear_Click(sender As Object, e As EventArgs) Handles btnSrchClear.Click
        txtSrchBox.Text = ""
    End Sub
End Class