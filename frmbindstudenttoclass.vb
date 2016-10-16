Public Class frmbindstudenttoclass
    Private classID As String
    Private qry As String
    Private qryCombstudents As String
    Private qryCombclasses As String
    Private studentselection As Integer

    Public Sub New(ByVal classtID As String)
        Me.classID = classID
        InitializeComponent()
    End Sub
    Private Sub frmbindstudenttoclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            qry = "select year from tblclass group by(year) desc"
            Form1.con.BindQueryTo(qry, "year", "year", comboschoolyear)
        Catch ex As Exception

        End Try
        fillclassescombo()
        fillallavailableclesses()

        fillstudentscombo()
        lblclassmode.Text = "Students Mode"
        studentselection = 1
        Me.Text = "Bind Students to Class " & "- Students Mode"
    End Sub
    Private Sub filladultstudent()
        Me.cmbstudents.DataBindings.Clear()
        Me.cmbstudents.Text = ""
        Try
            qryCombstudents = "select adultid, CONCAT(firstname,' ', lastname,' ', middlename) AS fullname from tbladult t where t.status='Active'  group by(adultid) asc"
            Form1.con.BindQueryTo(qryCombstudents, "fullname", "adultid", cmbstudents)
            studentselection = 0
            Me.Text = "Bind Students to Class " & "- Adult Students Mode"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fillstudentscombo()
        Me.cmbstudents.DataBindings.Clear()
        Me.cmbstudents.Text = ""
        Try
            qryCombstudents = "select studentid, CONCAT(firstname,' ', lastname,' ', fathername) AS fullname from tblstudent t, tblstudentaccount t1 where t.status='Active' and t1.studentaccid = t.studentaccid  group by(studentid) asc"
            Form1.con.BindQueryTo(qryCombstudents, "fullname", "studentid", cmbstudents)
            studentselection = 1
            Me.Text = "Bind Students to Class " & "- Students Mode"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fillclassescombo()
        Try
            qry = "select classid, concat(classname,' ', room, ' ',day1,' ', time1) as class from tblclass where year = '" + comboschoolyear.Text + "'"
            Form1.con.BindQueryTo(qry, "class", "classid", cmbclasses)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub fillallavailableclesses()
        Try
            qry = "select (classid) As 'Class ID', (classname) as 'Class Name', (room) as Room, (day1) as 'Day One', (time1) as 'Time One', (time1a) as 'Time Two', (day2) as 'Day Two', (time2) as 'Time One A', (time2a) as 'Time Two B' from tblclass where year = '" + comboschoolyear.Text + "'"
            availableclasses.DataSource = Form1.con.returnDataTableFor(qry)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If studentselection.Equals(1) Then
            Try
                qry = "select count(studentid) from tblstudentclass where studentid='" + cmbstudents.SelectedValue.ToString + "' and classid='" + cmbclasses.SelectedValue.ToString + "'"
                If Form1.con.returnSingleValueFor(qry) > 0 Then
                    MsgBox("This student has already been added to this class", MsgBoxStyle.OkOnly, "By Private Institute")
                Else
                    qry = "insert into tblstudentclass (classid, studentid) values('" + cmbclasses.SelectedValue.ToString + "', '" + cmbstudents.SelectedValue.ToString + "')"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("This student has been saved to this class succesfully!!!")
                    Else
                        MsgBox("This student has not been saved!!!")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf studentselection.Equals(0) Then
            Try
                qry = "select count(adultid) from tbladultclass where adultid='" + cmbstudents.SelectedValue.ToString + "' and classid='" + cmbclasses.SelectedValue.ToString + "'"
                If Form1.con.returnSingleValueFor(qry) > 0 Then
                    MsgBox("This adult has already been added to this class", MsgBoxStyle.OkOnly, "By Private Institute")
                Else
                    qry = "INSERT INTO `private_institute`.`tbladultclass` (`classID`, `adultID`) values('" + cmbclasses.SelectedValue.ToString + "', '" + cmbstudents.SelectedValue.ToString + "')"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("This adult has been saved to this class succesfully!!!")
                    Else
                        MsgBox("This adult has not been saved!!!")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtday1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtday1.SelectedIndexChanged
        Try
            If txtday1.Text = "All" Then
                fillallavailableclesses()
            Else
                qry = "select (classid) As 'Class ID', (classname) as 'Class Name', (room) as Room, (day1) as 'Day One', (time1) as 'Time One', (time1a) as 'Time Two', (day2) as 'Day Two', (time2) as 'Time One A', (time2a) as 'Time Tw B' from tblclass where day1='" + txtday1.Text + "' and year = '" + comboschoolyear.Text + "'"
                availableclasses.DataSource = Form1.con.returnDataTableFor(qry)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub comboschoolyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboschoolyear.SelectedIndexChanged
        Try
            qry = "select classid, concat(classname,' ', room, ' ',day1,' ', time1) as class from tblclass where year = '" + comboschoolyear.Text + "'"
            Form1.con.BindQueryTo(qry, "class", "classid", cmbclasses)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If studentselection.Equals(1) Then
            Try
                If MsgBox("Are you sure you want to remove this student from this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
                    Try
                        qry = "DELETE FROM `private_institute`.`tblstudentclass` WHERE classid ='" + cmbclasses.SelectedValue.ToString + "' and studentid='" + cmbstudents.SelectedValue.ToString + "'"
                        If Form1.con.executeNonQuery(qry) = True Then
                            MsgBox("The student has been removed.")
                        Else
                            MsgBox("The student has not been removed.")
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        ElseIf studentselection.Equals(0) Then
            Try
                If MsgBox("Are you sure you want to remove this adult from this class?", MsgBoxStyle.YesNoCancel, "By Private Institute") = MsgBoxResult.Yes Then
                    Try
                        qry = "DELETE FROM `private_institute`.`tbladultclass` WHERE classid ='" + cmbclasses.SelectedValue.ToString + "' and adultid='" + cmbstudents.SelectedValue.ToString + "'"
                        If Form1.con.executeNonQuery(qry) = True Then
                            MsgBox("The adult has been removed.")
                        Else
                            MsgBox("The adult has not been removed.")
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub availableclasses_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles availableclasses.CellClick
        If studentselection.Equals(1) Then
            If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
                Try
                    qry = "select count(t.classid) from tblstudentclass t, tblclass t1 where t.classid = t1.classid and  t1.year = '" + comboschoolyear.Text + "' and t.classid = '" + sender.CurrentCell.EditedFormattedValue().ToString + "'"
                    MsgBox("This class has " + Form1.con.returnSingleValueFor(qry) + " students.")
                Catch ex As Exception

                End Try
            End If
        ElseIf studentselection.Equals(0) Then
            If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
                Try
                    qry = "select count(t.classid) from tbladultclass t, tblclass t1 where t.classid = t1.classid and  t1.year = '" + comboschoolyear.Text + "' and t.classid = '" + sender.CurrentCell.EditedFormattedValue().ToString + "'"
                    MsgBox("This class has " + Form1.con.returnSingleValueFor(qry) + " students.")
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub cmbclasses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclasses.SelectedIndexChanged
        If studentselection.Equals(1) Then
            Try
                qry = "select (t1.studentid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tblstudentclass t, tblstudent t1, tblstudentaccount t2 where classid ='" + cmbclasses.SelectedValue.ToString + "' and t1.studentid = t.studentid and t1.studentaccid = t2.studentaccid"
                selectedgroup.DataSource = Form1.con.returnDataTableFor(qry)
                selectedgroup.AutoResizeColumns()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf studentselection.Equals(0) Then
            Try
                qry = "select (t1.adultid) as 'Student ID', (firstname) as 'First Name', (lastname) as 'Last Name', (homephone) as 'Home Phone' from tbladultclass t, tbladult t1 where classid ='" + cmbclasses.SelectedValue.ToString + "' and t1.adultid = t.adultid"
                selectedgroup.DataSource = Form1.con.returnDataTableFor(qry)
                selectedgroup.AutoResizeColumns()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub adultorstudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultorstudents.Click
        If studentselection.Equals(1) Then
            filladultstudent()
            lblclassmode.Text = "Adult Students Mode"
        ElseIf studentselection.Equals(0) Then
            fillstudentscombo()
            lblclassmode.Text = "Students Mode"
        End If
    End Sub

    Private Sub availableclasses_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles availableclasses.CellContentClick

    End Sub
End Class