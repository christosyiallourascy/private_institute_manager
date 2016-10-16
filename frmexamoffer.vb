Public Class frmexamoffer
    Private qry As String
    Private Sub frmexamoffer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnupdateexamoffer.Enabled = False
        refreshexamoffer()
    End Sub
    Private Sub refreshexamoffer()
        Try
            qry = "select (examofferid) As ID, concat(examname,' ', subjectcode,' ', distributor) as ExamDetails from tblexamoffer"
            dgexamofferlist.DataSource = Form1.con.returnDataTableFor(qry)
            dgexamofferlist.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub displayexamoffer(ByVal tblexamoffer As String())
        Try
            txtexamofferid.Text = tblexamoffer(0)
            txtexname.Text = tblexamoffer(1)
            txtcompany.Text = tblexamoffer(2)
            txtexamcode.Text = tblexamoffer(3)
            txtpass.Text = tblexamoffer(4)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub dgexamofferlist_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgexamofferlist.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
            Try
                qry = "select * from tblexamoffer t where t.examofferid = '" + sender.CurrentCell.EditedFormattedValue().ToString + "'"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                displayexamoffer(Form1.con.returnRowFor(qry))
                displayexamoffer(Form1.con.nextRow())
                displayexamoffer(Form1.con.previousRow())
                btnupdateexamoffer.Enabled = True
            Catch ex As Exception

            End Try
        End If
    End Sub
   
    Private Sub btnaddexamoffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddexamoffer.Click
        Try
            txtexamofferid.Text = "Auto Number"
            txtexname.Text = ""
            txtexamcode.Text = ""
            txtcompany.Text = ""
            txtpass.Text = ""
            txtexname.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsaveexamoffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveexamoffer.Click
        Try
            qry = "insert into tblexamoffer (examname, distributor, subjectcode, base) values ('" + txtexname.Text + "', '" + txtcompany.Text + "', '" + txtexamcode.Text + "', '" + txtpass.Text + "')"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("This exam offer has been saved!!!")
                refreshexamoffer()
            Else
                MsgBox("This exam offer has not been saved!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnupdateexamoffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateexamoffer.Click
        Try
            qry = "update tblexamoffer set  examofferid='" + txtexamofferid.Text + "', examname='" + txtexname.Text + "', distributor='" + txtcompany.Text + "', subjectcode='" + txtexamcode.Text + "', base='" + txtpass.Text + "' where examofferid ='" + txtexamofferid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("The exam offer has been updateed.")
            Else
                MsgBox("The exam offer has not been updated.")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class