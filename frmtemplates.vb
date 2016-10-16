Public Class frmtemplates
    Private qry As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tbltemplate"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tbltemplate As String())
        Try
            txtteplateid.Text = tbltemplate(0)
            txtto.Text = tbltemplate(1)
            txtsubject.Text = tbltemplate(2)
            txtbody.Text = tbltemplate(3)
            txtdate.Value = tbltemplate(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "INSERT INTO `tbltemplate` (`to`,`subject`,`body`,`date`) VALUES ('" + txtto.Text + "', '" + txtsubject.Text + "', '" + txtbody.Text + "', '" + txtdate.Value.Date + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This template has been saved!!!")
                Else
                    MsgBox("This template has not been saved!!!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub frmtemplates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()
        ToolTiptxtbody.SetToolTip(txtbody, "This text area is multiline")
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshData()
    End Sub

    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddclass.Click
        Try
            txtteplateid.Text = "AutoNumber"
            txtto.Text = ""
            txtsubject.Text = ""
            txtbody.Text = ""
            txtdate.Value = Today.Date
            txtto.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "DELETE FROM `tbltemplate` WHERE templateid='" + txtteplateid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This template has been deleted!!!")
                Else
                    MsgBox("This template has not been deleted!!!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        Try
            If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
                qry = "UPDATE `tbltemplate` SET  `to` = '" + txtto.Text + "', `subject` = '" + txtsubject.Text + "', `body` = '" + txtbody.Text + "', `date` = '" + txtdate.Value.Date + "' WHERE templateid='" + txtteplateid.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This template has been updated!!!")
                    refreshData()
                Else
                    MsgBox("This template has not been updated!!!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class