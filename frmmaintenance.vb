Imports System
Imports System.Net.NetworkInformation
Imports System.Management
Imports MySql.Data.MySqlClient.MySqlCommand
Imports MySql.Data.MySqlClient.MySqlConnection
Imports MySql.Data.MySqlClient.MySqlException
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmmaintenance
    Private qry As String
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmmaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "show tables in private_institute"
            Dim tablecolumn As String() = Form1.con.returnColumnFor(qry)
            Dim c As Integer = tablecolumn.Length
            Dim i As Integer
            lblnumoftables.Text = "Number of tables listed: " & tablecolumn.Length.ToString
            While (tablecolumn.Length <= c)
                tablelist.Items.Add(tablecolumn(i))
                i = i + 1
            End While

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        lbl_mac_address.Text = Get_MAC_Address()
    End Sub
    Private Function Get_MAC_Address() As String

        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc

            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)

        Next
        Return MACAddress
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim destination As String
            fbd.ShowDialog()
            destination = fbd.SelectedPath.ToString & "\private_institute" & Today.Day & Today.Month & Today.Year & ".sql"
            Process.Start("C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe", "--user=root --password=root --host=localhost --databases private_institute -r """ + destination + """")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim destination, wd As String
            fd.ShowDialog()
            destination = fd.FileName
            'Dim myProcess As New Process()
            'myProcess.StartInfo.FileName = "cmd.exe"
            'myProcess.StartInfo.UseShellExecute = False
            'myProcess.StartInfo.WorkingDirectory = wd
            'myProcess.StartInfo.RedirectStandardInput = True
            'myProcess.StartInfo.RedirectStandardOutput = True
            'myProcess.Start()
            'Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            'Dim mystreamreader As StreamReader = myProcess.StandardOutput
            'myStreamWriter.WriteLine("C:\Program Files\MySQL\MySQL Server 5.5\bin\mysql.exe --host=localhost --user=root --password=root --databases private_institute < """ + destination + """")
            'Dim str As String = mystreamreader.ReadToEnd
            'MessageBox.Show(str)
            'myStreamWriter.Close()
            'myProcess.WaitForExit()
            'myProcess.Close()
            MsgBox(destination)
            Process.Start("C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe", "--user=root --password=root --host=localhost --databases private_institute < " & destination)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub tablelist_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tablelist.MouseClick
        Try
            qry = "select count(*) from " + tablelist.SelectedItem.ToString + ""
            lblnumofrecords.Text = "This table has " & Form1.con.returnSingleValueFor(qry) & " records"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnenrollworkstation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenrollworkstation.Click
        Dim myConnectionString As String
        Dim myid As Integer
        Dim username As String
        Dim password As String
        Try
            username = InputBox("Enter Username")
            password = InputBox("Enter Password")
            myConnectionString = "server=localhost;" _
        & "user=" + username + ";" _
        & "password=" + password + ";" _
        & "database=private_institute_central;charset=utf8;"
            conn.ConnectionString = myConnectionString
            conn.Open()
            lblconnmessage.Text = "You are connected!!!"
            lblconnmessage.ForeColor = Color.Green
            qry = "select * from tblbranch where branchname = 'Ekali'"
            myCommand.Connection = conn
            myCommand.CommandText = qry

            myid = myCommand.ExecuteScalar()


        Catch ex As Exception
            MsgBox(ex.ToString)
            lblconnmessage.Text = "You are not connected!!!"
            lblconnmessage.ForeColor = Color.Red
        End Try
        Try
            qry = "INSERT INTO `private_institute_central`.`tbllicense` (`branchid`, `macaddress`, `macaddress1`, `dateissued`) VALUES('" + myid.ToString + "', '" + lbl_mac_address.Text + "', '" + Date.Today.ToString + "')"
            myCommand.CommandText = qry
            If myCommand.ExecuteNonQuery() Then
                MsgBox("You are workstation has been stored")
            Else
                MsgBox("You are workstation has not been stored")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class