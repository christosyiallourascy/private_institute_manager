Public Class frmsearchforaccount
    Private qry As String

    Private Sub DisplayData(ByVal tblstudentaccount As String())

        Try
            txtstudentaccountnumber.Text = tblstudentaccount(0)
            txtfathername.Text = tblstudentaccount(1)
            txtmothername.Text = tblstudentaccount(2)
            txtdiscount.Text = tblstudentaccount(3)
            txthomephone.Text = tblstudentaccount(4)
            txtworkphone.Text = tblstudentaccount(5)
            txtmobilefather.Text = tblstudentaccount(6)
            txtmobilemother.Text = tblstudentaccount(7)
            txtfamilyname.Text = tblstudentaccount(8)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtusertype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusertype.KeyDown
        Dim count As Integer
        If e.KeyCode = Keys.Enter Then
            Try
                qry = "select  studentaccID, fathername, mothername, discount, homephone, workphone, mobilefather, mobilemother, familyname from tblstudentaccount where homephone='" + txtusertype.Text + "'"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                DisplayData(Form1.con.nextRow())
                DisplayData(Form1.con.previousRow())
            Catch ex As Exception

            End Try
            Try
                qry = "select count(homephone) from tblstudentaccount where homephone='" + txtusertype.Text + "'"
                count = Form1.con.returnSingleValueFor(qry)
                If count <= 0 Then
                    MsgBox("There is no account with this home phone number!!!")
                    btnaddstudent.Enabled = False
                    btnprintaccstatement.Enabled = False
                    btnpayment.Enabled = False
                Else
                    btnaddstudent.Enabled = True
                    btnprintaccstatement.Enabled = True
                    btnpayment.Enabled = True

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtusertype_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusertype.TextChanged

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnaddstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstudent.Click
        Dim frmst As New frmstudent(txtstudentaccountnumber.Text)
        frmst.Show()
        frmst.ClearFields()
    End Sub

    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        Dim frmpay As New frmpayments(txtstudentaccountnumber.Text, 1)
        frmpay.Show()
    End Sub

    Private Sub btnprintaccstatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintaccstatement.Click
        Dim frmaccst As New frmaccountstatement(txtstudentaccountnumber.Text)
        frmaccst.Show()
    End Sub

    Private Sub frmsearchforaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtstudentaccountnumber.Text = "" Then
            btnaddstudent.Enabled = False
            btnprintaccstatement.Enabled = False
            btnpayment.Enabled = False
        Else
            btnaddstudent.Enabled = True
            btnprintaccstatement.Enabled = True
            btnpayment.Enabled = True
        End If
    End Sub
End Class