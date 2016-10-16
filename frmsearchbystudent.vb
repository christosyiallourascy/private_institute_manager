Public Class frmsearchbystudent
    Private qry As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub

    Private Sub txtcritiria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                qry = "select (t.studentaccid) as 'Student Account ID', (firstname) as 'First Name', (lastname) as 'Last Name', (t1.fathername) as 'Father Name', (mobilephone) as 'Mobile Phone', (homephone) as 'Home Phone'  from tblstudent t, tblstudentaccount t1 where lastname='" + txtcritiria.Text + "' and t.studentaccid = t1.studentaccid or firstname ='" + txtcritiria.Text + "' and t.studentaccid = t1.studentaccid"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                studentresult.DataSource = Form1.con.returnDataTableFor(qry)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub studentresult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentresult.DoubleClick
        Try
            Dim frmp As New frmpayments(sender.CurrentCell.EditedFormattedValue().ToString, 1)
            frmp.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub studentresult_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles studentresult.MouseUp

        Try
            If e.Button = MouseButtons.Right Then
                Dim frmaccstu As New frmaccountstatement(sender.CurrentCell.EditedFormattedValue().ToString)
                frmaccstu.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub studentresult_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles studentresult.CellContentClick

    End Sub

    Private Sub txtcritiria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcritiria.TextChanged

    End Sub

    Private Sub studentresult_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentresult.MouseHover
        ttinfo.SetToolTip(txtcritiria, "Double Click on Student Account Number for Receipt and Right Click for Account Statement")
    End Sub

    Private Sub frmsearchbystudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ttinfo.SetToolTip(studentresult, "Double Click on Student Account Number for Receipt and Right Click for Account Statement")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class