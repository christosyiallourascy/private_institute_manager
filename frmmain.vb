Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient

Public Class frmmain
    Public conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String
    Dim myConnectionString As String
    Private username As String
    Private password As String
    Private hostname As String
    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lbldatetimenow.Text = Now.Date & ", " & Now.DayOfWeek.ToString
            lbldatetimenow.Top = Me.Height - (lbldatetimenow.Height + 100)
            lbldatetimenow.Left = Me.Left
            Label1.Left = ((Me.Left + Me.Width) / 2) - (Label1.Width / 2)
            btnexit.Left = Me.Width - (btnexit.Width + 50)
            btnexit.Top = Me.Height - (btnexit.Height + 100)
            lblrights.Text = "Powered By Visual Studio 2010 and MySQL Server" + Environment.NewLine + "Design and Develop by Yiallouras Christos"
            lblrights.Top = Me.Height - (lblrights.Height + 100)
        Catch ex As Exception

        End Try
        Try
            username = LoginForm1.UsernameTextBox.Text
            password = LoginForm1.PasswordTextBox.Text
            hostname = LoginForm1.txthostname.Text
            myConnectionString = "server=" + hostname + ";" _
            & "user=" + username + ";" _
            & "password=" + password + ";" _
            & "database=private_institute_central;charset=utf8;"
            conn.ConnectionString = myConnectionString
            Try
                conn.Open()
                LoginForm1.Hide()
            Catch exerror As MySqlException
                MsgBox("There was an error reading from the database: " & exerror.Message)
                Me.Close()
            End Try

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "By Private Institute Central") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnaddbarnch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddbarnch.Click
        frmbranch.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "By Private Institute Central") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmroyaltieslevel.Show()
    End Sub

    Private Sub btnaddnewsy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnewsy.Click
        frmschoolyears.Show()
    End Sub
End Class
