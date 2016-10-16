Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient
Public Class frmdisplaystudentsforthisbranch
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
            lbltitle.Text = bname & " Branch - Display Students Form"
            Me.Text = bname & " Branch - Display Students Form"
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmdisplaystudentsforthisbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select (bstudentid) as 'Branch Student ID', (branchid) as 'Branch ID', (firstname) as 'First Name', (lastname) as 'Last Name', (levelnow) as 'Level Now', (active) as 'Active' from tblbranchstudent where branchid='" + bid.ToString + "'"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            dgstudentsbybranch.DataSource = myData
            dgstudentsbybranch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        Try
            qry = "select schoolyear from tblschoolyears group by(schoolyear) desc"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            myAdapterCmb.SelectCommand = myCommand
            myAdapterCmb.Fill(mydatacmb)
            For Each i In mydatacmb.Rows
                cmbsy.Items.Add(i("schoolyear"))
            Next i
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btncalculateroyalties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculateroyalties.Click
        Dim countele As Integer = 0
        Dim counthigher As Integer = 0
        Dim countint As Integer = 0
        Dim sumofele As Double = 0
        Dim sumofhigher As Double = 0
        Dim sumofint As Double = 0
        Dim rrele As Double
        Dim rrint As Double
        Dim rrhigher As Double
        Dim grandtotal As Double = 0
        Dim totalstudents As Integer = 0

        Try
            qry = "select count(royaltyid) from tblroyalties where month='" + cmbmonth.Text + "' and '" + cmbsy.Text + "' and branchid='" + bid.ToString + "'"
            myCommand.Connection = frmmain.conn
            myCommand.CommandText = qry
            If Val(myCommand.ExecuteScalar <= 0) Then
                For Each row As DataGridViewRow In dgstudentsbybranch.Rows
                    If (CStr(row.Cells(4).FormattedValue).ToString = "Elementary I" Or CStr(row.Cells(4).FormattedValue).ToString = "Elementary II" Or CStr(row.Cells(4).FormattedValue).ToString = "Elementary III") Then
                        countele = countele + 1
                    End If
                    If (CStr(row.Cells(4).FormattedValue).ToString = "Intermediate I" Or CStr(row.Cells(4).FormattedValue).ToString = "Intermediate II" Or CStr(row.Cells(4).FormattedValue).ToString = "Intermediate III") Then
                        countint = countint + 1
                    End If
                    If (CStr(row.Cells(4).FormattedValue).ToString = "Higher I" Or CStr(row.Cells(4).FormattedValue).ToString = "Higher II" Or CStr(row.Cells(4).FormattedValue).ToString = "Higher III") Then
                        counthigher = counthigher + 1
                    End If
                Next row

                totalstudents = countele + countint + counthigher

                qry = "select sum(royaltiesrate) from tblroyaltieslevel where levelname = 'Elementary' limit 1"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                rrele = Val(myCommand.ExecuteScalar()) + 0

                qry = "select sum(royaltiesrate) from tblroyaltieslevel where levelname = 'Intermediate' limit 1"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                rrint = Val(myCommand.ExecuteScalar()) + 0

                qry = "select sum(royaltiesrate) from tblroyaltieslevel where levelname ='Higher' limit 1"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                rrhigher = Val(myCommand.ExecuteScalar()) + 0


                sumofele = countele * rrele
                sumofint = countint * rrint
                sumofhigher = counthigher * rrhigher

                grandtotal = sumofele + sumofint + sumofhigher

                qry = "INSERT INTO `private_institute_central`.`tblroyalties` (`branchid`, `numofstudents`, `numofelem`, `numofint`, `numofhigher`, `sumofelem`, `sumofint`, `sumofhigher`, `grandtotal`, `month`, `date`, `schoolyear`) VALUES('" + bid.ToString + "', '" + totalstudents.ToString + "', '" + countele.ToString + "', '" + countint.ToString + "', '" + counthigher.ToString + "', '" + sumofele.ToString + "', '" + sumofint.ToString + "', '" + sumofhigher.ToString + "', '" + grandtotal.ToString + "', '" + cmbmonth.Text + "', '" + Today.Date.ToString + "', '" + cmbsy.Text + "')"
                myCommand.Connection = frmmain.conn
                myCommand.CommandText = qry
                If myCommand.ExecuteNonQuery() Then
                    MsgBox("Royalties has been saved")
                Else
                    MsgBox("Royalties has not been saved")
                End If
            Else
                MsgBox("You have already calculate royalties for this month and school year")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    
End Class