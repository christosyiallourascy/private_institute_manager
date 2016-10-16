Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmshowstudents
    Private qry As String
    Private Sub dgshowstudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select (t.firstname) as 'First Name', (t.lastname) as 'Last Name', (t1.fathername) as 'Father Name', (t1.homephone) as 'Home Phone', (t1.mobilefather) as 'Father Mobile', (t1.mobilemother) as 'Mother Mobile' from private_institute.tblstudent t, private_institute.tblstudentaccount t1 where t.studentaccid = t1.studentaccid and t.status= 'Active'"
            dgshowstudents.DataSource = Form1.con.returnDataTableFor(qry)
            dgshowstudents.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnexporttoexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexporttoexcel.Click
        Try
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            Dim filelocation As String = ""

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.ActiveSheet
            xlWorkSheet.Cells(1, 1) = "Cybernet Students"
            For i = 0 To dgshowstudents.RowCount - 2
                For j = 0 To dgshowstudents.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = _
                        dgshowstudents(j, i).Value.ToString()
                Next
            Next
            fbd.ShowDialog()
            filelocation = fbd.SelectedPath.ToString & "\activestudents.xlsx"
            xlWorkSheet.SaveAs(filelocation)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            'MsgBox("You can find the file " & filelocation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class