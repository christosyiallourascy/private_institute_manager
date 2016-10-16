Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient
Public Class frmbranchroyalties
    Private bid As Integer
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myAdapterCmb As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim mydatacmb As New DataTable
    Dim qry As String
    Dim bname As String
    Public Sub New(ByVal bid As String)
        Me.bid = bid
        InitializeComponent()
        Try
            qry = "select branchname from tblbranch where branchid='" + bid + "'"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry

            bname = myCommand.ExecuteScalar
            lbltitle.Text = bname & " Branch - Display Royalties Form"
            Me.Text = bname & " Branch - Display Royalties Form"
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
       
    End Sub

    Private Sub frmbranchroyalties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshData()
    End Sub
    Private Sub refreshData()

        Try
            BindingSource1.DataSource = Nothing
            BindingNavigator1.BindingSource = Nothing
            qry = "select * from private_institute_central.tblroyalties where branchid='" + bid.ToString + "'"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            BindingSource1.DataSource = myData
            BindingNavigator1.BindingSource = BindingSource1
            Me.txtroyaltyid.DataBindings.Add(New Binding("Text", Me.BindingSource1, "royaltyid", True))
            Me.txtbranchid.DataBindings.Add(New Binding("Text", Me.BindingSource1, "branchid", True))
            Me.txtnumstudents.DataBindings.Add(New Binding("Text", Me.BindingSource1, "numofstudents", True))
            Me.txtnumelem.DataBindings.Add(New Binding("Text", Me.BindingSource1, "numofelem", True))
            Me.txtnumint.DataBindings.Add(New Binding("Text", Me.BindingSource1, "numofint", True))
            Me.txtnumhigher.DataBindings.Add(New Binding("Text", Me.BindingSource1, "numofhigher", True))
            Me.txtsumelem.DataBindings.Add(New Binding("Text", Me.BindingSource1, "sumofelem", True))
            Me.txtsumint.DataBindings.Add(New Binding("Text", Me.BindingSource1, "sumofint", True))
            Me.txtsumhigher.DataBindings.Add(New Binding("Text", Me.BindingSource1, "sumofhigher", True))
            Me.txtgrandtotal.DataBindings.Add(New Binding("Text", Me.BindingSource1, "grandtotal", True))
            Me.txtmonth.DataBindings.Add(New Binding("Text", Me.BindingSource1, "month", True))
            Me.txtdate.DataBindings.Add(New Binding("Text", Me.BindingSource1, "date", True))
            Me.txtschoolyear.DataBindings.Add(New Binding("Text", Me.BindingSource1, "schoolyear", True))
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnprintselected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintselected.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

    Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Courier New", 12, FontStyle.Regular)
        Dim myfont1 As New Font("Courier New", 14, FontStyle.Bold)
        Dim myfont2 As New Font("Courier New", 12, FontStyle.Bold)
        FontHeight = myfont.GetHeight(e.Graphics) + 5
        Dim x, y As Integer

        x = 50
        y = 50
        e.Graphics.DrawString("CYBERNET COMPUTER TRAINING CENTERS", myfont1, Brushes.Black, x, y)
        e.Graphics.DrawImage(Image.FromFile("logo.jpg"), x + 425, y)
        y = y + FontHeight
        y = y + FontHeight
        e.Graphics.DrawString("CYBERNET " & bname, myfont2, Brushes.Black, x, y)
        y = y + FontHeight

        Try
            e.Graphics.DrawString("Royalties Report for the month " & MonthName(txtmonth.Text), myfont2, Brushes.Black, x, y)
            y = y + FontHeight
            e.Graphics.DrawString("Royalty ID", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtroyaltyid.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Sudents", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtnumstudents.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Elementary", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtnumelem.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Intermediate", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtnumint.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Number Of Higher", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtnumhigher.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Elementary", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtsumelem.Text & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Intermediate", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtsumint.Text & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Total Of Higher", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtsumhigher.Text & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Grand Total", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtgrandtotal.Text & " €", myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("School Year", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtschoolyear.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
            e.Graphics.DrawString("Date", myfont2, Brushes.Black, x, y)
            e.Graphics.DrawString(txtdate.Text, myfont, Brushes.Black, x + 250, y)
            y = y + FontHeight
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        refreshData()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM `private_institute_central`.`tblroyalties` WHERE branchid='" + bid.ToString + "'"
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
End Class