Imports System.Data.SqlClient

Module Module1
    Public cn As SqlConnection

    Public Sub LD()
        cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MP_ Works\My Dev Projects\Vb .net\institute-management-system - Copy\Student Management System\Student.mdf;Integrated Security=True;Connect Timeout=30")
    End Sub

End Module
