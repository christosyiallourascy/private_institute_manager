Public Class frmlessonplan
    Private qry As String
    Private Sub frmlessonplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtlessonid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlessonid.SelectedIndexChanged
        Dim cid As String = Nothing
        Dim id As String() = Nothing

        Try
            cid = txtlessonid.Text
            id = cid.Split(New Char() {" "c})
            qry = "select * from tbllesson where lessonid='" + txtlessonid.SelectedValue.ToString + "'"
            BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
            BindingNavigator1.BindingSource = BindingSource1
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            Call displaydata(Form1.con.nextRow())
            qry = "select (t1.studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (lessonid) as 'Lesson ID', (absent) as 'Present' from `private_institute`.`tblabsences` t1, `private_institute`.`tblstudent` t2 where lessonid = '" + txtlessonid.SelectedValue.ToString + "' and t1.studentid = t2.studentid"
            dgabsences.DataSource = Form1.con.returnDataTableFor(qry)

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub displaydata(ByVal plan As String())
        txtlid.Text = plan(0)
        txtclassid.Text = plan(1)
        txtlessondate.Text = plan(2)
        txtmteached.Text = plan(3)
        txtmnext.Text = plan(4)
    End Sub

    Private Sub selecteddate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selecteddate.ValueChanged
        Try
            qry = "select lessonid, lessondate, t.classid, concat(t.classid,' ', classname,' ', room, ' ',day1,' ', time1,' ', lessondate) as class from private_institute.tblclass t, private_institute.tbllesson t1 where t1.lessondate='" + selecteddate.Value.Date + "' and t.classid = t1.classid"
            Form1.con.BindQueryTo(qry, "class", "lessonid", txtlessonid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class