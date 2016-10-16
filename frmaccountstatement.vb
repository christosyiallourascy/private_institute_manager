Public Class frmaccountstatement
    Private studentaccountid As Integer
    Private qry As String
    Private accdiscount As Integer

    Public Sub New(ByVal staccid As String)
        Me.studentaccountid = staccid
        InitializeComponent()
        txtstudentaccid.Text = studentaccountid
        qry = "SELECT (paymentid) as 'Payment ID', (t.studentaccid) as 'Student Account ID', (familyname) as 'Family Name', (paymentamount) as 'Payment Amount', (monthlyfee) as 'Monthly Fee', (receivedby) as 'Received By', (paymentdate) as 'Payment Date', (month) as Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.studentaccid = '" + txtstudentaccid.Text + "' and t.schoolyear='" + comboschoolyear.Text + "'"
        accountpayments.DataSource = Form1.con.returnDataTableFor(qry)
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmaccountstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception

        End Try
        Try
            qry = "select fathername, mothername, familyname from tblstudentaccount where studentaccid ='" + txtstudentaccid.Text + "'"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            accountDetails(Form1.con.nextRow())
        Catch ex As Exception

        End Try
        Try
            qry = "select discount from tblstudentaccount where studentaccid = '" + txtstudentaccid.Text + "'"
            accdiscount = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(paymentamount) from tblpayment where studentaccid='" + txtstudentaccid.Text + "' and schoolyear='" + comboschoolyear.Text + "'"
            txttotalpaid.Text = Form1.con.returnSingleValueFor(qry) & " €"
            qry = "select sum(t3.classfees) from tblstudent t1, tblstudentclass t2, tblclass t3 where t1.studentaccid = '" + txtstudentaccid.Text + "'  and t1.status = 'Active' and t2.studentid = t1.studentid and t2.classid = t3.classid and t3.year = '" + comboschoolyear.Text + "'"
            txtmonthlyfees.Text = Form1.con.returnSingleValueFor(qry)
            txtmonthlyfees.Text = (Val(txtmonthlyfees.Text) - ((Val(txtmonthlyfees.Text) * accdiscount) / 100)) & " €"
            qry = "SELECT (studentaccid) As 'Student Account ID', (studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name' FROM `private_institute`.`tblstudent` where studentaccID='" + txtstudentaccid.Text + "'"
            students.DataSource = Form1.con.returnDataTableFor(qry)
            If comboschoolyear.Text.Length < 14 Then
                txtbalance.Text = ((Val(txtmonthlyfees.Text) * 10) - Val(txttotalpaid.Text)) & " €"
            Else
                txtbalance.Text = ((Val(txtmonthlyfees.Text) * 1) - Val(txttotalpaid.Text)) & " €"
            End If
        Catch ex As Exception

        End Try

        lbltitle.Text = txtfamilyname.Text & "'s " & lbltitle.Text
    End Sub
    Private Sub accountDetails(ByVal accdetails As String())
        Try
            txtfathersname.Text = accdetails(0)
            txtmothersname.Text = accdetails(1)
            txtfamilyname.Text = accdetails(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            qry = "select fathername, mothername, familyname from tblstudentaccount where studentaccid ='" + txtstudentaccid.Text + "'"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            accountDetails(Form1.con.nextRow())
            qry = "SELECT (paymentid) as 'Payment ID', (t.studentaccid) as 'Student Account ID', (familyname) as 'Family Name', (paymentamount) as 'Payment Amount', (monthlyfee) as 'Monthly Fee', (receivedby) as 'Received By', (paymentdate) as 'Payment Date', (month) as Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.studentaccid = '" + txtstudentaccid.Text + "' and t.schoolyear='" + comboschoolyear.Text + "'"
            accountpayments.DataSource = Form1.con.returnDataTableFor(qry)
            accountpayments.AutoResizeColumns()
        Catch ex As Exception

        End Try
        Try
            qry = "select sum(paymentamount) from tblpayment where studentaccid='" + txtstudentaccid.Text + "' and schoolyear='" + comboschoolyear.Text + "'"
            txttotalpaid.Text = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(t3.classfees) from tblstudent t1, tblstudentclass t2, tblclass t3 where t1.studentaccid = '" + txtstudentaccid.Text + "'  and t1.status = 'Active' and t2.studentid = t1.studentid and t2.classid = t3.classid and t3.year = '" + comboschoolyear.Text + "'"
            txtmonthlyfees.Text = Form1.con.returnSingleValueFor(qry)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim accs As New private_institute_reports.frmaccountsatement(Val(txtstudentaccid.Text), comboschoolyear.Text)
        accs.Show()
    End Sub
End Class