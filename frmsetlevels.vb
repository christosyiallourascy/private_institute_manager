Public Class frmsetlevels
    Private qry As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmsetlevels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "select * from private_institute.tbllevel"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tbllevel As String())
        Try
            txtlevelid.Text = tbllevel(0)
            txtlevelname.Text = tbllevel(1)
            txthoursperweek.Text = tbllevel(2)
            txtrrate.Text = tbllevel(3)
            txtnotes.Text = tbllevel(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtlevelid.Text = "AutoNumber"
        txtlevelname.Clear()
        txthoursperweek.Clear()
        txtnotes.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to save this?", MsgBoxStyle.YesNo, "By Private _Institute") = MsgBoxResult.Yes Then
            Try
                qry = "insert into tbllevel (levelname, hoursperweek, royaltiesrate, notes) values ('" + txtlevelname.Text + "', '" + txthoursperweek.Text + "','" + txtrrate.Text + "', '" + txtnotes.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This level has been saved!!!")
                Else
                    MsgBox("This level has not been saved!!!")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            DisplayData(Form1.con.previousRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Are you sure you want to delete this level?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM tbllevel WHERE levelid='" + txtlevelid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The level has been deleted.")
                Else
                    MsgBox("The level has not been deleted.")
                End If
                refreshData()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class