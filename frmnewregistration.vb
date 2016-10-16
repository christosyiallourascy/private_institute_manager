Imports System.Text.UTF8Encoding
Imports System.Text

Public Class frmnewregistration
    Private qry As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select studentid, studentaccid, firstname, lastname, sex, birthdate, entereddate, age, primaryschool, secondaryschool, lyciumschool from tblstudent"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tblstudent As String())
        Try
            txtstudentid.Text = tblstudent(0)
            txtstudentaccid.Text = tblstudent(1)
            txtfirstname.Text = tblstudent(2)
            txtlastname.Text = tblstudent(3)
            txtsex.Text = tblstudent(4)
            txtbirthdate.Text = tblstudent(5)
            txtentereddate.Text = tblstudent(6)
            txtage.Text = tblstudent(7)
            txtelementaryschool.Text = tblstudent(8)
            txtgymnacium.Text = tblstudent(9)
            txtlycium.Text = tblstudent(10)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DisplayDataAcc(ByVal tblstudentacc As String())
        Try
            txtfathersname.Text = tblstudentacc(0)
            txtfatherprofession.Text = tblstudentacc(1)
            txtmothersname.Text = tblstudentacc(2)
            txtmothersprofession.Text = tblstudentacc(3)
            txtaddress.Text = tblstudentacc(4)
            txthomephone.Text = tblstudentacc(5)
            txtfathersmobile.Text = tblstudentacc(6)
            txtmothersmobile.Text = tblstudentacc(7)
            txtfamilyname.Text = tblstudentacc(8)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmnewregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnnewregistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewregistration.Click
        Try
            txtaddress.Clear()
            txtage.Clear()
            txtentereddate.Clear()
            txtfatherprofession.Clear()
            txtfathersmobile.Clear()
            txtfathersname.Clear()
            txtfirstname.Clear()
            txthomephone.Clear()
            txtlastname.Clear()
            txtmothersmobile.Clear()
            txtmothersname.Clear()
            txtmothersprofession.Clear()
            txtsex.Text = ""
            txtstudentaccid.Clear()
            txtstudentid.Clear()
            txtfamilyname.Clear()
            txthomephone.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcritiria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        Dim count As Integer
        If e.KeyCode = Keys.Enter Then
            Try
                qry = "select fathername, fprofession, mothername, mprofession, address, homephone, mobilefather, mobilemother, familyname from tblstudentaccount where homephone='" + txtcritiria.Text + "'"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                DisplayDataAcc(Form1.con.nextRow())
                DisplayDataAcc(Form1.con.previousRow())

            Catch ex As Exception

            End Try
            Try
                qry = "select count(homephone) from tblstudentaccount where homephone='" + txtcritiria.Text + "'"
                count = Form1.con.returnSingleValueFor(qry)
                If count <= 0 Then
                    MsgBox("There is no account with this home phone number!!!")
                    txthomephone.Text = txtcritiria.Text
                    txtfathersname.Focus()
                Else
                    btnaddnewstudent.Enabled = True
                End If
            Catch ex As Exception

            End Try
            Try
                qry = "select t.firstname, t.lastname, t.mobilephone, t1.homephone from tblstudent t, tblstudentaccount t1 where t1.homephone = '" + txtcritiria.Text + "' and t.studentaccid = t1.studentaccid"
                showstudents.DataSource = Form1.con.returnDataTableFor(qry)
            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub txtcritiria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcritiria.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim count As Integer
        Try
            qry = "select count(homephone) from tblstudentaccount where homephone='" + txthomephone.Text + "'"
            count = Form1.con.returnSingleValueFor(qry)
        Catch ex As Exception

        End Try
        Try
            qry = "SET NAMES utf8"
            Form1.con.executeNonQuery(qry)
        Catch ex As Exception

        End Try
        Try
            If count <= 0 Then
                
                qry = "insert into tblstudentaccount (fathername, fprofession, mothername, mprofession, address, homephone, mobilefather, mobilemother, status, familyname) values ('" + txtfathersname.Text + "', '" + txtfatherprofession.Text + "', '" + txtmothersname.Text + "', '" + txtmothersprofession.Text + "', '" + txtaddress.Text + "', '" + txthomephone.Text + "', '" + txtfathersmobile.Text + "', '" + txtmothersmobile.Text + "', 'Active', '" + txtfamilyname.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("Account created auccessfully!!!")
                    btnaddnewstudent.Enabled = True
                Else
                    MsgBox("Account has not been created!!!")
                End If
            Else
                MsgBox("There already exist an account with this home phone number!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub btnaddnewstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnewstudent.Click
        Try
            qry = "select studentaccid from tblstudentaccount where homephone = '" + txthomephone.Text + "'"
            txtstudentaccid.Text = Form1.con.returnSingleValueFor(qry)
            txtstudentid.Text = "Auto Number"
            txtfirstname.Text = ""
            txtlastname.Text = ""
            txtsex.Text = ""
            txtentereddate.Text = ""
            txtage.Text = ""
            txtelementaryschool.Text = ""
            txtgymnacium.Text = ""
            txtlycium.Text = ""
            txtbirthdate.Text = ""
            txtfirstname.Focus()
            txtentereddate.Text = Today
            btnsave.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            qry = "SET NAMES utf8"
            Form1.con.executeNonQuery(qry)
        Catch ex As Exception

        End Try
        Try
            qry = "insert into tblstudent (studentaccid, firstname, lastname, sex, birthdate, entereddate, age, status, primaryschool, secondaryschool, lyciumschool) values('" + txtstudentaccid.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtsex.Text + "', '" + txtbirthdate.Text + "', '" + txtentereddate.Text + "', '" + txtage.Text + "', 'Active', '" + txtelementaryschool.Text + "', '" + txtgymnacium.Text + "', '" + txtlycium.Text + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("Student has been added successfully!!!")
                btnaddnewstudent.Enabled = True
            Else
                MsgBox("Student has not been added!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdateaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateaccount.Click
        Try
            qry = "SET NAMES utf8"
            Form1.con.executeNonQuery(qry)
        Catch ex As Exception

        End Try
        Try
            qry = "update tblstudent set studentaccid='" + txtstudentaccid.Text + "', firstname='" + txtfirstname.Text + "', lastname='" + txtlastname.Text + "', sex='" + txtsex.Text + "', birthdate='" + txtbirthdate.Text + "', entereddate='" + txtentereddate.Text + "', age='" + txtage.Text + "', primaryschool='" + txtelementaryschool.Text + "', secondaryschool='" + txtgymnacium.Text + "', lyciumschool='" + txtlycium.Text + "' where studentid='" + txtstudentid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("Student record has been updated successfully!!!")
            Else
                MsgBox("Student record has not been updated!!!")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class