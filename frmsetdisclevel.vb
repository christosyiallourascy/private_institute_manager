Public Class frmsetdisclevel
    Private qry As String
    Private Sub frmsetdisclevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tbldiscountlevel"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tbldisclevel As String())
        Try
            txtdisclevelid.Text = tbldisclevel(0)
            txtdisclevelname.Text = tbldisclevel(1)
            txtdiscount.Text = tbldisclevel(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        Try
            DisplayData(Form1.con.previousRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure you want to delete this discount level?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM tbldiscountlevel WHERE discountlevelid='" + txtdisclevelid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The discount level has been deleted.")
                Else
                    MsgBox("The discount level has not been deleted.")
                End If
                refreshData()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtdisclevelid.Text = "AutoNumber"
        txtdisclevelname.Clear()
        txtdiscount.Clear()
        txtdisclevelname.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            qry = "insert into tbldiscountlevel (discountname, discount) values ('" + txtdisclevelname.Text + "', '" + txtdiscount.Text + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This discount level has been saved!!!")
            Else
                MsgBox("This discount level has not been saved!!!")
            End If
        Catch ex As Exception

        End Try
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtdisclevelid.Text = "AutoNumber"
        txtdisclevelname.Clear()
        txtdiscount.Clear()
        txtdisclevelname.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MsgBox("Are you sure you want to save this?", MsgBoxStyle.YesNo, "By Private _Institute") = MsgBoxResult.Yes Then
            Try
                qry = "insert into tbldiscountlevel (discountname, discount) values ('" + txtdisclevelname.Text + "', '" + txtdiscount.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This discount level has been saved!!!")
                Else
                    MsgBox("This discount level has not been saved!!!")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Are you sure you want to delete this discount level?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM tbldiscountlevel WHERE discountlevelid='" + txtdisclevelid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The discount level has been deleted.")
                Else
                    MsgBox("The discount level has not been deleted.")
                End If
                refreshData()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class