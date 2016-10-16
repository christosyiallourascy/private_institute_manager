Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient

Public Class frmbranch
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myAdaptercmb As New MySqlDataAdapter
    Dim myAdaptercmbfill As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim myDatacmb As New DataTable
    Dim myDatacmbfill As New DataTable
    Dim qry As String

    Private Sub frmbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()
        Try
            qry = "select * from tblbranch"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdaptercmb.SelectCommand = myCommand
            myAdaptercmb.Fill(myDatacmb)
            cmbbranch.DataSource = myDatacmb
            cmbbranch.DisplayMember = "branchname"
            cmbbranch.ValueMember = "branchid"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub refreshData()

        Try
            BindingSource1.DataSource = Nothing
            BindingNavigator1.BindingSource = Nothing
            qry = "select * from tblbranch"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            BindingSource1.DataSource = myData
            BindingNavigator1.BindingSource = BindingSource1
            Me.txtbranchid.DataBindings.Add(New Binding("Text", Me.BindingSource1, "branchid", True))
            Me.txtbranchname.DataBindings.Add(New Binding("Text", Me.BindingSource1, "branchname", True))
            Me.txtbranchcompanyname.DataBindings.Add(New Binding("Text", Me.BindingSource1, "branchcompanyname", True))
            Me.txtarea.DataBindings.Add(New Binding("Text", Me.BindingSource1, "area", True))
            Me.txtareacovert.DataBindings.Add(New Binding("Text", Me.BindingSource1, "areacovert", True))
            Me.txtdateissued.DataBindings.Add(New Binding("Text", Me.BindingSource1, "dateissued", True))

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            If BindingSource1.Position + 1 < BindingSource1.Count Then
                BindingSource1.MoveNext()
            Else
                BindingSource1.MoveFirst()
            End If
            Me.Invalidate()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            If BindingSource1.Position - 1 < 1 Then
                BindingSource1.MovePrevious()
            Else
                BindingSource1.MoveLast()
            End If
            Me.Invalidate()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        If MsgBox("Are you sure you want to update?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "UPDATE `private_institute_central`.`tblbranch` SET `branchname` = '" + txtbranchname.Text + "', `branchcompanyname` = '" + txtbranchcompanyname.Text + "', `area` = '" + txtarea.Text + "', `areacovert` = '" + txtareacovert.Text + "', `dateissued` = '" + txtdateissued.Text + "' WHERE branchid='" + txtbranchid.Text + "'"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                If myCommand.ExecuteNonQuery() Then
                    MsgBox("The record has been updated")
                Else
                    MsgBox("The record has not been updated")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "INSERT INTO `private_institute_central`.`tblbranch` (`branchname`, `branchcompanyname`, `area`, `areacovert`, `dateissued`) VALUES ('" + txtbranchname.Text + "', '" + txtbranchcompanyname.Text + "','" + txtarea.Text + "','" + txtareacovert.Text + "','" + txtdateissued.Text + "')"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                If myCommand.ExecuteNonQuery() Then
                    MsgBox("The record has been saved")
                Else
                    MsgBox("The record has not been saved")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddclass.Click
        Try
            txtbranchid.Text = "Auto Number"
            txtbranchname.Text = ""
            txtbranchcompanyname.Text = ""
            txtarea.Text = ""
            txtareacovert.Text = ""
            txtdateissued.Text = Date.Today
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM `private_institute_central`.`tblbranch` WHERE branchid='" + txtbranchid.Text + "'"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                If myCommand.ExecuteNonQuery() Then
                    MsgBox("The record has been deleted")
                Else
                    MsgBox("The record has not been deleted")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btndisplaystudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplaystudents.Click
        Try
            Dim dstudents As New frmdisplaystudentsforthisbranch(cmbbranch.SelectedValue.ToString)
            dstudents.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ep As New frmbranchroyalties(cmbbranch.SelectedValue.ToString)
        ep.Show()
    End Sub
End Class