Public Class frmstudentandclasses
    Private qry As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub frmstudentandclasses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception

        End Try
        fillclassescombo()
    End Sub
    Private Sub fillclassescombo()
        Try
            qry = "select classid, CONCAT(classname,' ', day1,' ', time1) AS displayclass from tblclass where year ='" + comboschoolyear.Text + "'"
            Form1.con.BindQueryTo(qry, "displayclass", "classid", cmbclasses)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbclasses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclasses.SelectedIndexChanged
        Try
            qry = "select classid, t1.studentid, firstname, lastname from tblstudentclass t, tblstudent t1 where classid ='" + cmbclasses.SelectedValue.ToString + "' and t1.studentid = t.studentid"
            studentsandclasses.DataSource = Form1.con.returnDataTableFor(qry)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            fillclassescombo()
        Catch ex As Exception

        End Try
    End Sub
End Class