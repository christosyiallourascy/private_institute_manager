Imports Outlook = Microsoft.Office.Interop.Outlook
Public Class frmstudent
    Private studentaccID As String
    Private qry As String
    Private qryCombo As String

    Public Sub New(ByVal studentaccID As String)
        Me.studentaccID = studentaccID
        InitializeComponent()
    End Sub
    Private Sub frmstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            refreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub refreshData()
        qry = "select count(studentid) from private_institute.tblstudent"
        lblnumofrecords.Text = "Number Of Records: " & Form1.con.returnSingleValueFor(qry)
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblstudent"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tblstudent As String())

        Try
            txtstudentID.Text = tblstudent(0)
            txtstudentaccountnumber.Text = tblstudent(1)
            txttitle.Text = tblstudent(2)
            txtfirstname.Text = tblstudent(3)
            txtlastname.Text = tblstudent(4)
            txtsex.Text = tblstudent(5)
            txtmiddlename.Text = tblstudent(6)
            txtmobilephone.Text = tblstudent(7)
            txtbirthdate.Text = tblstudent(8)
            txtnationality.Text = tblstudent(9)
            txtemail.Text = tblstudent(10)
            txtgradeatschool.Text = tblstudent(11)
            txtentereddate.Text = tblstudent(12)
            txtage.Text = tblstudent(13)
            txtstatus.Text = tblstudent(14)
            txtprimaryschool.Text = tblstudent(15)
            txtsecondaryschool.Text = tblstudent(16)
            txtlyciumschool.Text = tblstudent(17)
            txtsclass.Text = tblstudent(18)
            txtusername.Text = tblstudent(19)
            txtpassword.Text = tblstudent(20)
            txtidnumber.Text = tblstudent(21)
            txtdateissued.Text = tblstudent(22)
            txtidexams.Text = tblstudent(23)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowStudentClasses()
        Try
            qry = "SELECT (classname) as 'Class Name', (year) as 'School Year', (day1) as 'Day One', (time1) as 'Time One A', (time1a) as 'Time Two A', (day2) as 'Day Two', (time2) as 'Time One B', (time2a) as 'Time Two B'  FROM tblclass t, tblstudentclass t1  where t1.studentID='" + txtstudentID.Text + "' and t.classid = t1.classid"
            studentclasses.DataSource = Form1.con.returnDataTableFor(qry)
            studentclasses.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
            ShowStudentClasses()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.previousRow())
            ShowStudentClasses()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub ClearFields()

        txtage.Text = ""
        txtbirthdate.Text = ""

        txtdateissued.Text = ""
        txtemail.Text = ""
        txtentereddate.Text = ""
        txtfirstname.Text = ""
        txtgradeatschool.Text = ""
        txtidexams.Text = ""
        txtidnumber.Text = ""
        txtlastname.Text = ""
        txtlyciumschool.Text = ""
        txtmiddlename.Text = ""
        txtmobilephone.Text = ""
        txtnationality.Text = ""
        txtpassword.Text = ""
        txtprimaryschool.Text = ""
        txtsclass.Text = ""
        txtsecondaryschool.Text = ""
        txtsex.Text = ""
        txtstatus.Text = ""
        txtstudentaccountnumber.Text = Me.studentaccID
        txtstudentID.Text = "Auto Number"
        txttitle.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub btnaddstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstudent.Click
        If MsgBox("Are you sure that you know a valid account number?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            ClearFields()
        End If
    End Sub

    Private Sub btnstudentaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentaccount.Click
        Me.Close()
        frmstudentaccount.Show()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNoCancel, "By Institute Manager") = MsgBoxResult.Yes Then
            Try
                qry = "DELETE FROM tblstudent WHERE studentID='" + txtstudentID.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The record has been deleted.")
                Else
                    MsgBox("The Record has not been deleted.")
                End If
                refreshData()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this record?", MsgBoxStyle.YesNoCancel, "By Private Institue") = MsgBoxResult.Yes Then
            Try
                qry = "insert into tblstudent (studentaccID, title, firstname, lastname, sex, middlename, mobilephone, birthdate, nationality, email, gradeatschool, entereddate, age, status, primaryschool, secondaryschool, lyciumschool, sclass, username, password, idnumber, dateissued, idexams) values ('" + txtstudentaccountnumber.Text + "', '" + txttitle.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtsex.Text + "', '" + txtmiddlename.Text + "', '" + txtmobilephone.Text + "', '" + txtbirthdate.Text + "', '" + txtnationality.Text + "', '" + txtemail.Text + "', '" + txtgradeatschool.Text + "', '" + txtentereddate.Text + "', '" + txtage.Text + "', '" + txtstatus.Text + "', '" + txtprimaryschool.Text + "', '" + txtsecondaryschool.Text + "', '" + txtlyciumschool.Text + "', '" + txtsclass.Text + "', '" + txtusername.Text + "', '" + txtpassword.Text + "', '" + txtidnumber.Text + "', '" + txtdateissued.Text + "', '" + txtidexams.Text + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The record has been saved.")
                Else
                    MsgBox("The Record has not been saved.")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    'Private Sub txtcritiria1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcritiria1.KeyDown
    'Dim count As Integer
    'If e.KeyCode = Keys.Enter Then
    'Try
    'qry = "select count(firstname) from tblstudent where firstname='" + txtcritiria.Text + "' and lastname='" + txtcritiria1.Text + "'"
    'count = Form1.con.returnSingleValueFor(qry)
    'If count <= 0 Then
    'MsgBox("There is not student with this first and last name!!!")
    'Else
    'qry = "select * from tblstudent where firstname='" + txtcritiria.Text + "' and lastname='" + txtcritiria1.Text + "'"
    'Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
    'DisplayData(Form1.con.nextRow())
    'DisplayData(Form1.con.previousRow())
    'End If
    'Catch ex As Exception

    'End Try
    'End If
    'End Sub


    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Try
            refreshData()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnupdateaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateaccount.Click
        If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNoCancel, "By Private Institue") = MsgBoxResult.Yes Then
            Try
                qry = "UPDATE `tblstudent` SET `studentaccID` = '" + txtstudentaccountnumber.Text + "', `title` = '" + txttitle.Text + "', `firstname` = '" + txtfirstname.Text + "', `lastname` = '" + txtlastname.Text + "', `sex` = '" + txtsex.Text + "', `middlename` = '" + txtmiddlename.Text + "', `mobilephone` = '" + txtmobilephone.Text + "', `birthdate` = '" + txtbirthdate.Text + "', `nationality` = '" + txtnationality.Text + "', `email` = '" + txtemail.Text + "', `gradeatschool` = '" + txtgradeatschool.Text + "', `entereddate` = '" + txtentereddate.Text + "', `age` = '" + txtage.Text + "', `status` = '" + txtstatus.Text + "', `primaryschool` = '" + txtprimaryschool.Text + "', `secondaryschool` = '" + txtsecondaryschool.Text + "', `lyciumschool` = '" + txtlyciumschool.Text + "', `sclass` = '" + txtsclass.Text + "', `username` = '" + txtusername.Text + "', `password` = '" + txtpassword.Text + "', `idnumber` = '" + txtidnumber.Text + "', `dateissued` = '" + txtdateissued.Text + "', `idexams` = '" + txtidexams.Text + "' WHERE studentid='" + txtstudentID.Text + "'"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("The record has been updated.")
                Else
                    MsgBox("The Record has not been updated.")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnsendemail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsendemail.Click
        Dim objOutlk As New Outlook.Application 'Outlook
        Const olMailItem As Integer = 0
        Dim objMail As New System.Object

        objMail = objOutlk.CreateItem(olMailItem) 'Email item

        'Insert your "To" address...it can by dynamically populated
        objMail.To = txtemail.Text

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
    End Sub

    Private Sub btnstudentsaccountstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstudentsaccountstatus.Click
        Dim currentSchoolyear As String() = Nothing
        Dim studentsingroups As String() = Nothing
        Dim studentsnotingroups As String() = Nothing
        Dim studentstodiactivate As String = ""
        Dim accountstodiactivate As String = ""
        Try
            qry = "select year from tblclass group by(year) desc limit 1"
            currentSchoolyear = Form1.con.returnRowFor(qry)
            lblcheckmessages.Text = "Current School Year " & currentSchoolyear(0)
            qry = "select t.studentid from private_institute.tblstudent t, private_institute.tblclass t1, private_institute.tblstudentclass t3 where t.studentid <> t3.studentid and t3.classid = t1.classid and t1.year = '" + currentSchoolyear(0) + "'"
            studentsnotingroups = Form1.con.returnColumnFor(qry)
            lblcheckmessages.Text = "Correcting Status..."
            For i = 0 To studentsnotingroups.Length - 1
                lblcheckmessages.Text = "Correcting Status..."
                qry = "select count(t.studentid) from private_institute.tblstudent t where t.studentid = '" + studentsnotingroups(i) + "' and t.status = 'Inactive'"
                If Form1.con.returnSingleValueFor(qry) > 0 Then
                    qry = "UPDATE `private_institute`.`tblstudent` SET `status` = 'Inactive' WHERE studentid='" + studentsnotingroups(i) + "'"
                    Form1.con.executeNonQuery(qry)
                End If
            Next i
            lblcheckmessages.Text = "Students status have been corrected"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Courier New", 12, FontStyle.Regular)
        Dim myfont1 As New Font("Courier New", 14, FontStyle.Bold)
        Dim x1, x2, x3, x4, y, FontHeight As Integer
        Dim branchinforow As String() = Nothing
        Dim studentaccrow As String() = Nothing
        x1 = 50
        x2 = 280
        x3 = 50
        x4 = 50
        y = 50
        FontHeight = myfont.GetHeight(e.Graphics)
        Try
            qry = "select * from tblbranchinfo"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            branchinforow = Form1.con.nextRow()
            branchinforow = Form1.con.previousRow()
            e.Graphics.DrawLine(Pens.Black, 45, 45, 800, 45)
            e.Graphics.DrawImage(Image.FromFile("logo.jpg"), x1, y)
            'branch information
            e.Graphics.DrawString(branchinforow(5), myfont1, Brushes.Black, x2 + 155, y)
            y = y + FontHeight
            e.Graphics.DrawString("Branch", myfont, Brushes.Black, x2 + 40, y)
            e.Graphics.DrawString(branchinforow(1), myfont, Brushes.Black, x2 + 150, y)
            y = y + FontHeight
            e.Graphics.DrawString("WebSite", myfont, Brushes.Black, x2 + 40, y)
            e.Graphics.DrawString(branchinforow(4), myfont, Brushes.Black, x2 + 150, y)
            y = y + FontHeight
            e.Graphics.DrawString("VAT Number", myfont, Brushes.Black, x2 + 40, y)
            e.Graphics.DrawString(branchinforow(2), myfont, Brushes.Black, x2 + 150, y)
            y = y + FontHeight
            e.Graphics.DrawString("Telephone", myfont, Brushes.Black, x2 + 40, y)
            e.Graphics.DrawString(branchinforow(6), myfont, Brushes.Black, x2 + 150, y)
            y = y + FontHeight + 20
            e.Graphics.DrawLine(Pens.Black, 45, y - 10, 800, y - 10)


            'student registration form
            qry = "select t.firstname, t.lastname, t1.fathername, t1.mothername, t.birthdate, t.sclass, t1.address, t1.area, t1.city, t1.fprofession, t1.mprofession, t.age, t.mobilephone, t1.mobilefather, t1.mobilemother, t1.homephone from private_institute.tblstudent t, private_institute.tblstudentaccount t1 where t1.studentaccid = t.studentaccid and t.studentid='" + txtstudentID.Text + "'"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            studentaccrow = Form1.con.nextRow()
            studentaccrow = Form1.con.previousRow()

            e.Graphics.DrawString("Registration Form", myfont1, Brushes.Black, x1 + 500, y)
            y = y + FontHeight + 15
            e.Graphics.DrawString("Student Details", myfont1, Brushes.Black, x1, y)
            y = y + FontHeight
            y = y + FontHeight
            e.Graphics.DrawString("First Name: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(0), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Last Name: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(1), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Birthdate: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(4), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Age: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(11), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Student's Mobile: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(12), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Family Details", myfont1, Brushes.Black, x1, y)
            y = y + FontHeight
            y = y + FontHeight
            e.Graphics.DrawString("Father Name: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(2), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Mother Name: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(3), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Father Profession: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(9), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Mother Profession: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(10), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Contuct Information: ", myfont1, Brushes.Black, x1, y)
            y = y + FontHeight
            y = y + FontHeight
            e.Graphics.DrawString("Home Phone: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(15), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Father's Mobile: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(13), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Mother's Mobile: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(14), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Address: ", myfont1, Brushes.Black, x1, y)
            y = y + FontHeight
            y = y + FontHeight
            e.Graphics.DrawString("City: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(8), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Area: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(7), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
            e.Graphics.DrawString("Address: ", myfont, Brushes.Black, x1, y)
            e.Graphics.DrawString(studentaccrow(6), myfont, Brushes.Black, x2 - 30, y)
            y = y + FontHeight
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class