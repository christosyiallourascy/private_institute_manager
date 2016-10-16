Public Class frmlesson
    Private qry As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tbllesson"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))


    End Sub
    Private Sub DisplayData(ByVal tbllesson As String())
        Try
            txtlessonid.Text = tbllesson(0)
            txtclassid.SelectedValue = tbllesson(1)
            txtlessondate.Text = tbllesson(2)
            txtmaterialteached.Text = tbllesson(3)
            txtmaterialteachednext.Text = tbllesson(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddclass.Click
        txtlessonid.Text = "AutoNumber"
        txtclassid.Text = ""
        txtlessondate.Text = Date.Today
        txtmaterialteached.Clear()
        txtmaterialteachednext.Clear()
        txtclassid.Focus()
    End Sub
    Private Sub fillallclasses()
        Try
            qry = "select * from tbllesson"
            dglessons.DataSource = Form1.con.returnDataTableFor(qry)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmlesson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception

        End Try

        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception

        End Try
        Try
            qry = "select classid, concat(classname,' ', room, ' ',day1,' ', time1) as class from tblclass where year = '" + comboschoolyear.Text + "'"
            Form1.con.BindQueryTo(qry, "class", "classid", txtclassid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            qry = "select classid, concat(classname,' ', room, ' ',day1,' ', time1) as class from tblclass where year = '" + comboschoolyear.Text + "'"
            Form1.con.BindQueryTo(qry, "class", "classid", txtclassid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            qry = "insert into tbllesson (classid, lessondate, materialteached, materialtoteachnext) values ('" + txtclassid.SelectedValue.ToString + "', '" + txtlessondate.Text + "', '" + txtmaterialteached.Text + "', '" + txtmaterialteachednext.Text + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This lesson has been saved!!!")
            Else
                MsgBox("This lesson has not been saved!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtselecteddate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtselecteddate.ValueChanged
        Try
            qry = "select (classname) as 'Class Name', (day1) as 'Day One', (time1) as 'Time One', (lessondate) as 'Lesson Date', (materialteached) as 'Material Teach', (materialtoteachnext) as 'Material to teach next' from tblclass t, tbllesson t1 where t.classid = t1.classid and t.year = '" + comboschoolyear.Text + "' and lessondate = '" + txtselecteddate.Value.Date + "'"
            dglessons.DataSource = Form1.con.returnDataTableFor(qry)
            dglessons.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        Try
            qry = "update tbllesson set classid = '" + txtclassid.Text + "', lessondate='" + txtlessondate.Text + "', materialteached='" + txtmaterialteached.Text + "', materialtoteachnext='" + txtmaterialteachednext.Text + "' where lessonid ='" + txtlessonid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("The lesson has been updateed.")
            Else
                MsgBox("The lesson has not been updated.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            Call refreshData()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If MsgBox("Are you sure you want to delete this lesson?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "DELETE FROM `private_institute`.`tbllesson` WHERE lessonid='" + txtlessonid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The lesson has been deleted.")
                    qry = "DELETE FROM `private_institute`.`tblabsences` WHERE lessonid='" + txtlessonid.Text + "'"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("The absences has been deleted.")
                    Else
                        MsgBox("The absences has been deleted.")
                    End If
                Else
                    MsgBox("The lesson has not been deleted.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class