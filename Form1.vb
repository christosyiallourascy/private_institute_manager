Imports System.Text
Imports System.IO
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32
Public Class Form1

    Public con As MySqlBasicConnector.data
    Private qry As String
    Private username As String
    Private password As String
    Private hostname As String
    Private dbname As String
    Private branchdetails As String() = Nothing
    Private branchinfodetailsmessage As String = ""
    Dim filenumber As Integer 'This is a variable were delcaring to get in the value of freefile function.It assigns automatically the value which represents the file
    Dim times_used As Integer = 1 'here,our program sets how many times used so far..were initializing it here
    Dim max_limit As Integer = 15 'Set the maximum number of times he can use here.

    Private Sub demosoft()
        filenumber = FreeFile() 'We assign the number which represents which file to open
        If IO.File.Exists(Application.StartupPath & "\check.myext") Then 'Checking if file exists..
            FileOpen(filenumber, Application.StartupPath & "\check.myext", OpenMode.Random, OpenAccess.ReadWrite) 'If exists,were opening it in readwrite mode.
            FileGet(filenumber, times_used) 'Were reading from the file the value thats stored..ie the number of times he has used
            MsgBox("You have executed this software " & (times_used) & " times") 'hmmm,were displaying it here..
            FileClose(filenumber) 'Lets close the file now.
            If times_used >= max_limit Then 'Were checking if the user has used the software more than the limit specified
                MsgBox("Sorry,Your trial period is over!!-) ") 'oops,if it has exceeded,then,he cant use it  
                Application.Exit() 'Say Goodbye to the user..cos,he needs to purchase..We exit our app here.
            End If
            times_used = times_used + 1 'if he has used it once before,lets make it 2 now since this is the 2nd time
            FileOpen(filenumber, Application.StartupPath & "\check.myext", OpenMode.Random, OpenAccess.ReadWrite) 'storing the value back here 
            FilePut(filenumber, times_used)
            FileClose(filenumber)
        Else
            'This part is if the user is using the software for the 1st time.The file has to be created
            FileOpen(filenumber, Application.StartupPath & "\check.myext", OpenMode.Random, OpenAccess.ReadWrite)
            FilePut(filenumber, times_used) 'ok,now he has opened and used once,so,lets write it in here.
            FileClose(filenumber)
        End If
    End Sub


    Private Sub regcheck()
        Dim regKey As RegistryKey 'Declaring a new registry key here
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True) 'opening this subkey in the registry
        regKey.CreateSubKey("demosoft") 'Were creating a new subkey called Demosoft
        regKey.SetValue("demosoft", times_used) 'We're setting how many times used in the registry
        Try
            times_used = regKey.GetValue("demosoft", 0) 'We're getting how many times used
        Catch ex As Exception
            MsgBox("error")
        End Try
        If times_used > max_limit Then 'Checking if times used is greater than maximum limit
            MsgBox("Your trial period as expired!") 'If it is,well,we display a message box to the user saying its expired..
            Application.Exit() 'And here,we exit the application again.
        End If
        regKey.Close() 'Our job is done,so we close the regkey here 
    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'demosoft()
            'regcheck()
        Catch ex As Exception

        End Try

        lbldatetimenow.Text = Now.Date & ", " & Now.DayOfWeek.ToString
        lbldatetimenow.Top = Me.Height - (lbldatetimenow.Height + 100)
        lbldatetimenow.Left = Me.Left
        Label1.Left = ((Me.Left + Me.Width) / 2) - 200
        btnexit.Left = Me.Width - (btnexit.Width + 50)
        btnexit.Top = Me.Height - (btnexit.Height + 100)
        TabControl1.Width = Me.Width - 50
        lblrights.Text = "Powered By Visual Studio 2010 and MySQL Server" + Environment.NewLine + "Designed and Developed by Yiallouras Christos"
        lblrights.Top = Me.Height - (lblrights.Height + 100)
        Try
            username = LoginForm.txtusername.Text
            password = LoginForm.txtpassword.Text
            hostname = LoginForm.txthost.Text
            dbname = LoginForm.dbname
            con = New MySqlBasicConnector.data(username, password, hostname, dbname)

            qry = "set character_set_database = utf8"
            con.executeNonQuery(qry)
            qry = "set character_set_server = utf8"
            con.executeNonQuery(qry)
            qry = "set character_set_system = utf8"
            con.executeNonQuery(qry)
            qry = "set collation_database = utf8_general_ci"
            con.executeNonQuery(qry)
            qry = "set collation_server = utf8_general_ci"
            con.executeNonQuery(qry)
            qry = "SET NAMES utf8"
            con.executeNonQuery(qry)
            LoginForm.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            LoginForm.Show()
        End Try
        Try
            qry = "select year from tblclass group by(year) desc"
            con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            qry = "select (classid) as 'Class ID', concat(classname,' ', room, ' ',day1,' ', time1) as Class from tblclass where year = '" + comboschoolyear.Text + "'"
            groupsperyear.DataSource = con.returnDataTableFor(qry)
            groupsperyear.AutoResizeColumns()
        Catch ex As Exception

        End Try
        Try
            qry = "select count(studentid)  from  private_institute.tblstudent where month(str_to_date(birthdate, '%d/%m/%Y')) = month(str_to_date('" + Date.Today + "', '%d/%m/%Y')) and day(str_to_date(birthdate, '%d/%m/%Y')) = day(str_to_date('" + Date.Today + "', '%d/%m/%Y'))"
            If con.returnSingleValueFor(qry) > 0 Then
                MsgBox("Today we have students birthdate", MsgBoxStyle.OkOnly, "By Private Institute")
                Dim studentsbirthday As New System.Windows.Forms.DataGridView()
                qry = "select (studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (birthdate) as 'Birthdate' from tblstudent where month(str_to_date(birthdate, '%d/%m/%Y')) = month(str_to_date('" + Date.Today + "', '%d/%m/%Y'))"
                studentsbirthday.DataSource = con.returnDataTableFor(qry)
                studentsbirthday.Width = 400
                studentsbirthday.Height = 300
                studentsbirthday.AllowUserToAddRows = False
                studentsbirthday.AllowUserToDeleteRows = False
                studentsbirthday.Location = New System.Drawing.Point(460, 30)
                Me.TabPage3.Controls.Add(studentsbirthday)
                studentsbirthday.AutoResizeColumns()
            End If

        Catch ex As Exception

        End Try
        Try
            qry = "select count(eventname) as 'Event Name' from tblevents where str_to_date(eventdate, '%d/%m/%Y')=str_to_date('" + Date.Today + "', '%d/%m/%Y')"
            If con.returnSingleValueFor(qry) > 0 Then
                qry = "select (eventname) as 'Event Name' from tblevents where str_to_date(eventdate, '%d/%m/%Y')=str_to_date('" + Date.Today + "', '%d/%m/%Y')"
                Dim todayevents As New System.Windows.Forms.DataGridView()
                todayevents.DataSource = con.returnDataTableFor(qry)
                todayevents.Width = 400
                todayevents.Height = 300
                todayevents.AllowUserToAddRows = False
                todayevents.AllowUserToDeleteRows = False
                todayevents.Location = New System.Drawing.Point(30, 40)
                Me.TabPage3.Controls.Add(todayevents)
                todayevents.AutoResizeColumns()
            End If

        Catch ex As Exception

        End Try
        Try
            Dim schy As String
            Dim todayclasses As String()
            qry = "select year from tblclass group by(year) desc limit 1"
            schy = con.returnSingleValueFor(qry)
            qry = "select classid from tblclass where year = '" + schy + "' and (day1='" + Date.Today.DayOfWeek.ToString + "' or day2='" + Date.Today.DayOfWeek.ToString + "') and closed='No'"
            todayclasses = con.returnColumnFor(qry)
            Dim g As System.Windows.Forms.DataGridView
            For i = 0 To todayclasses.Length - 1
                g = New System.Windows.Forms.DataGridView()
                g.Width = 400
                g.Height = 200
                g.AllowUserToAddRows = False
                g.AllowUserToDeleteRows = False
                g.Location = New System.Drawing.Point(15, 15)
                If i > 0 Then
                    If i < 2 Then
                        g.Location = New System.Drawing.Point(g.Width + 40, 15)
                    ElseIf i = 2 Then
                        g.Location = New System.Drawing.Point(15, g.Height + 15)
                    ElseIf i > 2 Then
                        g.Location = New System.Drawing.Point(g.Width + 40, g.Height + 15)
                    End If
                End If
                    Me.TabPage2.Controls.Add(g)
                    g.AutoResizeColumns()
                    qry = "select count(t1.studentid) from tblstudentclass t, tblstudent t1, tblstudentaccount t2 where classid ='" + todayclasses(i) + "' and t1.studentid = t.studentid and t1.studentaccid = t2.studentaccid"
                    If con.returnSingleValueFor(qry) > 0 Then
                        qry = "select (t1.studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tblstudentclass t, tblstudent t1, tblstudentaccount t2 where classid ='" + todayclasses(i) + "' and t1.studentid = t.studentid and t1.studentaccid = t2.studentaccid"
                        g.DataSource = con.returnDataTableFor(qry)
                    Else
                        qry = "select (t1.adultid) as 'Adult ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tbladultclass t, tbladult t1 where classid ='" + todayclasses(i) + "' and t1.adultid = t.adultid"
                        g.DataSource = con.returnDataTableFor(qry)
                    End If
            Next i
        Catch ex As Exception

        End Try
        Try
            qry = "select * from tblbranchinfo limit 1"
            Me.con.setCurrentDataTable() = Me.con.returnDataTableFor(qry)
            branchdetails = Me.con.nextRow()
            branchdetails = Me.con.previousRow()
            branchinfodetailsmessage = "Branch Name: " & branchdetails(1) & vbNewLine & "WebSite: " & branchdetails(4) & vbNewLine & "Address: " & branchdetails(3) & vbNewLine & "Telephone: " & branchdetails(6)
            lblbranchdetails.Text = branchinfodetailsmessage
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnstudentaccount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentaccount.Click
        frmstudentaccount.Show()
    End Sub

    Private Sub btnexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub brnsearchforanaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnsearchforanaccount.Click
        frmsearchforaccount.Show()
    End Sub

    Private Sub btnstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudent.Click
        Dim frmst As New frmstudent(0)
        frmst.Show()
    End Sub


    Private Sub btninstructors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninstructors.Click
        frminstructor.Show()
    End Sub

    Private Sub btnclasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclasses.Click
        frmclass.Show()
    End Sub

    Private Sub btnctivestudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnexams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexams.Click
        frmexam.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmnewregistration.Show()

    End Sub

    Private Sub StudentAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentAccountToolStripMenuItem.Click
        frmstudentaccount.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Dim frmst As New frmstudent(0)
        frmst.Show()
    End Sub

    Private Sub InstructorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructorsToolStripMenuItem.Click
        frminstructor.Show()
    End Sub

    Private Sub ClassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassesToolStripMenuItem.Click
        frmclass.Show()
    End Sub

    Private Sub ExamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamsToolStripMenuItem.Click
        frmexam.Show()
    End Sub

    Private Sub AbsencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsencesToolStripMenuItem.Click
        frmabsences.Show()
    End Sub

    Private Sub SearchForAnAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchForAnAccountToolStripMenuItem.Click
        frmsearchforaccount.Show()
    End Sub

    Private Sub SearchForAStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchForAStudentToolStripMenuItem.Click
        frmsearchbystudent.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
            End
        End If

    End Sub

    Private Sub FastRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastRegistrationToolStripMenuItem.Click
        frmnewregistration.Show()
    End Sub

    Private Sub ClassesAndStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassesAndStudentsToolStripMenuItem.Click
        Dim ep As New frmbindstudenttoclass(0)
        ep.Show()
    End Sub

    Private Sub ClassesAndStudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmstudentandclasses.Show()
    End Sub

    Private Sub btnlessons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlessons.Click
        frmlesson.Show()
    End Sub

    Private Sub SetLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetLevelToolStripMenuItem.Click
        frmsetlevels.Show()
    End Sub

    Private Sub SetDiscountLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDiscountLevelToolStripMenuItem.Click
        frmsetdisclevel.Show()
    End Sub

    Private Sub StudentPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentPaymentsToolStripMenuItem.Click
        Dim p As New frmpayments("0", 1)
        p.ClearAll()
        p.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmtodaypayments.Show()
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmconnectonline.Show()
    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            qry = "select (classid) as ClassID, concat(classname,' ', room, ' ',day1,' ', time1) as Class from tblclass where year = '" + comboschoolyear.Text + "'"
            groupsperyear.DataSource = con.returnDataTableFor(qry)
            groupsperyear.AutoResizeColumns()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub groupsperyear_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles groupsperyear.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
            Try

                qry = "select (t1.studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tblstudentclass t, tblstudent t1, tblstudentaccount t2 where classid ='" + sender.CurrentCell.EditedFormattedValue().ToString() + "' and t1.studentid = t.studentid and t1.studentaccid = t2.studentaccid"
                groupstudents.DataSource = con.returnDataTableFor(qry)
                qry = "select count(t1.studentid) from tblstudentclass t, tblstudent t1, tblstudentaccount t2 where classid ='" + sender.CurrentCell.EditedFormattedValue().ToString() + "' and t1.studentid = t.studentid and t1.studentaccid = t2.studentaccid"
                If Me.con.returnSingleValueFor(qry) <= 0 Then
                    qry = "select (t1.adultid) as 'Adult ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tbladultclass t, tbladult t1 where classid ='" + sender.CurrentCell.EditedFormattedValue().ToString() + "' and t1.adultid = t.adultid"
                    groupstudents.DataSource = con.returnDataTableFor(qry)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ep As New frmbindstudenttoclass(0)
        ep.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmsetlevels.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmsetdisclevel.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmaccountsum.Show()
    End Sub

    Private Sub TodayPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayPaymentsToolStripMenuItem.Click
        frmtodaypayments.Show()
    End Sub

    Private Sub EventsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventsToolStripMenuItem.Click
        frmevents.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmconnectonline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub TotalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalsToolStripMenuItem.Click
        frmaccountsum.Show()
    End Sub

    Private Sub LessonPlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LessonPlanToolStripMenuItem.Click
        frmlessonplan.Show()
    End Sub

    Private Sub LetterTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetterTemplateToolStripMenuItem.Click
        frmtemplates.Show()
    End Sub

    Private Sub BranchInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchInformationToolStripMenuItem.Click
        frmbranchinfo.Show()
    End Sub

    Private Sub AdultStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmadults.Show()
    End Sub

    Private Sub CalculateRoyaltiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateRoyaltiesToolStripMenuItem.Click
        frmroyalties.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmlessonplan.Show()
    End Sub

    Private Sub AdultPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim adultpayments As New frmpayments("0", 0)
        adultpayments.ClearAll()
        adultpayments.Show()
    End Sub

    Private Sub BackRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackRestoreToolStripMenuItem.Click
        frmmaintenance.Show()
    End Sub

    Private Sub SendEmailToAllActiveStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEmailToAllActiveStudentsToolStripMenuItem.Click
        Dim objOutlk As New Outlook.Application 'Outlook
        Const olMailItem As Integer = 0
        Dim objMail As New System.Object
        Dim activestudents As String() = Nothing
        Dim toactivestudents As String = ""
        Dim currentemail As String = ""
        Try
            qry = "select studentid from tblstudent where status = 'Active' and email is not NULL"

            activestudents = Me.con.returnColumnFor(qry)

            objMail = objOutlk.CreateItem(olMailItem) 'Email item

            'Insert your "To" address...it can by dynamically populated
            For i = 0 To activestudents.Length - 1
                qry = "select (email) as Email from tblstudent where studentid='" + activestudents(i) + "'"
                currentemail = Me.con.returnSingleValueFor(qry)
                toactivestudents = toactivestudents & ";" & currentemail
            Next i
            objMail.To = toactivestudents

            'Insert your "CC" address...it can by dynamically populated
            'objMail.cc = "ooo@yyy.com" 'Enter an address here To include a carbon copy; bcc is For blind carbon copy's

            'Set up Subject Line
            objMail.subject = "Enter Subject Here..."

            'To add an attachment, use:
            'objMail.attachments.add("enter your attachment path here")
            ''otherwise, if no attachment, you can comment the objMail.attachments.add("") out with an apostrophe

            'Set up your message body
            Dim msg As String

            msg = "Enter Body Here..."
            objMail.body = msg
            'Use this To display before sending, otherwise call (use) objMail.Send to send without reviewing
            objMail.display()

            'Clean up
            objMail = Nothing
            objOutlk = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ShowStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowStudentsToolStripMenuItem.Click
        Try
            frmshowstudents.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub groupstudents_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles groupstudents.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
            Try

                qry = "select (month) as 'Month Paid' from  tblstudent t1, tblstudentaccount t2, tblpayment t3 where t1.studentid ='" + sender.CurrentCell.EditedFormattedValue().ToString() + "' and t1.studentaccid = t2.studentaccid and t2.studentaccid = t3.studentaccid and t3.schoolyear = '" + comboschoolyear.Text + "'"
                dgmonthspaid.DataSource = con.returnDataTableFor(qry)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtcritiria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                qry = "select (t.studentaccid) as 'Student Account ID', (firstname) as 'First Name', (lastname) as 'Last Name', (t1.fathername) as 'Father Name', (mobilephone) as 'Mobile Phone', (homephone) as 'Home Phone'  from tblstudent t, tblstudentaccount t1 where lastname='" + txtcritiria.Text + "' and t.studentaccid = t1.studentaccid or firstname ='" + txtcritiria.Text + "' and t.studentaccid = t1.studentaccid and t.status = 'Active'"
                con.setCurrentDataTable() = con.returnDataTableFor(qry)
                studentresult.DataSource = con.returnDataTableFor(qry)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub studentresult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentresult.DoubleClick
        Try
            Dim frmp As New frmpayments(sender.CurrentCell.EditedFormattedValue().ToString, 1)
            frmp.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub studentresult_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles studentresult.MouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim frmaccstu As New frmaccountstatement(sender.CurrentCell.EditedFormattedValue().ToString)
                frmaccstu.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmabsences.Show()
    End Sub

    Private Sub txtcritiria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcritiria.TextChanged

    End Sub
End Class
