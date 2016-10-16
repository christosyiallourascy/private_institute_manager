Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient
Public Class frmroyalties
    Private qry As String
    Private royaltiesrate As Double

    Private elefees As Double
    Private intfees As Double
    Private higherfees As Double
    Private adultsfees As Double
    Private myid As Integer
    Private bname As String
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "SELECT * FROM `private_institute`.`tblroyalties`"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tblroyalties As String())
        Try
            txtroyaltyid.Text = tblroyalties(0)
            txtnumstudents.Text = tblroyalties(1)
            txtnumelem.Text = tblroyalties(2)
            txtnumint.Text = tblroyalties(3)
            txtnumhigher.Text = tblroyalties(4)
            txtsumelem.Text = tblroyalties(5)
            txtsumint.Text = tblroyalties(6)
            txtsumhigher.Text = tblroyalties(7)
            txtgrandtotal.Text = tblroyalties(8)
            txtmonth.Text = tblroyalties(9)
            txtschoolyear.Text = tblroyalties(10)
            txtdate.Text = tblroyalties(11)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmroyalties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
            qry = "select branch from tblbranchinfo"
            bname = Form1.con.returnSingleValueFor(qry)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            refreshData()
        Catch ex As Exception

        End Try
        gbpb.Visible = False
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Try
            qry = "select (firstname) As 'First Name', (lastname) As 'Last Name', (fathername) As 'Father Name', (t.email) As 'Email', (t3.classname) as 'Level' from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t.status= 'Active' and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "'"
            dgselectedstudents.DataSource = Form1.con.returnDataTableFor(qry)
            dgselectedstudents.AutoResizeColumns()
            'Claculate the total number of students
            qry = "select count(t.studentid) from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "'"
            txtnumstudents.Text = Form1.con.returnSingleValueFor(qry)
            'Calculate Elementary students
            qry = "select count(t.studentid) from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "' and (t3.classname='Elementary I' or t3.classname='Elementary II' or t3.classname='Elementary III')"
            txtnumelem.Text = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(classfees) from private_institute.tblclass where classname like '%Elementary%'  and year = '" + comboschoolyear.Text + "' limit 1"
            elefees = Val(Form1.con.returnSingleValueFor(qry))
            'Calculate Intermediate students
            qry = "select count(t.studentid) from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "' and (t3.classname='Intermediate I' or t3.classname='Intermediate II' or t3.classname='Intermediate III')"
            txtnumint.Text = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(classfees) from private_institute.tblclass where classname like '%Intermediate%'  and year = '" + comboschoolyear.Text + "' limit 1"
            intfees = Val(Form1.con.returnSingleValueFor(qry))
            'Calculate Higher students
            qry = "select count(t.studentid) from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "' and (t3.classname='Higher I' or t3.classname='Higher II' or t3.classname='Higher III')"
            txtnumhigher.Text = Form1.con.returnSingleValueFor(qry)
            qry = "select sum(classfees) from private_institute.tblclass where classname like '%Higher%'  and year = '" + comboschoolyear.Text + "' limit 1"
            higherfees = Val(Form1.con.returnSingleValueFor(qry))
            'get rate from database
            qry = "select sum(royaltiesrate) from private_institute.tbllevel where levelname like '%Elementary%' limit 1"
            'calculate totals
            txtsumelem.Text = ((Val(Form1.con.returnSingleValueFor(qry)) * elefees) / 100) * Val(txtnumelem.Text)
            qry = "select sum(royaltiesrate) from private_institute.tbllevel where levelname like '%Intermediate%' limit 1"
            txtsumint.Text = ((Val(Form1.con.returnSingleValueFor(qry)) * intfees) / 100) * Val(txtnumint.Text)
            qry = "select sum(royaltiesrate) from private_institute.tbllevel where levelname like '%Higher%' limit 1"
            txtsumhigher.Text = ((Val(Form1.con.returnSingleValueFor(qry)) * higherfees) / 100) * Val(txtnumhigher.Text)
            txtgrandtotal.Text = Val(txtsumelem.Text) + Val(txtsumint.Text) + Val(txtsumhigher.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            txtroyaltyid.Text = "Auto Number"
            txtgrandtotal.Text = ""
            txtmonth.Text = Month(Today.Date)
            txtschoolyear.Text = comboschoolyear.Text
            txtdate.Text = Today.Date
            txtsumelem.Text = ""
            txtsumhigher.Text = ""
            txtsumint.Text = ""
            txtnumelem.Text = ""
            txtnumstudents.Text = ""
            txtnumhigher.Text = ""
            txtnumint.Text = ""
            btncalculate.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this?", MsgBoxStyle.YesNo, "By Private Iinstitute") = MsgBoxResult.Yes Then
            Try
                qry = "INSERT INTO `private_institute`.`tblroyalties` (`numofstudents`, `numofelem`, `numofint`, `numofhigher`, `sumofelem`, `sumofint`, `sumofhigher`, `grandtotal`, `month`, `schoolyear`, `date`) VALUES('" + txtnumstudents.Text + "', '" + txtnumelem.Text + "', '" + txtnumint.Text + "', '" + txtnumhigher.Text + "', '" + txtsumelem.Text + "', '" + txtsumint.Text + "', '" + txtsumhigher.Text + "', '" + txtgrandtotal.Text + "', '" + txtmonth.Text + "', '" + txtschoolyear.Text + "', '" + txtdate.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The royalty has been saved.")
                Else
                    MsgBox("The royalty has not been saved.")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
            'Call fillStudents()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
            'Call fillStudents()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fillStudents()
        Try
            qry = "select (firstname) As 'First Name', (lastname) As 'Last Name', (fathername) As 'Father Name', (t1.homephone) As 'Home Phone', (t.mobilephone) As 'Mobile Phone', (t3.classname) as 'Level' from private_institute.tblstudent t, private_institute.tblstudentaccount t1, private_institute.tblstudentclass t2, private_institute.tblclass t3 where t.studentaccID = t1.studentaccID and t.studentid = t2.studentid and t2.classid = t3.classid and t3.year='" + comboschoolyear.Text + "'"
            dgselectedstudents.DataSource = Form1.con.returnDataTableFor(qry)
            dgselectedstudents.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete this?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM `private_institute`.`tblroyalties` WHERE royaltyid='" + txtroyaltyid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The royalty has been deleted.")
                Else
                    MsgBox("The royalty has not been deleted.")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If MsgBox("Are you sure you want to update this?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "UPDATE `private_institute`.`tblroyalties` SET `numofstudents` = '" + txtnumstudents.Text + "', `numofelem` = '" + txtnumelem.Text + "', `numofint` = '" + txtnumint.Text + "', `numofhigher` = '" + txtnumhigher.Text + "', `sumofelem` = '" + txtsumelem.Text + "', `sumofint` = '" + txtsumint.Text + "', `sumofhigher` = '" + txtsumhigher.Text + "', `grandtotal` = '" + txtgrandtotal.Text + "', `month` = '" + txtmonth.Text + "', `schoolyear` = '" + txtschoolyear.Text + "', `date` = '" + txtdate.Text + "' WHERE royaltyid='" + txtroyaltyid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The royalty has been updated.")
                Else
                    MsgBox("The royalty has not been updated.")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnect.Click
        Dim myConnectionString As String
        Dim username As String
        Dim password As String
        Try
            username = InputBox("Enter Username")
            password = InputBox("Enter Password")
            myConnectionString = "server=localhost;" _
        & "user=" + username + ";" _
        & "password=" + password + ";" _
        & "database=private_institute_central;charset=utf8;"
            conn.ConnectionString = myConnectionString
            conn.Open()
            qry = "SELECT sum(`tblbranch`.`branchid`) FROM `private_institute_central`.`tblbranch` where `tblbranch`.`branchname` = '" + bname + "'"
            myCommand.Connection = conn
            myCommand.CommandText = qry
            myid = CInt(myCommand.ExecuteScalar())
            MsgBox("You are connected!!!")
            btnsendresults.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("You are not connected!!!")
        End Try
    End Sub

    Private Sub btnsendresults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsendresults.Click
        gbpb.Visible = True
        Dim countonlinerows As Integer = 0
        Try
            'store students that do not exist in the online database 
            'updata student level where is necessary
            lbldetails.ForeColor = Color.Green
            countonlinerows = dgselectedstudents.Rows.Count
            countonlinerows = pb.Maximum / countonlinerows
            MsgBox(countonlinerows)
            lbldetails.Text = "Processing..."
            For Each row As DataGridViewRow In dgselectedstudents.Rows
                qry = "select count(bstudentid) from `private_institute_central`.`tblbranchstudent` WHERE branchid = '" + myid.ToString + "' and firstname = '" + CStr(row.Cells(0).FormattedValue).ToString + "' and lastname = '" + CStr(row.Cells(1).FormattedValue).ToString + "' and fathername = '" + CStr(row.Cells(2).FormattedValue).ToString + "'"
                myCommand.Connection = conn
                myCommand.CommandText = qry
                If myCommand.ExecuteScalar() > 0 Then
                    qry = "UPDATE `private_institute_central`.`tblbranchstudent` SET `levelnow` = '" + CStr(row.Cells(5).FormattedValue) + "', `active` = 'Yes' WHERE branchid = '" + myid.ToString + "' and firstname = '" + CStr(row.Cells(0).FormattedValue).ToString + "' and lastname = '" + CStr(row.Cells(1).FormattedValue).ToString + "' and fathername = '" + CStr(row.Cells(2).FormattedValue).ToString + "' and active = 'Yes'"
                    myCommand.Connection = conn
                    myCommand.CommandText = qry
                    myCommand.ExecuteNonQuery()
                    lbldetails.Text = "Updating Students..."

                Else
                    qry = "INSERT INTO `private_institute_central`.`tblbranchstudent` (`branchid`, `firstname`, `lastname`, `fathername`, `levelnow`, `email`, `active`) VALUES('" + myid.ToString + "', '" + CStr(row.Cells(0).FormattedValue).ToString + "', '" + CStr(row.Cells(1).FormattedValue).ToString + "','" + CStr(row.Cells(2).FormattedValue).ToString + "', '" + CStr(row.Cells(4).FormattedValue).ToString + "','" + CStr(row.Cells(3).FormattedValue).ToString + "', 'Yes')"
                    myCommand.Connection = conn
                    myCommand.CommandText = qry
                    myCommand.ExecuteNonQuery()
                    lbldetails.Text = "Insetring new Students..."

                End If
                qry = "select count(bstudentid) from `private_institute_central`.`tblbranchstudent` WHERE branchid = '" + myid.ToString + "' and firstname = '" + CStr(row.Cells(0).FormattedValue).ToString + "' and lastname = '" + CStr(row.Cells(1).FormattedValue).ToString + "' and fathername = '" + CStr(row.Cells(2).FormattedValue).ToString + "' and active= 'No'"
                myCommand.Connection = conn
                myCommand.CommandText = qry
                If myCommand.ExecuteScalar() > 0 Then
                    qry = "UPDATE `private_institute_central`.`tblbranchstudent` SET `levelnow` = '" + CStr(row.Cells(5).FormattedValue) + "', `active` = 'Yes' WHERE branchid = '" + myid.ToString + "' and firstname = '" + CStr(row.Cells(0).FormattedValue).ToString + "' and lastname = '" + CStr(row.Cells(1).FormattedValue).ToString + "' and fathername = '" + CStr(row.Cells(2).FormattedValue).ToString + "' and active = 'Yes'"
                    myCommand.Connection = conn
                    myCommand.CommandText = qry
                    myCommand.ExecuteNonQuery()
                    lbldetails.Text = "Updating Students..."
                End If
                pb.Value = pb.Value + countonlinerows
            Next row
            pb.Value = pb.Maximum
            lbldetails.Text = "The process has been finished"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnprintstatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintstatement.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Courier New", 12, FontStyle.Regular)
        Dim myfont1 As New Font("Courier New", 14, FontStyle.Bold)
        Dim myfont2 As New Font("Courier New", 12, FontStyle.Bold)
        FontHeight = myfont.GetHeight(e.Graphics) + 5
        Dim x, y As Integer
        Dim rrow As String() = Nothing
        Dim bname As String() = Nothing
        x = 50
        y = 50
        e.Graphics.DrawImage(Image.FromFile("logo.jpg"), x, y)
        y = y + 70
        e.Graphics.DrawString("CYBERNET COMPUTER TRAINING CENTERS", myfont1, Brushes.Black, x, y)
        y = y + FontHeight
        y = y + FontHeight
        Try
            qry = "select branch from private_institute.tblbranchinfo limit 1"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            bname = Form1.con.nextRow()
            bname = Form1.con.previousRow()
            qry = "select * from tblroyalties where royaltyid='" + txtroyaltyid.Text + "'"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            rrow = Form1.con.nextRow()
            rrow = Form1.con.previousRow()

            e.Graphics.DrawString("CYBERNET " & bname(0), myfont, Brushes.Black, x, y)
            y = y + FontHeight
            e.Graphics.DrawString("Royalties Report for the month " & MonthName(rrow(9)), myfont, Brushes.Black, x, y)
            y = y + FontHeight

            e.Graphics.DrawString("Royalty ID", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(0), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Sudents", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(1), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Elementary", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(2), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Intermediate", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(3), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Higher", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(4), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Elementary", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(5) & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Intermediate", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(6) & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Higher", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(7) & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Grand Total", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(8) & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("School Year", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(10), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Date", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(rrow(11), myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
        Catch ex As Exception

        End Try
    End Sub
End Class