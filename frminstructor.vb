Public Class frminstructor

    Dim qry As String

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frminstructor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception
            'MsgBox("Connect with database")
        End Try
    End Sub
    Private Sub refreshData()
        qry = "select count(instructorid) from private_institute.tblinstructor"
        lblnumofrecords.Text = "Number Of Records: " & Form1.con.returnSingleValueFor(qry)
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblinstructor"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
        fillclasses()
    End Sub
    Private Sub fillclasses()
        Try
            qry = "select (classname) as 'Class Name', (room) as Room, (day1) as 'Day One', (time1) as 'Time One A', (time1a) as 'Time Two A', (day2) as 'Day Two', (time2) as 'Time One B', (time2a) as 'Time Two B' from tblclass t, tblinstructor t1 where t.instructorid = t1.instructorid and t.instructorid = '" + txtinstructorid.Text + "'"
            instructorclass.DataSource = Form1.con.returnDataTableFor(qry)
            instructorclass.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DisplayData(ByVal tblinstructor As String())
        Try
            txtinstructorid.Text = tblinstructor(0)
            txtfirstname.Text = tblinstructor(1)
            txtlastname.Text = tblinstructor(2)
            txtphonenumber.Text = tblinstructor(3)
            txtmobilenumber.Text = tblinstructor(4)
            txtfax.Text = tblinstructor(5)
            txtaddress.Text = tblinstructor(6)
            txtcity.Text = tblinstructor(7)
            txtpostalcode.Text = tblinstructor(8)
            txtbirthdate.Text = tblinstructor(9)
            txtsalary.Text = tblinstructor(10)
            txtsinumber.Text = tblinstructor(11)
            txtidnumber.Text = tblinstructor(12)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
            fillclasses()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
            fillclasses()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btninstructorlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        Dim count As Integer
        If e.KeyCode = Keys.Enter Then
          
            Try
                qry = "select count(instructorid) from tblinstructor where lastname='" + txtcritiria.Text + "'"
                count = CInt(Form1.con.returnSingleValueFor(qry))
                If count <= 0 Then
                    MsgBox("There is no instructor with this last name!!!")
                Else
                    Try
                        qry = "select * from tblinstructor where lastname='" + txtcritiria.Text + "'"
                        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                        DisplayData(Form1.con.nextRow())
                        DisplayData(Form1.con.previousRow())
                        fillclasses()
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcritiria.TextChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this record?", MsgBoxStyle.YesNoCancel, "By Manager") = MsgBoxResult.Yes Then
            Try
                qry = "insert into tblinstructor (Firstname, Lastname, PhoneNumber, MobilePhone, Fax, Address, City, PostalCode, Birthdate, Salary, SINumber, IDNumber) values ('" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtphonenumber.Text + "', '" + txtmobilenumber.Text + "', '" + txtfax.Text + "', '" + txtaddress.Text + "', '" + txtcity.Text + "', '" + txtpostalcode.Text + "', '" + txtbirthdate.Text + "', '" + txtsalary.Text + "', '" + txtsinumber.Text + "', '" + txtidnumber.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This instructor has been saved!!!")
                Else
                    MsgBox("This instructor has not been saved!!!")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshData()
    End Sub

    Private Sub btnaddinstructor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddinstructor.Click
        txtinstructorid.Text = "Auto Number"
        txtfirstname.Clear()
        txtlastname.Clear()
        txtphonenumber.Clear()
        txtmobilenumber.Clear()
        txtaddress.Clear()
        txtcity.Text = "Limassol"
        txtbirthdate.Clear()
        txtfax.Clear()
        txtsinumber.Clear()
        txtpostalcode.Clear()
        txtsalary.Clear()
        txtidnumber.Clear()
        txtfirstname.Focus()
    End Sub

    Private Sub btnupdateinstructor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateinstructor.Click
        If MsgBox("Are you sure you want to update the current record?", vbYesNoCancel, "By Manager") = MsgBoxResult.Yes Then
            Try
                qry = "update tblinstructor set FirstName='" + txtfirstname.Text + "', LastName='" + txtlastname.Text + "', PhoneNumber='" + txtphonenumber.Text + "', MobilePhone='" + txtmobilenumber.Text + "', Fax='" + txtfax.Text + "', Address='" + txtaddress.Text + "', City='" + txtcity.Text + "', PostalCode='" + txtpostalcode.Text + "', BirthDate='" + txtbirthdate.Text + "', Salary='" + txtsalary.Text + "', SINumber='" + txtsinumber.Text + "', IDNumber='" + txtidnumber.Text + "' where instructorID='" + txtinstructorid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This instructor has been updated!!!")
                Else
                    MsgBox("This instructor has not been updated!!!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If MsgBox("Are you sure you want to delete this instructor?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
                qry = "delete from tblinstructor where instructorid='" + txtinstructorid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The account has been deleted.")
                Else
                    MsgBox("The account has not been deleted.")
                End If
                refreshData()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class