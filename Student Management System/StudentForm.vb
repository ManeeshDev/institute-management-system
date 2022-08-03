Imports System.Data.SqlClient

Public Class frmStDt
    Dim Ans, DuplFound, CrsCode, StNo, Gender As String
    Dim cmd As SqlCommand
    Dim OL As String = "No"
    Dim AL As String = "No"
    Dim Degree As String = "No"
    Dim Other As String = "No"
    'Dim OL, AL, Degree, Other As String

    Private Sub frmStDt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LD()
        'To, auto fill course name text box
        Dim CoBoxFill As New SqlCommand
        CoBoxFill = New SqlCommand("SELECT * FROM Course;", cn)

        Dim adapter As New SqlDataAdapter(CoBoxFill)
        Dim table As New DataTable
        adapter.Fill(table)

        cmbCrsCode.DataSource = table

        cmbCrsCode.DisplayMember = "Course_Name" 'displaing course name but, it have course cord
        cmbCrsCode.ValueMember = "Course_Code"   ' course code asing to course name 

        cmbCrsCode.SelectedIndex = -1 'To, change starting view combo box 
    End Sub

    Private Sub rdioMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdioMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub rdioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdioFemale.CheckedChanged
        Gender = "Female"
    End Sub

    'To, change checkbox values
    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkOther.CheckedChanged, chkOL.CheckedChanged, chkDeg.CheckedChanged, chkAL.CheckedChanged

        If chkOL.Checked = True Then
            OL = "Yes"
        Else
            OL = "No"
        End If

        If chkAL.Checked = True Then
            AL = "Yes"
        Else
            AL = "No"
        End If

        If chkDeg.Checked = True Then
            Degree = "Yes"
        Else
            Degree = "No"
        End If

        If chkOther.Checked = True Then
            Other = "Yes"
        Else
            Other = "No"
        End If
    End Sub

    'To, get corse code From corse name text box
    Private Sub cmbCrsCode_DropDownClosed(sender As Object, e As EventArgs) Handles cmbCrsCode.DropDownClosed
        txtCrsCode.Text = cmbCrsCode.SelectedValue
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        StNo = Trim(txtStNo.Text)
        CrsCode = cmbCrsCode.SelectedValue

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        'insert record for course table
        cmd = New SqlCommand("INSERT INTO Student(Student_No,Course_Code,NIC,Student_Name,Address,DOB,Gender,OL,AL,Degree,Other,Pro_Qualification) VALUES('" & StNo & "','" & CrsCode & "','" & txtNic.Text & "','" & txtStName.Text & "','" & txtAddress.Text & "','" & CDate(txtDob.Text) & "','" & Gender & "','" & OL & "','" & AL & "','" & Degree & "','" & Other & "','" & cmbPQ.Text & "')", cn)

        If StNo.Length > 14 Then
            MsgBox("In Student Number allowed is Maximum text length of 14" & vbLf & "" & vbLf & "Please use 14 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
            txtStNo.Focus()
        Else
            If StNo <> "" Then
                Dim Check As SqlCommand
                Check = New SqlCommand("SELECT count(Student_No) FROM Student WHERE Student_No='" & StNo & "' ", cn)

                'check if Save Code Exist in Already
                Dim Count = Convert.ToInt32(Check.ExecuteScalar)

                If Count > 0 Then
                    MsgBox("Student Number Already Exist...!", MsgBoxStyle.Exclamation, "Save")
                Else
                    If CrsCode <> "" Then
                        'confirm saving
                        Ans = MsgBox("Do you Want to save Changes..?", vbYesNo + vbQuestion, "Save")

                        If Ans = vbYes Then
                            cmd.ExecuteNonQuery()
                            MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
                            ' clear the form data
                            clear()
                        Else
                            MsgBox("Save Canceled..", MsgBoxStyle.Information, "Save")
                        End If
                    Else
                        MsgBox("Please Select Course Name", vbOKOnly + vbCritical, "Error..!")
                        cmbCrsCode.Focus()
                    End If
                    cn.Close()
            End If
            Else
                MsgBox("Please Enter Student Number", vbOKOnly + vbCritical, "Error..!")
                txtStNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSrchBox.Text = "Search Student Number Hear :" Then
            txtSrchBox.Text = ""
        End If  'to search box tital clear

        Dim cmd2 As New SqlCommand
        StNo = Trim(txtSrchBox.Text)
        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        cmd2 = New SqlCommand("SELECT * FROM Student WHERE Student_No='" & StNo & "'", cn)

        Dim adapter As New SqlDataAdapter(cmd2)
        Dim table As New DataTable
        adapter.Fill(table)

        clear()

        If StNo <> "" Then
            If table.Rows.Count > 0 Then

                txtStNo.Text = table.Rows(0)(0).ToString()
                cmbCrsCode.SelectedValue = table.Rows(0)(1).ToString()
                txtNic.Text = table.Rows(0)(2).ToString()
                txtStName.Text = table.Rows(0)(3).ToString()
                txtAddress.Text = table.Rows(0)(4).ToString()
                txtDob.Text = table.Rows(0)(5).ToString()
                Gender = table.Rows(0)(6).ToString()
                If Gender = "Male" Then
                    rdioMale.Checked = True
                ElseIf Gender = "Female" Then
                    rdioFemale.Checked = True
                End If

                OL = table.Rows(0)(7).ToString()
                If OL = "Yes" Then
                    chkOL.Checked = True
                End If
                AL = table.Rows(0)(8).ToString()
                If AL = "Yes" Then
                    chkAL.Checked = True
                End If
                Degree = table.Rows(0)(9).ToString()
                If Degree = "Yes" Then
                    chkDeg.Checked = True
                End If
                Other = table.Rows(0)(10).ToString()
                If Other = "Yes" Then
                    chkOther.Checked = True
                End If

                cmbPQ.Text = table.Rows(0)(11).ToString()
            Else
                MsgBox("Details Not Found..!!" & vbLf & "Enter Valid Student Number.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Sorry...!")
                txtSrchBox.ForeColor = Color.Red
            End If
        Else
            MsgBox("Please Fill the Student Number in Search Box..!!", MsgBoxStyle.Exclamation, "Sorry...!")
            txtSrchBox.Text = "Search Student Number Hear :"
            txtSrchBox.Focus()
        End If
        cn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        StNo = Trim(txtStNo.Text)

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        Dim cmdUpd As SqlCommand
        cmdUpd = New SqlCommand("UPDATE Student SET Student_No='" & txtStNo.Text & "', Course_Code='" & cmbCrsCode.SelectedValue & "',NIC='" & txtNic.Text & "',Student_Name='" & txtStName.Text & "',Address='" & txtAddress.Text & "',DOB='" & CDate(txtDob.Text) & "',Gender='" & Gender & "',OL='" & OL & "',AL='" & AL & "',Degree='" & Degree & "',Other='" & Other & "',Pro_Qualification='" & cmbPQ.Text & "' WHERE Student_No= '" & StNo & "' ", cn)

        If StNo <> "" Then
            Dim Check As SqlCommand
            Check = New SqlCommand("SELECT count(Student_No) FROM Student WHERE Student_No='" & StNo & "' ", cn)

            Dim Count = Convert.ToInt32(Check.ExecuteScalar)

            If Count > 0 Then
                Dim UpAns As String
                UpAns = MsgBox("Are you sure..!!" & vbLf & "Do you want to update this Details..?", vbYesNo + vbQuestion, "Update Details")

                If UpAns = vbYes Then
                    cmdUpd.ExecuteNonQuery()
                    MsgBox("Update Successfully..!!", MsgBoxStyle.Information, "Update Details")
                    clear()
                Else
                    MsgBox("Canceled..!!", MsgBoxStyle.Information, "Update Details")
                End If
            Else
                MsgBox("The Student Number is not Matched.." & vbLf & "Enter Valid Student Number.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Update Details")
                txtStNo.Focus()
            End If

        Else
            MsgBox("Please Fill the Student Number", MsgBoxStyle.Exclamation, "Sorry...!")
            txtStNo.Focus()
        End If
        cn.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        StNo = Trim(txtStNo.Text)

        If StNo = "" Then
            MsgBox("Please Fill the Student Number", MsgBoxStyle.Exclamation, "Sorry...!")
            txtStNo.Focus()
        Else
            If cn.State = ConnectionState.Closed Then
                cn.Open() 'To open the data base connection
            End If

            Dim cmdDelete As SqlCommand
            cmdDelete = New SqlCommand("DELETE Student WHERE Student_No= '" & StNo & "' ", cn)

            If StNo <> "" Then
                Dim cmdCheck As SqlCommand
                cmdCheck = New SqlCommand("SELECT count(Student_No) FROM Student WHERE Student_No='" & StNo & "' ", cn)

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
                    MsgBox("The Student Number is not Matched.." & vbLf & "Enter Valid Student Number.." & vbLf & "Try again..!", MsgBoxStyle.Exclamation, "Delete")
                    txtStNo.Focus()
                End If

                cn.Close()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim cmd1 As SqlCommand
        Dim ExtAns As String
        StNo = Trim(txtStNo.Text)
        CrsCode = cmbCrsCode.SelectedValue

        If cn.State = ConnectionState.Closed Then
            cn.Open() 'To open the data base connection
        End If

        If txtStNo.Text = "" And cmbCrsCode.SelectedIndex = -1 And txtNic.Text = "" And txtStName.Text = "" And txtAddress.Text = "" And txtDob.Text = "" Then
            ExtAns = MsgBox("Are you sure you want to Exit..?", vbYesNo + vbQuestion, "Exit")
            If ExtAns = vbYes Then
                End
            End If
        Else
            'insert record for course table
            cmd1 = New SqlCommand("INSERT INTO Student(Student_No,Course_Code,NIC,Student_Name,Address,DOB,Gender,OL,AL,Degree,Other,Pro_Qualification) VALUES('" & StNo & "','" & CrsCode & "','" & txtNic.Text & "','" & txtStName.Text & "','" & txtAddress.Text & "','" & CDate(txtDob.Text) & "','" & Gender & "','" & OL & "','" & AL & "','" & Degree & "','" & Other & "','" & cmbPQ.Text & "')", cn)

            If StNo <> "" Then
                Dim Check As SqlCommand
                Check = New SqlCommand("SELECT count(Student_No) FROM Student WHERE Student_No='" & StNo & "' ", cn)
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
                            If StNo.Length > 14 Then
                                MsgBox("In Module Code allowed is Maximum text length of 14" & vbLf & "" & vbLf & "Please use 14 characters and Try again..!!", vbOKOnly + vbCritical, "Error..!")
                                txtStNo.Focus()
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


    Private Sub clear() '******** sub procedure- this should be called in an event procedure ********
        txtStNo.Text = ""
        cmbCrsCode.SelectedIndex = -1
        txtCrsCode.Text = ""
        txtNic.Text = ""
        txtStName.Text = ""
        txtAddress.Text = ""
        txtDob.Text = ""
        rdioMale.Checked = False
        rdioFemale.Checked = False
        chkOL.Checked = False
        chkAL.Checked = False
        chkDeg.Checked = False
        chkOther.Checked = False
        cmbPQ.SelectedIndex = -1
    End Sub

   

    Private Sub txtSrchBox_Click(sender As Object, e As EventArgs) Handles txtSrchBox.Click
        txtSrchBox.ForeColor = Color.Black
        If txtSrchBox.Text = "Search Student Number Hear :" Then
            txtSrchBox.Text = ""
        End If
    End Sub

    Private Sub txtAllBoxes_Click(sender As Object, e As MouseEventArgs) Handles txtStNo.Click, txtStName.Click, txtNic.Click, txtDob.Click, txtCrsCode.Click, txtAddress.Click, cmbPQ.Click, cmbCrsCode.Click
        If txtSrchBox.Text = "" Then
            txtSrchBox.Text = "Search Student Number Hear :"
            txtSrchBox.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub lnkClearForm_Click(sender As Object, e As EventArgs) Handles lnkClearForm.Click
        clear()
    End Sub

    Private Sub lnkCrsMo_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrsMo.LinkClicked
        Me.Hide()
        frmModule.Show()
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