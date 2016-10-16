Public Class frmexam
    Private qry As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmexam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qry = "select studentid, CONCAT(firstname,' ', lastname,' ', fathername) AS fullname from tblstudent t, tblstudentaccount t1 where t1.studentaccid = t.studentaccid  group by(studentid) asc"
            Form1.con.BindQueryTo(qry, "fullname", "studentid", txtstudentid)
            refreshData()
        Catch ex As Exception

        End Try
        Try
            qry = "select examofferid, concat(examname,' ', subjectcode,' ', distributor) as exam from tblexamoffer"
            Form1.con.BindQueryTo(qry, "exam", "examofferid", txtexamoffer)
            refreshData()
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub refreshData()
        BindingNavigator1.BindingSource = Nothing
        BindingSource1.DataSource = Nothing
        qry = "Select * from tblstudentexam"
        BindingSource1.DataSource = Form1.con.returnDataTableFor(qry)
        BindingNavigator1.BindingSource = BindingSource1
        Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
        DisplayData(Form1.con.returnRowFor(qry))
    End Sub
    Private Sub DisplayData(ByVal tblexam As String())
        Try
            txtstudentexamid.Text = tblexam(0)
            txtexamoffer.SelectedValue = tblexam(1)
            txtstudentid.SelectedValue = tblexam(2)
            txtexamdate.Value = tblexam(3)
            txtgrade.Text = tblexam(4)
            txtexamtime.Text = tblexam(5)
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If MsgBox("Are you sure you want to save this student for this exam?", MsgBoxStyle.YesNo, "By Private Institute") = MsgBoxResult.Yes Then
                
            Try
                qry = "select count(studentexamid) from private_institute.tblexamoffer t, private_institute.tblstudentexam t1 where t.examofferid = t1.examofferid and t1.examofferid = '" + txtexamoffer.SelectedValue.ToString + "' and t1.studentid = '" + txtstudentid.SelectedValue.ToString + "' and t1.grade >= t.base"
                If Form1.con.returnSingleValueFor(qry) > 0 Then
                    MsgBox("Selected student has already passed the selected exam", MsgBoxStyle.OkOnly, "By Private Institute")
                Else
                    qry = "insert into tblstudentexam (examofferid, studentid, examdate, grade, examtime) values ('" + txtexamoffer.SelectedValue.ToString + "', '" + txtstudentid.SelectedValue.ToString + "', '" + txtexamdate.Value.Date + "', '" + txtgrade.Text + "', '" + txtexamtime.Text + "')"
                    If Form1.con.executeNonQuery(qry) = True Then
                        MsgBox("This exam has been saved!!!")
                    Else
                        MsgBox("This exam has not been saved!!!")
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        Try
            DisplayData(Form1.con.nextRow())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddexam.Click
        Try
            txtstudentexamid.Text = "Auto Number"
            txtstudentid.Text = ""
            txtgrade.Text = ""
            txtexamtime.Text = ""
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub btnupdateexam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateexam.Click
        Try
            qry = "update tblstudentexam set  examofferid='" + txtexamoffer.SelectedValue.ToString + "', studentid='" + txtstudentid.SelectedValue.ToString + "', examdate='" + txtexamdate.Value.Date + "', grade='" + txtgrade.Text + "', examtime='" + txtexamtime.Text + "'  where studentexamid ='" + txtstudentexamid.Text + "'"
            If Form1.con.executeNonQuery(qry) = True Then
                MsgBox("The exam has been updateed.")
            Else
                MsgBox("The exam has not been updated.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btrnprintexams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrnprintexams.Click
        Dim previewexamreport As New private_institute_reports.Form2(txtsearchdate.Value.Date)
        previewexamreport.Show()

    End Sub


    Private Sub txtstudentid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentid.SelectedIndexChanged
        Try
            qry = "select (examname) as Exam, (subjectcode) as Code, (grade) as Grade from tblexamoffer t, tblstudent t1, tblstudentexam t2 where t2.studentid = t1.studentid and t.examofferid = t2.examofferid and t1.studentid = '" + txtstudentid.SelectedValue.ToString + "'"
            dgstudentexam.DataSource = Form1.con.returnDataTableFor(qry)
            dgstudentexam.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmexamoffer.Show()
    End Sub

    Private Sub txtsearchdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchdate.ValueChanged
        Try
            qry = "select  concat(firstname,' ', lastname) as Student, concat(examname, ' ', subjectcode, ' ', distributor) as Exam from tblstudentexam t, tblstudent t1, tblexamoffer t2 where t.studentid = t1.studentid and t2.examofferid = t.examofferid and examdate = '" + txtsearchdate.Value.Date + "'"
            examgrid.DataSource = Form1.con.returnDataTableFor(qry)
            examgrid.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class