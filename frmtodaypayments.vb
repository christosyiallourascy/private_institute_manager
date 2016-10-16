Public Class frmtodaypayments
    Private qry As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmtodaypayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "SELECT (paymentid) As 'Payment ID', (t.studentaccid) As 'Student Account ID', (familyname) As 'Family Name', (paymentamount) As 'Payment Amount', (monthlyfee) As 'Monthly Fee', (receivedby) As 'Received By', (paymentdate) As 'Payment Date', (month) As Month FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.paymentdate='" + Today.Date + "'"
            dgtodaypayments.DataSource = Form1.con.returnDataTableFor(qry)
            dgtodaypayments.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            qry = "SELECT sum(paymentamount) FROM tblpayment t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.paymentdate='" + Today.Date + "'"
            txttotalreceived.Text = Form1.con.returnSingleValueFor(qry)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class