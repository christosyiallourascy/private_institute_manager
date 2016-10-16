Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient

Public Class frmconnectonline
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String


    Private Sub frmconnectonline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myConnectionString As String

        'myConnectionString = "server=mysql12.000webhost.com;" _
        '& "user=a6971579_ekali;" _
        '& "password=ekali2010;" _
        '& "database=a6971579_ekali;"
        myConnectionString = "server=localhost;" _
        & "user=root;" _
        & "password=root;" _
        & "database=private_institute;charset=utf8;"
        conn.ConnectionString = myConnectionString
        SQL = "select * from tblstudent"
        Try
            conn.Open()

            MessageBox.Show("Connection Opened Successfully")
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                onlinelist.DataSource = myData
                onlinelist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Catch myerror As MySqlException
                MsgBox("There was an error reading from the database: " & myerror.Message)
            End Try

            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MessageBox.Show("Cannot connect to server. Contact administrator")
                Case 1045
                    MessageBox.Show("Invalid username/password, please try again")
                Case Else
                    MessageBox.Show("Cannot connect to server. Contact administrator1")
            End Select
        End Try
    End Sub
End Class