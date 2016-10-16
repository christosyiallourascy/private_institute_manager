Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient

Public Class frmroyaltieslevel

    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim qry As String
    Private Sub refreshData()

        Try
            BindingSource1.DataSource = Nothing
            BindingNavigator1.BindingSource = Nothing
            qry = "select * from `private_institute_central`.`tblroyaltieslevel`"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            BindingSource1.DataSource = myData
            BindingNavigator1.BindingSource = BindingSource1
            Me.txtrlevelid.DataBindings.Add(New Binding("Text", Me.BindingSource1, "royaltieslevelid", True))
            Me.txtlevelname.DataBindings.Add(New Binding("Text", Me.BindingSource1, "levelname", True))
            Me.txtrrate.DataBindings.Add(New Binding("Text", Me.BindingSource1, "royaltiesrate", True))
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmroyaltieslevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub
End Class