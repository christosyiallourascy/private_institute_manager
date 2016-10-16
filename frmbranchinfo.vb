Imports System
Imports System.Net.NetworkInformation
Imports System.Management

Public Class frmbranchinfo
    Private qry As String

    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblbranchinfo"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        displayData(Form1.con.returnRowFor(qry))
    End Sub

    Private Sub displayData(ByVal tblinfo As String())
        Try
            txtid.Text = tblinfo(0)
            txtbranch.Text = tblinfo(1)
            txtvatnumber.Text = tblinfo(2)
            txtaddress.Text = tblinfo(3)
            txtwebsite.Text = tblinfo(4)
            txtcompanybranchname.Text = tblinfo(5)
            txtnotes.Text = tblinfo(6)
            txtvat.Text = tblinfo(7)
            txtroyalties.Text = tblinfo(8)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmbranchinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()

    End Sub
   
   
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshData()
    End Sub

    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddclass.Click
        Try
            txtid.Text = "Auto Number"
            txtbranch.Clear()
            txtvatnumber.Clear()
            txtaddress.Clear()
            txtwebsite.Clear()
            txtcompanybranchname.Clear()
            txtvat.Clear()
            txtnotes.Clear()
            txtbranch.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "INSERT INTO `private_institute`.`tblbranchinfo` (`branch`, `vatnumber`, `address`, `website`, `companybranchname`, `notes`, `vat`, `royaltiesrate`) VALUES('" + txtbranch.Text + "', '" + txtvatnumber.Text + "', '" + txtaddress.Text + "', '" + txtwebsite.Text + "', '" + txtcompanybranchname.Text + "', '" + txtnotes.Text + "', '" + txtvat.Text + "', '" + txtroyalties.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This information has been saved!!!")
                Else
                    MsgBox("This information has not been saved!!!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            displayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            displayData(Form1.con.previousRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If MsgBox("Are you sure you want to delete this information?", MsgBoxStyle.YesNo, "Institute Manager") = MsgBoxResult.Yes Then
                qry = "delete from tblbranchinfo where infoid ='" + txtid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("Information has been deleted!!!")
                Else
                    MsgBox("Information has not been deleted!!!")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        Try
            If MsgBox("Are you sure you want to update this information?", MsgBoxStyle.YesNo, "Institute Manager") = MsgBoxResult.Yes Then
                qry = "UPDATE `private_institute`.`tblbranchinfo` SET `branch` = '" + txtbranch.Text + "', `vatnumber` = '" + txtvatnumber.Text + "', `address` = '" + txtaddress.Text + "', `website` = '" + txtwebsite.Text + "', `companybranchname` = '" + txtcompanybranchname.Text + "', `notes` = '" + txtnotes.Text + "', `vat` = '" + txtvat.Text + "', `royaltiesrate` = '" + txtroyalties.Text + "' WHERE infoid = '" + txtid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("Information has been updated!!!")
                Else
                    MsgBox("Information has not been updated!!!")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class