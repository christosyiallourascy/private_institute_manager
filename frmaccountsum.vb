Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmaccountsum
    Private qry As String
    Dim totalselected As Double
    Private mode As Integer = 1
    'Private allmonths() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If mode.Equals(1) Then
                qry = "select sum(paymentamount) from tblpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
                lblresult.Text = "The payments between " & startdate.Value.Date & " " & vbCrLf & "and " & enddate.Value.Date & " is:"
                txtresult.Text = Form1.con.returnSingleValueFor(qry) & " €"
                qry = "select (paymentid) As 'Payment ID', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tblpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            ElseIf mode.Equals(0) Then
                qry = "select sum(paymentamount) from tbladultpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
                lblresult.Text = "The adult payments between " & startdate.Value.Date & " " & vbCrLf & "and " & enddate.Value.Date & " is:"
                txtresult.Text = Form1.con.returnSingleValueFor(qry) & " €"
                qry = "select (adultpaymentid) As 'Payment ID', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tbladultpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If mode.Equals(1) Then
                qry = "select sum(paymentamount) from private_institute.tblpayment where month(str_to_date(paymentdate, '%d/%m/%Y')) = '" + (cmbmonth.SelectedIndex + 1).ToString + "' and schoolyear = '" + comboschoolyear.Text + "'"
                lblresult.Text = "The payments for the month " & cmbmonth.Text & " is:"
                txtresult.Text = Form1.con.returnSingleValueFor(qry) & " €"
                qry = "select (paymentid) As 'Payment ID',  (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tblpayment where month(str_to_date(paymentdate, '%d/%m/%Y')) like '%" + (cmbmonth.SelectedIndex + 1).ToString + "%' and schoolyear = '" + comboschoolyear.Text + "'"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            ElseIf mode.Equals(0) Then
                qry = "select sum(paymentamount) from private_institute.tbladultpayment where month(str_to_date(paymentdate, '%d/%m/%Y')) = '" + (cmbmonth.SelectedIndex + 1).ToString + "' and schoolyear = '" + comboschoolyear.Text + "'"
                lblresult.Text = "The adult payments for the month " & cmbmonth.Text & " is:"
                txtresult.Text = Form1.con.returnSingleValueFor(qry) & " €"
                qry = "select (adultpaymentid) As 'Adult Payment ID',  (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tbladultpayment where month(str_to_date(paymentdate, '%d/%m/%Y')) like '%" + (cmbmonth.SelectedIndex + 1).ToString + "%' and schoolyear = '" + comboschoolyear.Text + "'"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmaccountsum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If mode.Equals(1) Then

                qry = "select (t.firstname) as 'First Name', (t.lastname) as 'Last Name', (t1.fathername) as 'Father Name', (t2.month) 'Month Paid' from tblstudent t, tblstudentaccount t1, tblpayment t2 where t.studentaccid = t1.studentaccid and t2.studentaccid = t1.studentaccid and (t2.month like '%" + (cmbmonth.SelectedIndex + 1).ToString + ", %' or t2.month like '%, " + (cmbmonth.SelectedIndex + 1).ToString + "%' or t2.month = '" + (cmbmonth.SelectedIndex + 1).ToString + "') and t2.schoolyear = '" + comboschoolyear.Text + "'"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            ElseIf mode.Equals(0) Then
                qry = "select (adultpaymentid) As 'Adult Payment ID',  (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tbladultpayment where (month like '%" + (cmbmonth.SelectedIndex + 1).ToString + ",%' or month = '" + (cmbmonth.SelectedIndex + 1).ToString + "') and schoolyear = '" + comboschoolyear.Text + "'"
                dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
                dgfilteredpayments.AutoResizeColumns()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If mode.Equals(1) Then
            mode = 0
            Me.Text = "Payments Summary - " & "Adult Mode"
        ElseIf mode.Equals(0) Then
            mode = 1
            Me.Text = "Payments Summary - " & "Student Mode"
        End If
    End Sub

    Private Sub btnshowsummall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshowsummall.Click
        Try
            Dim result As Double
            qry = "select sum(paymentamount) from tblpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
            result = Val(Form1.con.returnSingleValueFor(qry))

            qry = "select sum(paymentamount) from tbladultpayment where str_to_date(paymentdate, '%d/%m/%Y') between str_to_date('" + startdate.Value.Date + "', '%d/%m/%Y') and str_to_date('" + enddate.Value.Date + "', '%d/%m/%Y')"
            lblresult.Text = "The students and adults payments" + vbNewLine + " between " & startdate.Value.Date & " and " & enddate.Value.Date & " is:"
            result = result + Val(Form1.con.returnSingleValueFor(qry))

            txtresult.Text = result & " €"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnallbalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallbalance.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sy As String() = Nothing
        Dim myfont As New Font("Courier New", 12, FontStyle.Regular)
        Dim myfont1 As New Font("Courier New", 14, FontStyle.Bold)
        Dim myfont2 As New Font("Courier New", 12, FontStyle.Bold)
        FontHeight = myfont.GetHeight(e.Graphics) + 5
        Dim x, y As Integer
        Dim bname As String = Nothing
        Dim accdiscount As Double
        Dim accid As String() = Nothing
        Dim totalpaid As Double
        Dim monthlyfees As Double
        Dim balance As Double
        Dim linecounter As Integer = 0
        Dim linesperpage As Integer = 0
        Static indexprinted As Integer
        Static pageprinted As Integer = 0
        linesperpage = e.MarginBounds.Height / myfont.GetHeight(e.Graphics)

        Try
            qry = "select year from tblclass group by(year) desc"
            sy = Form1.con.returnColumnFor(qry)
            qry = "select branch from tblbranchinfo limit 1"
            bname = Form1.con.returnSingleValueFor(qry)
            x = 50
            y = 50
            If pageprinted < 1 Then
                e.Graphics.DrawString("CYBERNET COMPUTER TRAINING CENTERS", myfont1, Brushes.Black, x, y)
                y = y + FontHeight
                linecounter = linecounter + 1
                e.Graphics.DrawString("Branch Name: " & bname, myfont1, Brushes.Black, x, y)
                y = y + FontHeight
                linecounter = linecounter + 1
                y = y + FontHeight
                linecounter = linecounter + 1
            End If
            qry = "select studentaccid from tblstudentaccount where status ='Active'"
            accid = Form1.con.returnColumnFor(qry)
            For i = 0 To accid.Length - 1
                If linecounter >= 30 Then
                    e.HasMorePages = True
                    pageprinted = pageprinted + 1
                    linecounter = 0
                    Exit Sub
                Else
                    e.HasMorePages = False
                End If
                If indexprinted < i Then
                    Dim family As String() = Nothing
                    qry = "select fathername, familyname from tblstudentaccount where studentaccid = '" + accid(i) + "' and status='Active' limit 1"
                    Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                    family = Form1.con.nextRow()
                    family = Form1.con.previousRow()
                    e.Graphics.DrawString("Father Name: " & family(0), myfont1, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    e.Graphics.DrawString("Family Name: " & family(1), myfont1, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    qry = "select discount from tblstudentaccount where studentaccid = '" + accid(i) + "' and status='Active'"
                    accdiscount = Val(Form1.con.returnSingleValueFor(qry))
                    qry = "select sum(paymentamount) from tblpayment where studentaccid='" + accid(i) + "' and schoolyear='" + sy(0) + "'"
                    totalpaid = Val(Form1.con.returnSingleValueFor(qry))
                    qry = "select sum(t3.classfees) from tblstudent t1, tblstudentclass t2, tblclass t3 where t1.studentaccid = '" + accid(i) + "'  and t1.status = 'Active' and t2.studentid = t1.studentid and t2.classid = t3.classid and t3.year = '" + sy(0) + "'"
                    monthlyfees = Val(Form1.con.returnSingleValueFor(qry))
                    monthlyfees = (monthlyfees - ((monthlyfees * accdiscount) / 100))
                    qry = "SELECT (studentaccid) As 'Student Account ID', (studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name' FROM `private_institute`.`tblstudent` where studentaccID='" + accid(i) + "' and status='Active'"
                    balance = ((monthlyfees * 10) - totalpaid)
                    qry = "SELECT studentid FROM `private_institute`.`tblstudent` where studentaccID='" + accid(i) + "' and status='Active'"
                    Dim familystudents As String() = Nothing
                    familystudents = Form1.con.returnColumnFor(qry)
                    e.Graphics.DrawString("Student ID", myfont1, Brushes.Black, x + 100, y)
                    e.Graphics.DrawString("First Name", myfont1, Brushes.Black, x + 300, y)
                    e.Graphics.DrawString("Last Name", myfont1, Brushes.Black, x + 500, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    For j = 0 To familystudents.Length - 1
                        Dim stdnt As String() = Nothing
                        qry = "SELECT (studentaccid) As 'Student Account ID', (studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name' FROM `private_institute`.`tblstudent` where studentaccID='" + accid(i) + "' and studentid='" + familystudents(j) + "'"
                        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                        stdnt = Form1.con.nextRow()
                        stdnt = Form1.con.previousRow()
                        e.Graphics.DrawString(stdnt(1), myfont, Brushes.Black, x + 100, y)
                        e.Graphics.DrawString(stdnt(2), myfont, Brushes.Black, x + 300, y)
                        e.Graphics.DrawString(stdnt(3), myfont, Brushes.Black, x + 500, y)
                        y = y + FontHeight
                        linecounter = linecounter + 1
                    Next j
                    e.Graphics.DrawString("Monthly fees: " & monthlyfees & " €", myfont, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    e.Graphics.DrawString("Discount: " & accdiscount & "%", myfont, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    e.Graphics.DrawString("Total Paid: " & totalpaid & " €", myfont, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    e.Graphics.DrawString("Balance: " & balance & " €", myfont, Brushes.Black, x, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    e.Graphics.DrawString("-------------------------------------------", myfont1, Brushes.Black, 100, y)
                    y = y + FontHeight
                    linecounter = linecounter + 1
                    indexprinted = indexprinted + 1
                End If

            Next i
            e.Graphics.DrawString(Today.Date.ToString, myfont1, Brushes.Black, x, y)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim accountpaidselectedmonth As String() = Nothing
            Dim accountnotpaid As String() = Nothing
            Dim appendqrystring As String = ""
            qry = "select t.studentaccid from tblpayment t where (t.month like '%" + (cmbmonth.SelectedIndex + 1).ToString + ",%' or t.month like '%, " + (cmbmonth.SelectedIndex + 1).ToString + "%' or t.month = '" + (cmbmonth.SelectedIndex + 1).ToString + "')"
            accountpaidselectedmonth = Form1.con.returnColumnFor(qry)
            For i = 0 To accountpaidselectedmonth.Count - 1

                appendqrystring = appendqrystring & " and t.studentaccid not like '" & i & "'"
            Next i
            qry = "select (t.firstname) as 'First Name', (t.lastname) as 'Last Name', (t1.fathername) as 'Father Name' from tblstudent t, tblstudentaccount t1 where t.studentaccid = t1.studentaccid" & appendqrystring
            dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
            dgfilteredpayments.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try

            qry = "select (paymentid) As 'Payment ID',  (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month from tblpayment where paymentid >= '" + txtrnum1.Text + "' and paymentid <= '" + txtrnum2.Text + "'"
            dgfilteredpayments.DataSource = Form1.con.returnDataTableFor(qry)
            dgfilteredpayments.AutoResizeColumns()
            qry = "select sum(paymentamount) from tblpayment where paymentid >= '" + txtrnum1.Text + "' and paymentid <= '" + txtrnum2.Text + "'"
            totalselected = Val(Form1.con.returnSingleValueFor(qry))
            txtresult.Text = totalselected.ToString & " €"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            Dim filelocation As String = ""
            Dim filename As String = ""
            filename = txtrnum1.Text & " and " & txtrnum2.Text
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.ActiveSheet
            xlWorkSheet.Cells(1, 1) = "Receipts Number Between " & filename
            xlWorkSheet.Cells(2, 1) = "Receipts Number"
            xlWorkSheet.Cells(2, 2) = "Amount Paid"
            xlWorkSheet.Cells(2, 3) = "Monthly Payment"
            xlWorkSheet.Cells(2, 4) = "Name"
            xlWorkSheet.Cells(2, 5) = "Date"
            xlWorkSheet.Cells(2, 6) = "Month Paid"
            For i = 0 To dgfilteredpayments.RowCount - 2
                For j = 0 To dgfilteredpayments.ColumnCount - 1
                    xlWorkSheet.Cells(i + 3, j + 1) = _
                        dgfilteredpayments(j, i).Value.ToString()
                Next
            Next
            xlWorkSheet.Cells(i + 4, 2) = totalselected.ToString
            fbd.ShowDialog()
            filelocation = fbd.SelectedPath.ToString & "\Receipts Number Between " & filename & ".xlsx"
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