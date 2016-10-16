Public Class frmevents
    Private qry As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            qry = "insert into tblevents (eventname, eventdate, description) values ('" + txteventname.Text + "', '" + txteventdate.Value.Date + "', '" + txtdiscription.Text + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This event has been saved!!!")
            Else
                MsgBox("This event has not been saved!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmevents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()
        Try
            qry = "select eventid, concat(eventname, ' ', eventdate) as event from tblevents"
            Form1.con.BindQueryTo(qry, "event", "eventid", txtselectevent)
        Catch ex As Exception

        End Try
        Try
            qry = "select studentid, CONCAT(firstname,' ', lastname,' ', fathername) AS fullname from tblstudent t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid  group by(studentid) asc"
            Form1.con.BindQueryTo(qry, "fullname", "studentid", cmbstudentid)
        Catch ex As Exception

        End Try
        Try
            qry = "select eventid, concat(eventname, ' ', eventdate) as event from tblevents"
            Form1.con.BindQueryTo(qry, "event", "eventid", cmbeventid)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblevents"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tblevents As String())
        Try
            txteventid.Text = tblevents(0)
            txteventname.Text = tblevents(1)
            txteventdate.Value = tblevents(2)
            txtdiscription.Text = tblevents(3)
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DisplayData(Form1.con.nextRow())
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DisplayData(Form1.con.previousRow())
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            qry = "insert into tblstudentevents (studentid, eventid) values('" + cmbstudentid.SelectedValue.ToString + "', '" + cmbeventid.SelectedValue.ToString + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This student has been added to this event!!!")
            Else
                MsgBox("This student has not been added to this event!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            qry = "delete from tblstudentevents where studentid='" + cmbstudentid.SelectedValue.ToString + "' and eventid='" + cmbeventid.SelectedValue.ToString + "' where studentid='" + cmbstudentid.SelectedValue.ToString + ", and eventid='" + cmbeventid.SelectedValue.ToString + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This student has been deleted to this event!!!")
            Else
                MsgBox("This student has not been deleted to this event!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            qry = "update tblstudentevents set studentid='" + cmbstudentid.SelectedValue.ToString + "', eventid='" + cmbeventid.SelectedValue.ToString + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This student has been updated to this event!!!")
            Else
                MsgBox("This student has not been updated to this event!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            qry = "update tblevents set eventname='" + txteventname.Text + "', eventdate='" + txteventdate.Text + "', description='" + txtdiscription.Text + "' where eventid='" + txteventid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This student has been updated to this event!!!")
            Else
                MsgBox("This student has not been updated to this event!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            qry = "delete from tblevents where eventid='" + txteventid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This student has been deleted to this event!!!")
            Else
                MsgBox("This student has not been deleted to this event!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnew.Click
        Try
            txteventid.Text = "Auto Number"
            txteventname.Text = ""
            txteventdate.Text = Today.Date
            txtdiscription.Text = ""
        Catch ex As Exception

        End Try
    End Sub
End Class