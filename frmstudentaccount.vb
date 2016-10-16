Option Strict On
Public Class frmstudentaccount

    Private qry As String
    Private qryCombo As String
    Private qrydatagrid As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub refreshData()
        qry = "select count(studentaccid) from private_institute.tblstudentaccount"
        lblnumofrecords.Text = "Number Of Records: " & Form1.con.returnSingleValueFor(qry)
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblstudentaccount"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
        ShowStudents()
    End Sub
    Private Sub DisplayData(ByVal tblstudentaccount As String())

        Try
            txtstudentaccountnumber.Text = tblstudentaccount(0)
            txtfathername.Text = tblstudentaccount(1)
            txtfatherpro.Text = tblstudentaccount(2)
            txtmothername.Text = tblstudentaccount(3)
            txtmotherpro.Text = tblstudentaccount(4)
            txtdiscount.SelectedValue = tblstudentaccount(5)
            txtnationality.Text = tblstudentaccount(6)
            txtaddress.Text = tblstudentaccount(7)
            txttown.Text = tblstudentaccount(8)
            txtcommunity.Text = tblstudentaccount(9)
            txtpostalcode.Text = tblstudentaccount(10)
            txthomephone.Text = tblstudentaccount(11)
            txtworkphone.Text = tblstudentaccount(12)
            txtmobilefather.Text = tblstudentaccount(13)
            txtmobilemother.Text = tblstudentaccount(14)
            txtfaxnumber.Text = tblstudentaccount(15)
            txtnotes.Text = tblstudentaccount(16)
            txtstatus.Text = tblstudentaccount(17)
            txtfamilyname.Text = tblstudentaccount(18)
            txtfatheremail.Text = tblstudentaccount(19)
            txtmotheremail.Text = tblstudentaccount(20)
            txtarea.Text = tblstudentaccount(21)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmstudentaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select CONCAT(discountname,' ', discount, ' ', '%') AS discname, discount from tbldiscountlevel"
            Form1.con.BindQueryTo(qry, "discname", "discount", txtdiscount)
        Catch ex As Exception

        End Try
        Try
            refreshData()
            ShowStudents()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
            ShowStudents()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
            ShowStudents()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this record?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            qry = "INSERT INTO tblstudentaccount (fathername, fprofession, mothername, mprofession, discount, nationality, address, city, community, postalcode, homephone, workphone, mobilefather, mobilemother, fax, notes, status, familyname, fatheremail, motheremail, area) VALUES ('" + txtfathername.Text + "','" + txtfatherpro.Text + "','" + txtmothername.Text + "', '" + txtmotherpro.Text + "', '" + txtdiscount.SelectedValue.ToString + "', '" + txtnationality.Text + "', '" + txtaddress.Text + "', '" + txttown.Text + "', '" + txtcommunity.Text + "', '" + txtpostalcode.Text + "', '" + txthomephone.Text + "', '" + txtworkphone.Text + "', '" + txtmobilefather.Text + "', '" + txtmobilemother.Text + "', '" + txtfaxnumber.Text + "', '" + txtnotes.Text + "', '" + txtstatus.Text + "', '" + txtfamilyname.Text + "', '" + txtfatheremail.Text + "', '" + txtmotheremail.Text + "', '" + txtarea.Text + "')"
            Try
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("Student Account Created!")
                    refreshData()
                Else
                    MsgBox("Student Account cannot be Created!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnaddaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddaccount.Click
        txtaddress.Clear()
        txtamountgive.Clear()
        txtarea.Clear()
        txtcommunity.Text = "Greek-Cypriot"
        txtdiscount.Text = ""
        txtfamilyname.Clear()
        txtfatheremail.Clear()
        txtfathername.Clear()
        txtfatherpro.Clear()
        txtfaxnumber.Clear()
        txthomephone.Clear()
        txtmobilefather.Clear()
        txtmobilemother.Clear()
        txtmotheremail.Clear()
        txtmothername.Clear()
        txtmotherpro.Clear()
        txtnationality.Text = "Cypriot"
        txtnotes.Clear()
        txtpostalcode.Clear()
        txtstatus.Text = "Active"
        txtstudentaccountnumber.Text = "(AutoNumber)"
        txttown.Text = "Limassol"
        txtworkphone.Clear()
        txtfathername.Focus()

    End Sub

    Private Sub ShowStudents()
        qrydatagrid = "SELECT (studentid) as 'Student ID', (studentaccid) as 'Student Account ID', (title) as Title, (firstname) as 'First Name', (lastname) as 'Last Name', (mobilephone) as 'Mobile Phone', (age) as Age, (status) as Status FROM `tblstudent` where studentaccID='" + txtstudentaccountnumber.Text + "'"
        gridstudents.DataSource = Form1.con.returnDataTableFor(qrydatagrid)
        gridstudents.AutoResizeColumns()
    End Sub

    Private Sub btnaddstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstudent.Click
        Dim frmst As New frmstudent(txtstudentaccountnumber.Text)
        frmst.Show()
        frmst.ClearFields()
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM tblstudentaccount WHERE studentaccID='" + txtstudentaccountnumber.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The account has been deleted.")
                Else
                    MsgBox("The account has not been deleted.")
                End If
                refreshData()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtcritiria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        Dim count As Integer
        If e.KeyCode = Keys.Enter Then
            Try
                qry = "select count(homephone) from tblstudentaccount where homephone='" + txtcritiria.Text + "'"
                count = CInt(Form1.con.returnSingleValueFor(qry))
                If count <= 0 Then
                    MsgBox("There is no account with this home phone number!!!")
                Else
                    Try
                        qry = "select * from tblstudentaccount where homephone='" + txtcritiria.Text + "'"
                        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                        DisplayData(Form1.con.nextRow())
                        DisplayData(Form1.con.previousRow())

                    Catch ex As Exception

                    End Try
                    Try
                        qrydatagrid = "SELECT * FROM `private_institute`.`tblstudent` where studentaccID='" + txtstudentaccountnumber.Text + "' and homephone='" + txtcritiria.Text + "'"
                        gridstudents.DataSource = Form1.con.returnDataTableFor(qrydatagrid)
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtcritiria_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcritiria.MaskInputRejected

    End Sub

    Private Sub btnupdateaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateaccount.Click
        If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "update tblstudentaccount set fathername='" + txtfathername.Text + "', fprofession='" + txtfatherpro.Text + "', mothername='" + txtmothername.Text + "', mprofession='" + txtmotherpro.Text + "', discount='" + txtdiscount.SelectedValue.ToString + "', nationality='" + txtnationality.Text + "', address='" + txtaddress.Text + "', city='" + txttown.Text + "', community='" + txtcommunity.Text + "', postalcode='" + txtpostalcode.Text + "', homephone='" + txthomephone.Text + "', workphone='" + txtworkphone.Text + "', mobilefather='" + txtmobilefather.Text + "', mobilemother='" + txtmobilemother.Text + "', fax='" + txtfaxnumber.Text + "', notes='" + txtnotes.Text + "', status='" + txtstatus.Text + "', familyname='" + txtfamilyname.Text + "', fatheremail='" + txtfatheremail.Text + "', motheremail='" + txtmotheremail.Text + "', area='" + txtarea.Text + "' where studentaccid='" + txtstudentaccountnumber.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The account has been updateed.")
                Else
                    MsgBox("The account has not been updated.")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshData()
    End Sub

    Private Sub btnprintaccstatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintaccstatement.Click
        Dim frmaccst As New frmaccountstatement(txtstudentaccountnumber.Text)
        frmaccst.Show()
    End Sub

    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        Dim frmpay As New frmpayments(txtstudentaccountnumber.Text, 1)
        frmpay.Show()
    End Sub
End Class