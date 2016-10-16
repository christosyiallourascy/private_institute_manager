Public Class frmadults

    Private qry As String

    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tbladult"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub

    Private Sub DisplayData(ByVal tblstudent As String())

        Try
            txtadultid.Text = tblstudent(0)
            txttitle.Text = tblstudent(1)
            txtfirstname.Text = tblstudent(2)
            txtlastname.Text = tblstudent(3)
            txtsex.Text = tblstudent(4)
            txtmiddlename.Text = tblstudent(5)
            txtmobilephone.Text = tblstudent(6)
            txthomephone.Text = tblstudent(7)
            txtaddress.Text = tblstudent(8)
            txtcity.Text = tblstudent(9)
            txtcountry.Text = tblstudent(10)
            txtbirthdate.Text = tblstudent(11)
            txtnationality.Text = tblstudent(12)
            txtemail.Text = tblstudent(13)
            txtage.Text = tblstudent(14)
            txtstatus.Text = tblstudent(15)
            txtdateissued.Value = tblstudent(16)
            txtidnumber.Text = tblstudent(17)
            txtusername.Text = tblstudent(18)
            txtpassword.Text = tblstudent(19)
            txtidexams.Text = tblstudent(20)
            txtentereddate.Value = tblstudent(21)
            txtdiscount.Text = tblstudent(22)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshData()
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
            loadadultClass()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this adult?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "INSERT INTO `private_institute`.`tbladult` (`title`, `firstname`, `lastname`, `middlename`, `sex`, `homephone`, `mobilephone`, `address`, `city`, `country`, `nationality`, `email`, `age`, `birthdate`, `status`, `dateissued`, `idexams`, `idnumber`,`username`, `password`, `entereddate`, `discount`) VALUES('" + txttitle.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtmiddlename.Text + "', '" + txtsex.Text + "', '" + txthomephone.Text + "', '" + txtmobilephone.Text + "', '" + txtaddress.Text + "', '" + txtcity.Text + "', '" + txtcountry.Text + "', '" + txtnationality.Text + "', '" + txtemail.Text + "', '" + txtbirthdate.Text + "', '" + txtage.Text + "','" + txtstatus.Text + "', '" + txtdateissued.Value.Date + "', '" + txtidexams.Text + "', '" + txtidnumber.Text + "', '" + txtusername.Text + "', '" + txtpassword.Text + "', '" + txtentereddate.Value.Date + "', '" + txtdiscount.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This adult has been saved")
                Else
                    MsgBox("This adult has not been saved!!!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
            loadadultClass()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmadults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
            loadadultClass()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnaddstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstudent.Click
        Try
            txtadultid.Text = "AutoNumber"
            txttitle.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtsex.Text = ""
            txtmiddlename.Text = ""
            txtmobilephone.Text = ""
            txthomephone.Text = ""
            txtbirthdate.Text = ""
            txtnationality.Text = ""
            txtemail.Text = ""
            txtage.Text = ""
            txtstatus.Text = ""
            txtdateissued.Value = Today.Date
            txtidnumber.Text = ""
            txtusername.Text = ""
            txtpassword.Text = ""
            txtidexams.Text = ""
            txtentereddate.Value = Today.Date
            txtaddress.Text = ""
            txtcity.Text = "Limassol"
            txtcountry.Text = "Cyprus"
            txtdiscount.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Private Sub loadadultClass()
        Try
            qry = "SELECT (classname) as 'Class Name', (year) as 'School Year', (day1) as 'Day One', (time1) as 'Time One A', (time1a) as 'Time Two A', (day2) as 'Day Two', (time2) as 'Time One B', (time2a) as 'Time Two B'  FROM tblclass t, tbladultclass t1  where t1.adultid='" + txtadultid.Text + "' and t.classid = t1.classid"
            studentclasses.DataSource = Form1.con.returnDataTableFor(qry)
            studentclasses.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtcritiria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        Dim count As Integer
        If e.KeyCode = Keys.Enter Then
            Try
                qry = "select count(lastname) from tbladult where lastname='" + txtcritiria.Text + "'"
                count = Form1.con.returnSingleValueFor(qry)
                If count <= 0 Then
                    MsgBox("There is no adult with this last name!!!")
                Else
                    qry = "select adultid, CONCAT(firstname,' ', lastname,' ', middlename) as fullname from tbladult where lastname ='" + txtcritiria.Text + "'"
                    Form1.con.BindQueryTo(qry, "fullname", "adultid", cmbfilteredadults)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

    End Sub

    Private Sub btnaddpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddpayment.Click
        Dim addpayment As New frmpayments(cmbfilteredadults.SelectedValue.ToString, 0)
        addpayment.Show()
    End Sub
End Class