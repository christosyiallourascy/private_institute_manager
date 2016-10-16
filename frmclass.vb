Public Class frmclass

    Private qry As String

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnbindstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbindstudent.Click
        Dim ep As New frmbindstudenttoclass(txtclassid.Text)
        ep.Show()
    End Sub

    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddclass.Click
        Try
            txtclassid.Text = "Auto Number"
            txtclassfees.Clear()
            txtclassname.Text = ""
            txtday1.Text = ""
            txtday2.Text = ""
            txtinstructorid.Text = ""
            txtlocation.Clear()
            txtmax.Clear()
            txtroom.Clear()
            txttime1.Clear()
            txttime1a.Clear()
            txttime2.Clear()
            txttime2a.Clear()
            txtunits.Clear()
            txtyear.Clear()
            vatyesno.Text = "No"
            txtclassdiscount.Text = "0"
            closedyesno.Text = "No"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()
        Try
            qry = "select instructorid, concat(firstname,' ', lastname) as fullname from tblinstructor"
            Form1.con.BindQueryTo(qry, "fullname", "instructorid", txtinstructorid)
        Catch ex As Exception

        End Try
        Try
            qry = "select levelname from tbllevel"
            Form1.con.BindQueryTo(qry, "levelname", "levelname", txtclassname)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                If MsgBox("Are you sure you want to delete this class?", MsgBoxStyle.YesNo, "Institute Manager") = MsgBoxResult.Yes Then
                    qry = "delete from tblclass where classid ='" + txtclassid.Text + "'"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("Class has been deleted!!!")
                    Else
                        MsgBox("Class has not been deleted!!!")
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub refreshData()
        qry = "select count(classid) from private_institute.tblclass"
        lblnumofrecords.Text = "Number Of Records: " & Form1.con.returnSingleValueFor(qry)
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblclass"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
        fillallclasses()

    End Sub
    Private Sub DisplayData(ByVal tblclass As String())
        Try
            txtclassid.Text = tblclass(0)
            txtclassname.Text = tblclass(1)
            txtinstructorid.SelectedValue = tblclass(2)
            txtunits.Text = tblclass(3)
            txtyear.Text = tblclass(4)
            txtlocation.Text = tblclass(5)
            txtroom.Text = tblclass(6)
            txtday1.Text = tblclass(7)
            txttime1.Text = tblclass(8)
            txttime1a.Text = tblclass(9)
            txtday2.Text = tblclass(10)
            txttime2.Text = tblclass(11)
            txttime2a.Text = tblclass(12)
            txtmax.Text = tblclass(13)
            txtclassfees.Text = tblclass(14)
            vatyesno.Text = tblclass(15)
            txtclassdiscount.Text = tblclass(16)
            closedyesno.Text = tblclass(17)
        Catch ex As Exception

        End Try
        Try
            qry = "select count(t1.studentid) from tblstudentclass t, tblstudent t1 where classid ='" + txtclassid.Text + "' and t1.studentid = t.studentid"
            If Form1.con.returnSingleValueFor(qry) > 0 Then
                qry = "select (t1.studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name',  (mobilephone) AS 'Mobile Phone' from tblstudentclass t, tblstudent t1 where classid ='" + txtclassid.Text + "' and t1.studentid = t.studentid"
                studentgrid.DataSource = Form1.con.returnDataTableFor(qry)
                studentgrid.AutoResizeColumns()
            Else
                qry = "select (t1.adultid) as 'Adult ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tbladultclass t, tbladult t1 where classid ='" + txtclassid.Text + "' and t1.adultid = t.adultid"
                studentgrid.DataSource = Form1.con.returnDataTableFor(qry)
                studentgrid.AutoResizeColumns()
            End If
        Catch ex As Exception

        End Try
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Dim instrid As Integer
            instrid = txtinstructorid.SelectedValue

            Try
                qry = "insert into tblclass (classname, instructorid, units, year, location, room, day1, time1, time1a, day2, time2, time2a, max, classfees, vatyesno, classdiscount, closed) values ('" + txtclassname.Text + "', '" + txtinstructorid.SelectedValue.ToString + "', '" + txtunits.Text + "', '" + txtyear.Text + "', '" + txtlocation.Text + "', '" + txtroom.Text + "', '" + txtday1.Text + "', '" + txttime1.Text + "', '" + txttime1a.Text + "', '" + txtday2.Text + "', '" + txttime2.Text + "', '" + txttime2a.Text + "', '" + txtmax.Text + "', '" + txtclassfees.Text + "',  '" + vatyesno.Text + "',  '" + txtclassdiscount.Text + "', '" + closedyesno.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This class has been saved!!!")
                Else
                    MsgBox("This class has not been saved!!!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub fillallclasses()
        Try
            qry = "select (classname) as 'Class Name', (room) as Room, (day1) as 'Day One', (time1) as 'Time One A', (time1a) as 'Time Two A', (day2) as 'Day Two', (time2) as 'Time One B', (time2a) as 'Time Two B' from tblclass"
            allclasses.DataSource = Form1.con.returnDataTableFor(qry)
            allclasses.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        If MsgBox("Are you sure you want to update this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "UPDATE private_institute.tblclass SET classname = '" + txtclassname.Text + "', instructorid = '" + txtinstructorid.SelectedValue.ToString + "', units = '" + txtunits.Text + "', year = '" + txtyear.Text + "', location = '" + txtlocation.Text + "', room = '" + txtroom.Text + "', day1 = '" + txtday1.Text + "', time1 = '" + txttime1.Text + "', time1a = '" + txttime1a.Text + "', day2 = '" + txtday2.Text + "', time2 = '" + txttime2.Text + "', time2a = '" + txttime2a.Text + "', max = '" + txtmax.Text + "', classfees = '" + txtclassfees.Text + "', vatyesno = '" + vatyesno.Text + "', classdiscount = '" + txtclassdiscount.Text + "',  closed = '" + closedyesno.Text + "' WHERE classid = '" + txtclassid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This class has been updated")
                Else
                    MsgBox("This class has not been updated")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class