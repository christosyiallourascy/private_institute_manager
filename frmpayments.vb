Imports System.Text

Public Class frmpayments
    Private qry As String
    Private studentaccountid As Integer
    Private finalfees As Double
    Private accdiscount As Integer
    Dim timercounter As Integer = 0
    Private classdiscount As Double
    Private mode As Integer
    Dim countmonthpaid As Integer = 1
    Public Sub New(ByVal staccid As String, ByVal mode As Integer)
        Me.studentaccountid = staccid
        Me.mode = mode
        InitializeComponent()
        txtstudentaccid.Text = studentaccountid
        txtpaymentid.Text = "(AutoNumber)"
        txtstudentaccid.Enabled = False
        txtpaymentdate.Text = Date.Today
        txtmonth.Text = Date.Today.Month
        If mode.Equals(1) Then
            Try
                qry = "SELECT (paymentid) As 'Payment ID', (t.studentaccid) As 'Account ID', (familyname) As 'Family Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.studentaccid = '" + txtstudentaccid.Text + "' order by(paymentid) desc"
                selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                selectedpayments.AutoResizeColumns()
                Me.Text = "Payments Form - Students Mode"
            Catch ex As Exception
                ex.ToString()
            End Try
        ElseIf mode.Equals(0) Then
            Try
                qry = "SELECT (adultpaymentID) as 'Payment ID', (t1.adultid) as 'Adult ID',(firstname) as 'Firstname', (lastname) as 'Last Name', (middlename) as 'Middle Name', (paymentamount) as 'Payment Amount', (paymentdate) as 'Payment Date', (month) as 'Month', (monthlyfee) as 'Monthly Fee', (receivedby) as 'Received By' FROM private_institute.tbladultpayment t, private_institute.tbladult t1 where t.adultid = '" + txtstudentaccid.Text + "' order by(adultpaymentid) desc"
                selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                selectedpayments.AutoResizeColumns()
                Label13.Text = "Adult ID"
                Label18.Text = "Adult Give"
                Me.Text = "Payments Form - Adult Mode"
            Catch ex As Exception
                ex.ToString()
            End Try
        End If
    End Sub
    Private Sub frmpayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
            txtschoolyear.Text = comboschoolyear.Text
        Catch ex As Exception

        End Try

        If mode.Equals(1) Then
            Try
                qry = "select discount from tblstudentaccount where studentaccid = '" + txtstudentaccid.Text + "'"
                accdiscount = Form1.con.returnSingleValueFor(qry)
                qry = "select sum(t3.classfees) from tblstudent t1, tblstudentclass t2, tblclass t3 where t1.studentaccid = '" + txtstudentaccid.Text + "' and t3.closed = 'No'  and t1.status = 'Active' and t2.studentid = t1.studentid and t2.classid = t3.classid and t3.year = '" + comboschoolyear.Text + "'"
                finalfees = Val(Form1.con.returnSingleValueFor(qry))
                txtmothlyfee.Text = Math.Round(finalfees - ((finalfees * accdiscount) / 100))
                txtpaymentamount.Text = txtmothlyfee.Text
                qry = "select (t1.firstname) AS fullname from tblstudentaccount t, tblstudent t1 where t1.studentaccid = '" + txtstudentaccid.Text + "' and t1.studentaccid = t.studentaccid and t1.status = 'Active'"
                Form1.con.BindQueryTo(qry, "fullname", "fullname", txtreceivedby)
            Catch ex As Exception
                ex.ToString()
            End Try
        ElseIf mode.Equals(0) Then
            Try
                qry = "select discount from tbladult where adultid = '" + txtstudentaccid.Text + "'"
                accdiscount = Form1.con.returnSingleValueFor(qry)
                qry = "select sum(t3.classfees) from tbladult t1, tbladultclass t2, tblclass t3 where t1.adultid = '" + txtstudentaccid.Text + "' and t3.closed = 'No'  and t1.status = 'Active' and t2.adultid = t1.adultid and t2.classid = t3.classid and t3.year = '" + comboschoolyear.Text + "'"
                finalfees = Val(Form1.con.returnSingleValueFor(qry))
                txtmothlyfee.Text = Math.Round(finalfees - ((finalfees * accdiscount) / 100))
                txtpaymentamount.Text = txtmothlyfee.Text
                qry = "select CONCAT(firstname,' ', lastname) AS fullname from tbladult where adultid='" + txtstudentaccid.Text + "'"
                Form1.con.BindQueryTo(qry, "fullname", "fullname", txtreceivedby)
            Catch ex As Exception
                ex.ToString()
            End Try
        End If
    End Sub
    Private Sub refreshData()
        If mode.Equals(1) Then
            qry = "Select * from tblpayment"
            BindingNavigator1.BindingSource = Nothing
            BindingSource1.DataSource = Nothing
            BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
            BindingNavigator1.BindingSource = BindingSource1
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            DisplayData(Form1.con.returnRowFor(qry))
        ElseIf mode.Equals(0) Then
            qry = "Select * from tbladultpayment"
            BindingNavigator1.BindingSource = Nothing
            BindingSource1.DataSource = Nothing
            BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
            BindingNavigator1.BindingSource = BindingSource1
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            DisplayData(Form1.con.returnRowFor(qry))
        End If
    End Sub
    Private Sub DisplayData(ByVal tblpayments As String())

        Try
            txtpaymentid.Text = tblpayments(0)
            txtstudentaccid.Text = tblpayments(1)
            txtpaymentamount.Text = tblpayments(2)
            txtpaymentdate.Text = tblpayments(3)
            If tblpayments(4) = "Checked" Then
                txtcheque.CheckState = 1
            Else
                txtcheque.CheckState = 0
            End If
            txtchequenumber.Text = tblpayments(5)
            txtmonth.Text = tblpayments(6)
            txtmothlyfee.Text = tblpayments(7)
            txtother.Text = tblpayments(8)
            txtreceivedby.Text = tblpayments(9)
            txtbankname.Text = tblpayments(10)
            txtschoolyear.Text = tblpayments(11)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        studentaccountid = 0
        Close()
    End Sub

    Private Sub txtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.ValueChanged
        If mode.Equals(1) Then
            Try
                qry = "SELECT (paymentid) As 'Payment ID', (t.studentaccid) As 'Account ID', (familyname) As 'Family Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and paymentdate = '" + txtdate.Value.Date + "' and t.schoolyear='" + comboschoolyear.Text + "' order by(paymentid) desc"
                selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                selectedpayments.AutoResizeColumns()
                qry = "select sum(paymentamount) from tblpayment where paymentdate = '" + txtdate.Value.Date + "' and schoolyear = '" + txtschoolyear.Text + "'"
                txttotalrecieptbydate.Text = Form1.con.returnSingleValueFor(qry)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf mode.Equals(0) Then
            Try
                qry = "SELECT (adultpaymentid) As 'Adult Payment ID', (t.adultid) As 'Adult ID', (firstname) As 'First Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tbladultpayment t, tbladult t1 where t1.adultid = t.adultid and t.paymentdate = '" + txtdate.Value.Date + "' and t.schoolyear='" + comboschoolyear.Text + "' order by(adultpaymentid) desc"
                selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                selectedpayments.AutoResizeColumns()
                qry = "select sum(paymentamount) from tbladultpayment where paymentdate = '" + txtdate.Value.Date + "' and schoolyear = '" + txtschoolyear.Text + "'"
                txttotalrecieptbydate.Text = Form1.con.returnSingleValueFor(qry)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtcheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcheque.CheckedChanged
        If txtcheque.Checked = True Then
            txtbankname.Enabled = True
            txtchequenumber.Enabled = True
        ElseIf txtcheque.Checked = False Then
            txtbankname.Enabled = False
            txtchequenumber.Enabled = False
        End If
    End Sub


    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        If mode.Equals(1) Then
            Dim recievedby As String = ""
            Dim strow As String() = Nothing
            qry = "select (t1.firstname) AS fullname from tblstudentaccount t, tblstudent t1 where t1.studentaccid = '" + txtstudentaccid.Text + "' and t1.studentaccid = t.studentaccid and t1.status = 'Active'"
            strow = Form1.con.returnColumnFor(qry)
            For i = 0 To strow.Count - 1
                If strow.Count >= 1 Then
                    recievedby = strow(i) & ", " & recievedby
                Else
                    recievedby = strow(i)
                End If
            Next i
            MsgBox(recievedby)
            If Val(txtmothlyfee.Text) > Val(txtpaymentamount.Text) Then

                If MsgBox("Money entered is not enough to pay the fees. Do you you to continue with this payment?", MsgBoxStyle.YesNoCancel, "By Private Intsitute") = MsgBoxResult.Yes Then
                    Try
                        qry = "insert into tblpayment (studentaccid, paymentamount, paymentdate, cheque, chequenum, month, monthlyfee, other, receivedby, bankname, schoolyear) values ('" + txtstudentaccid.Text + "', '" + txtpaymentamount.Text + "', '" + txtpaymentdate.Text + "', '" + txtcheque.CheckState.ToString + "', '" + txtchequenumber.Text + "', '" + txtmonth.Text + "', '" + txtmothlyfee.Text + "', '" + txtother.Text + "', '" + recievedby + "', '" + txtbankname.Text + "', '" + txtschoolyear.Text + "')"
                        If Form1.con.executeNonQuery(qry) = True Then
                            MsgBox("This payment has been saved!!!")
                            qry = "SELECT (paymentid) As 'Payment ID', (t.studentaccid) As 'Account ID', (familyname) As 'Family Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.studentaccid = '" + txtstudentaccid.Text + "' order by(paymentid) desc"
                            selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                            selectedpayments.AutoResizeColumns()
                        Else
                            MsgBox("This payment has not been saved!!!")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Else
                Try
                    qry = "insert into tblpayment (studentaccid, paymentamount, paymentdate, cheque, chequenum, month, monthlyfee, other, receivedby, bankname, schoolyear) values ('" + txtstudentaccid.Text + "', '" + txtpaymentamount.Text + "', '" + txtpaymentdate.Text + "', '" + txtcheque.CheckState.ToString + "', '" + txtchequenumber.Text + "', '" + txtmonth.Text + "', '" + txtmothlyfee.Text + "', '" + txtother.Text + "', '" + recievedby + "', '" + txtbankname.Text + "', '" + txtschoolyear.Text + "')"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("This payment has been saved!!!")
                    Else
                        MsgBox("This payment has not been saved!!!")
                    End If
                Catch ex As Exception

                End Try
            End If
            Try
                qry = "select * from tblpayment order by (paymentid) desc limit 1"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                DisplayData(Form1.con.nextRow())
                DisplayData(Form1.con.previousRow())
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf mode.Equals(0) Then
            If Val(txtmothlyfee.Text) > Val(txtpaymentamount.Text) Then
                If MsgBox("Money entered is not enough to pay the fees. Do you you to continue with this payment?", MsgBoxStyle.YesNoCancel, "By Private Intsitute") = MsgBoxResult.Yes Then
                    Try
                        qry = "insert into tbladultpayment (adultid, paymentamount, paymentdate, cheque, chequenum, month, monthlyfee, other, receivedby, bankname, schoolyear) values ('" + txtstudentaccid.Text + "', '" + txtpaymentamount.Text + "', '" + txtpaymentdate.Text + "', '" + txtcheque.CheckState.ToString + "', '" + txtchequenumber.Text + "', '" + txtmonth.Text + "', '" + txtmothlyfee.Text + "', '" + txtother.Text + "', '" + txtreceivedby.Text + "', '" + txtbankname.Text + "', '" + txtschoolyear.Text + "')"
                        If Form1.con.executeNonQuery(qry) = True Then
                            MsgBox("This payment has been saved!!!")
                            qry = "SELECT (adultpaymentid) As 'Adult Payment ID', (t.adultid) As 'Adult ID', (firstname) As 'First Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tbladult t1 where t1.adultid = t.adultid and t.adultid = '" + txtstudentaccid.Text + "' order by(adultpaymentid) desc"
                            selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                            selectedpayments.AutoResizeColumns()
                        Else
                            MsgBox("This payment has not been saved!!!")
                        End If
                    Catch ex As Exception
                        ex.ToString()
                    End Try
                End If
            Else
                Try
                    qry = "insert into tbladultpayment (adultid, paymentamount, paymentdate, cheque, chequenum, month, monthlyfee, other, receivedby, bankname, schoolyear) values ('" + txtstudentaccid.Text + "', '" + txtpaymentamount.Text + "', '" + txtpaymentdate.Text + "', '" + txtcheque.CheckState.ToString + "', '" + txtchequenumber.Text + "', '" + txtmonth.Text + "', '" + txtmothlyfee.Text + "', '" + txtother.Text + "', '" + txtreceivedby.Text + "', '" + txtbankname.Text + "', '" + txtschoolyear.Text + "')"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("This payment has been saved!!!")
                    Else
                        MsgBox("This payment has not been saved!!!")
                    End If
                Catch ex As Exception
                    ex.ToString()
                End Try
            End If
            Try
                qry = "select * from tbladultpayment order by (adultpaymentid) desc limit 1"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                DisplayData(Form1.con.nextRow())
                DisplayData(Form1.con.previousRow())
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Public Sub ClearAll()
        txtpaymentid.Text = ""
        txtstudentaccid.Text = ""
        txtpaymentamount.Text = ""
        txtpaymentdate.Text = ""
        txtcheque.CheckState = "0"
        txtchequenumber.Text = ""
        txtmonth.Text = ""
        txtmothlyfee.Text = ""
        txtother.Text = ""
        txtreceivedby.Text = ""
        txtbankname.Text = ""
        txtschoolyear.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timercounter += 1
        If timercounter = 5 Then
            qry = "select sum(paymentamount) from tblpayment where paymentdate = '" + Date.Today + "' and schoolyear = '" + txtschoolyear.Text + "'"
            txttotalreciept.Text = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(paymentamount) from tbladultpayment where paymentdate = '" + Date.Today + "' and schoolyear = '" + txtschoolyear.Text + "'"
            txttotalreciept.Text = Val(txttotalreciept.Text) + Val(Form1.con.returnSingleValueFor(qry))
            timercounter = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mode.Equals(1) Then
            Dim pr As New private_institute_reports.Form1(CInt(txtpaymentid.Text))
            pr.Show()
        ElseIf mode.Equals(0) Then
            MsgBox("This preview is not available for adults")
        End If
    End Sub

    Private Sub selectedpayments_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles selectedpayments.CellClick
        If mode.Equals(1) Then
            If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
                Try
                    qry = "select * from tblpayment where paymentid='" + sender.CurrentCell.EditedFormattedValue().ToString() + "'"
                    Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                    DisplayData(Form1.con.nextRow())
                    DisplayData(Form1.con.previousRow())
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf mode.Equals(0) Then
            If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
                Try
                    qry = "select * from tbladultpayment where adultpaymentid='" + sender.CurrentCell.EditedFormattedValue().ToString() + "'"
                    Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                    DisplayData(Form1.con.nextRow())
                    DisplayData(Form1.con.previousRow())
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txttotalmonths_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalmonths.SelectedIndexChanged
        txtpaymentamount.Text = Val(txtmothlyfee.Text) * Val(txttotalmonths.Text)
    End Sub

    Private Sub txtstudentgive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentgive.TextChanged
        txtbalance.Text = Val(txtstudentgive.Text) - Val(txtpaymentamount.Text)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Courier New", 8, FontStyle.Regular)
        Dim myfont1 As New Font("Courier New", 13, FontStyle.Regular)
        Dim myfont2 As New Font("Courier New", 13, FontStyle.Bold)
        Dim x1, x2, x3, x4, y, FontHeight, FontHeight1, FontHeight0 As Integer
        Dim studentaccrow As String() = Nothing
        Dim branchinforow As String() = Nothing
        Dim onemonth As String = ""
        Dim allmonths As String() = Nothing
        Dim allmonthspaidsofar As String() = Nothing
        Dim monthspaidsofar As String() = Nothing
        Dim payid As String
        x1 = 50
        x2 = 280
        x3 = 50
        x4 = 50
        y = 50
        FontHeight = myfont.GetHeight(e.Graphics)
        FontHeight0 = myfont1.GetHeight(e.Graphics)
        FontHeight1 = myfont2.GetHeight(e.Graphics)
        If mode.Equals(1) Then

            Try
                qry = "select * from tblbranchinfo"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                branchinforow = Form1.con.nextRow()
                branchinforow = Form1.con.previousRow()
                qry = "select * from tblstudent where studentaccID='" + txtstudentaccid.Text + "' limit 1"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                studentaccrow = Form1.con.nextRow()
                studentaccrow = Form1.con.previousRow()
                e.Graphics.DrawLine(Pens.Black, 45, 45, 800, 45)
                e.Graphics.DrawImage(Image.FromFile("logo.jpg"), x1, y)
                qry = "select paymentid from tblstudentaccount t, tblpayment t1 where t.studentaccID='" + txtstudentaccid.Text + "' and t.studentaccid= t1.studentaccid and t1.schoolyear='" + comboschoolyear.Text + "'"
                monthspaidsofar = Form1.con.returnColumnFor(qry)
                qry = "select month from tblstudentaccount t, tblpayment t1 where t.studentaccID='" + txtstudentaccid.Text + "' and t.studentaccid= t1.studentaccid and t1.schoolyear='" + comboschoolyear.Text + "'"
                allmonthspaidsofar = Form1.con.returnColumnFor(qry)
                e.Graphics.DrawString("Απόδειξη/Receipt", myfont, Brushes.Black, x1, y + 80)
                y = y + FontHeight
                'branch information
                e.Graphics.DrawString(branchinforow(5), myfont1, Brushes.Black, x2 + 60, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Παράρτημα/Branch", myfont, Brushes.Black, x1, y + 30)
                e.Graphics.DrawString(branchinforow(1), myfont, Brushes.Black, x1 + 130, y + 30)
                y = y + FontHeight
                e.Graphics.DrawString("Διεύθυνση/Address", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(3), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Ιστοσελίδα/WebSite", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(4), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Αρ. Φ.Π.Α/V.A.T", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(2), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Τηλέφωνο/Telephone", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(6), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight + 20
                e.Graphics.DrawLine(Pens.Black, 45, y - 10, 800, y - 10)
                'student details
                e.Graphics.DrawString("Αρ. Απόδειξης/Receipt Number: ", myfont2, Brushes.Black, x1 + 350, y)
                e.Graphics.DrawString(txtpaymentid.Text, myfont2, Brushes.Black, x2 + 450, y)
                y = y + FontHeight0 + 15
                e.Graphics.DrawString("Έλαβα από/Recieved From ", myfont2, Brushes.Black, x1, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Επίθετο/Surname: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(studentaccrow(4), myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Όνομα/Name: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtreceivedby.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                'payment details
                e.Graphics.DrawString("Ημ. πληρωμής/Date: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtpaymentdate.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Σχ. Χρόνια/School year: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtschoolyear.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Μήνας/Month: ", myfont1, Brushes.Black, x1, y)
                allmonths = txtmonth.Text.Split(New Char() {", "})
                For i = 0 To allmonths.Count - 1
                    If allmonths.Count > 1 Then
                        onemonth = MonthName(CInt(allmonths(i))).Substring(0, 3) & ", " & onemonth
                    Else
                        onemonth = MonthName(CInt(allmonths(i))).Substring(0, 3)
                    End If
                Next
                e.Graphics.DrawString(onemonth, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                onemonth = ""
                allmonths = Nothing
                For j = 0 To allmonthspaidsofar.Count - 2
                    If allmonthspaidsofar.Count > 1 Then
                        allmonths = allmonthspaidsofar(j).Split(New Char() {", "})
                        For k = 0 To allmonths.Count - 1
                            onemonth = MonthName(CInt(allmonths(k))).Substring(0, 3) & ", " & onemonth
                        Next k
                    Else
                        onemonth = MonthName(CInt(allmonths(j))).Substring(0, 3)
                    End If
                Next j
                e.Graphics.DrawString("Κ.μήνες/M.Paid: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(onemonth, myfont1, Brushes.Black, x2 - 50, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Πόσο πληρωμής/Amount €: ", myfont2, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtpaymentamount.Text, myfont2, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                y = y + FontHeight0
                y = y + FontHeight0
                'bank details
                e.Graphics.DrawString("Μέθοδος πληρωμής/Pay", myfont2, Brushes.Black, x1, y)
                y = y + FontHeight0
                If txtcheque.CheckState = CheckState.Unchecked Then
                    e.Graphics.DrawString("Μετρητά/Cash", myfont1, Brushes.Black, x1, y)
                    y = y + FontHeight0
                    y = y + FontHeight0
                    y = y + FontHeight0
                Else
                    e.Graphics.DrawString("Όνομα τράπεζας/Bank: ", myfont1, Brushes.Black, x1, y)
                    e.Graphics.DrawString(txtbankname.Text, myfont1, Brushes.Black, x2, y)
                    y = y + FontHeight0
                    e.Graphics.DrawString("Αρ. επι./Ch. Number: ", myfont1, Brushes.Black, x1, y)
                    e.Graphics.DrawString(txtchequenumber.Text, myfont1, Brushes.Black, x2, y)
                    y = y + FontHeight0

                End If
                y = y + FontHeight0
                e.Graphics.DrawString("Αντίγραφο μαθητή/Student Copy", myfont1, Brushes.Black, x1, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Υπογραφή/Signature", myfont1, Brushes.Black, x1 + 515, y - 100)
                y = y + FontHeight0
                e.Graphics.DrawString("_________________", myfont1, Brushes.Black, x1 + 515, y - 80)
                y = y + FontHeight0
                y = y + 28
                y = y + FontHeight0
                e.Graphics.DrawLine(Pens.Black, 45, y, 800, y)
                onemonth = ""
                allmonths = Nothing
                e.Graphics.DrawImage(Image.FromFile("logo.jpg"), x1, y + 10)

                e.Graphics.DrawString("Απόδειξη/Receipt", myfont, Brushes.Black, x1, y + 80)
                y = y + FontHeight
                'branch information
                e.Graphics.DrawString(branchinforow(5), myfont1, Brushes.Black, x2 + 60, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Παράρτημα/Branch", myfont, Brushes.Black, x1, y + 30)
                e.Graphics.DrawString(branchinforow(1), myfont, Brushes.Black, x1 + 130, y + 30)
                y = y + FontHeight
                e.Graphics.DrawString("Διεύθυνση/Address", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(3), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Ιστοσελίδα/WebSite", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(4), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Αρ. Φ.Π.Α/V.A.T", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(2), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight
                e.Graphics.DrawString("Τηλέφωνο/Telephone", myfont, Brushes.Black, x2 + 60, y)
                e.Graphics.DrawString(branchinforow(6), myfont, Brushes.Black, x2 + 195, y)
                y = y + FontHeight + 20
                e.Graphics.DrawLine(Pens.Black, 45, y - 10, 800, y - 10)
                'student details
                e.Graphics.DrawString("Αρ. Απόδειξης/Receipt Number: ", myfont2, Brushes.Black, x1 + 350, y)
                e.Graphics.DrawString(txtpaymentid.Text, myfont2, Brushes.Black, x2 + 450, y)
                y = y + FontHeight0 + 15
                e.Graphics.DrawString("Έλαβα από/Recieved From ", myfont2, Brushes.Black, x1, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Επίθετο/Surname: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(studentaccrow(4), myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Όνομα/Name: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtreceivedby.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                'payment details
                e.Graphics.DrawString("Ημ. πληρωμής/Date: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtpaymentdate.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Σχ. Χρόνια/School year: ", myfont1, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtschoolyear.Text, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Μήνας/Month: ", myfont1, Brushes.Black, x1, y)
                allmonths = txtmonth.Text.Split(New Char() {", "})
                For i = 0 To allmonths.Count - 1
                    If allmonths.Count > 1 Then
                        onemonth = MonthName(CInt(allmonths(i))).Substring(0, 3) & ", " & onemonth
                    Else
                        onemonth = MonthName(CInt(allmonths(i))).Substring(0, 3)
                    End If
                Next
                e.Graphics.DrawString(onemonth, myfont1, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                onemonth = ""
                allmonths = Nothing
                For j = 0 To allmonthspaidsofar.Count - 2
                    payid = monthspaidsofar(j)
                    If allmonthspaidsofar.Count > 1 Then
                        allmonths = allmonthspaidsofar(j).Split(New Char() {", "})
                        For k = 0 To allmonths.Count - 1
                            onemonth = MonthName(CInt(allmonths(k))).Substring(0, 3) & "(" & payid & ")" & ", " & onemonth
                        Next k
                    Else
                        onemonth = MonthName(CInt(allmonths(j))).Substring(0, 3) & "(" & payid & ")"
                    End If
                Next j
                e.Graphics.DrawString("Κ.μήνες/M.Paid: ", myfont1, Brushes.Black, x1, y)
                If onemonth.Length <= 50 Then
                    e.Graphics.DrawString(onemonth, myfont1, Brushes.Black, x2 - 50, y)
                Else
                    e.Graphics.DrawString(onemonth.Substring(0, 43), myfont1, Brushes.Black, x2 - 50, y)
                    y = y + FontHeight0
                    e.Graphics.DrawString(onemonth.Substring(44), myfont1, Brushes.Black, x2 - 50, y)
                End If
                y = y + FontHeight0
                e.Graphics.DrawString("Πόσο πληρωμής/Amount €: ", myfont2, Brushes.Black, x1, y)
                e.Graphics.DrawString(txtpaymentamount.Text, myfont2, Brushes.Black, x2 + 30, y)
                y = y + FontHeight0
                y = y + FontHeight0
                y = y + FontHeight0
                'bank details
                e.Graphics.DrawString("Μέθοδος πληρωμής/Pay", myfont2, Brushes.Black, x1, y)
                y = y + FontHeight0
                If txtcheque.CheckState = CheckState.Unchecked Then
                    e.Graphics.DrawString("Μετρητά/Cash", myfont1, Brushes.Black, x1, y)
                    y = y + FontHeight0
                Else
                    e.Graphics.DrawString("Όνομα τράπεζας/Bank: ", myfont1, Brushes.Black, x1, y)
                    e.Graphics.DrawString(txtbankname.Text, myfont1, Brushes.Black, x2, y)
                    y = y + FontHeight0
                    e.Graphics.DrawString("Αρ. επι./Ch. Number: ", myfont1, Brushes.Black, x1, y)
                    e.Graphics.DrawString(txtchequenumber.Text, myfont1, Brushes.Black, x2, y)
                    y = y + FontHeight0

                End If
                y = y + FontHeight0
                e.Graphics.DrawString("Αντίγραφο Λογιστηρίου/Account Copy", myfont1, Brushes.Black, x1, y)
                y = y + FontHeight0
                e.Graphics.DrawString("Υπογραφή/Signature", myfont1, Brushes.Black, x1 + 515, y - 100)
                y = y + FontHeight0
                e.Graphics.DrawString("_________________", myfont1, Brushes.Black, x1 + 515, y - 80)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf mode.Equals(0) Then

        End If
    End Sub

    Private Sub btnprintpreviewinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintpreviewinvoice.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub txtpidsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpidsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If mode.Equals(1) Then
                Try
                    qry = "SELECT (paymentid) As 'Payment ID', (t.studentaccid) As 'Account ID', (familyname) As 'Family Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and paymentid = '" + txtpidsearch.Text + "' and t.schoolyear='" + comboschoolyear.Text + "' order by(paymentid) desc"
                    selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                    selectedpayments.AutoResizeColumns()
                    qry = "select sum(paymentamount) from tblpayment where paymentid = '" + txtpidsearch.Text + "' and schoolyear = '" + txtschoolyear.Text + "'"
                    txttotalrecieptbydate.Text = Form1.con.returnSingleValueFor(qry)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf mode.Equals(0) Then
                Try
                    qry = "SELECT (adultpaymentid) As 'Adult Payment ID', (t.adultid) As 'Adult ID', (firstname) As 'First Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tbladultpayment t, tbladult t1 where t1.adultid = t.adultid and t.adultpaymentid = '" + txtpidsearch.Text + "' and t.schoolyear='" + comboschoolyear.Text + "' order by(adultpaymentid) desc"
                    selectedpayments.DataSource = Form1.con.returnDataTableFor(qry)
                    selectedpayments.AutoResizeColumns()
                    qry = "select sum(paymentamount) from tbladultpayment where adultpaymentid = '" + txtpidsearch.Text + "' and schoolyear = '" + txtschoolyear.Text + "'"
                    txttotalrecieptbydate.Text = Form1.con.returnSingleValueFor(qry)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub txtpidsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpidsearch.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If MsgBox("Are you sure you want to delete this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "DELETE FROM `private_institute`.`tblpayment` WHERE paymentid='" + txtpaymentid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("Payment has been deleted!!!")
                Else
                    MsgBox("Payment has not been deleted!!!")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If MsgBox("Are you sure you want to update this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "UPDATE `private_institute`.`tblpayment` SET  `paymentamount` = '" + txtpaymentamount.Text + "', `paymentdate` = '" + txtpaymentdate.Text + "', `cheque` = '" + txtcheque.CheckState.ToString + "', `chequenum` = '" + txtchequenumber.Text + "', `month` = '" + txtmonth.Text + "', `monthlyfee` = '" + txtmothlyfee.Text + "', `other` = '" + txtother.Text + "', `receivedby` = '" + txtreceivedby.Text + "', `bankname` = '" + txtbankname.Text + "', `schoolyear` = '" + txtschoolyear.Text + "' WHERE paymentid='" + txtpaymentid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This payment has been updated")
                Else
                    MsgBox("This payment has not been updated")
                End If
            End If
Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmonth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonth.TextChanged

        Try
            For i = 0 To txtmonth.TextLength - 1
                If txtmonth.Text.Substring(i) = "," Then
                    countmonthpaid += 1
                End If
            Next i
            txtpaymentamount.Text = Val(txtmothlyfee.Text) * countmonthpaid
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            txtschoolyear.Text = comboschoolyear.Text
        Catch ex As Exception

        End Try
    End Sub
End Class