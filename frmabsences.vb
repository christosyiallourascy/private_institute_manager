Public Class frmabsences
    Private qry As String
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()

    End Sub
    Private Sub btnaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtlessonid.Text = ""
        'txtstudentid.Text = ""
        'chabsence.Checked = False
    End Sub

    Private Sub frmabsences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            qry = "select lessonid, lessondate, t.classid, concat(t.classid,' ', classname,' ', room, ' ',day1,' ', time1,' ', lessondate) as class from private_institute.tblclass t, private_institute.tbllesson t1 where t.classid = t1.classid order by (lessonid) desc"
            Form1.con.BindQueryTo(qry, "class", "lessonid", txtlessonid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtlessonid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlessonid.SelectedIndexChanged
        Dim cid As String = Nothing
        Dim id As String() = Nothing
        Dim studentlist As String() = Nothing
        Dim lblfullname As Windows.Forms.Label
        Dim lblstudentid As Windows.Forms.Label
        Dim chckpresent As Windows.Forms.CheckBox

        Dim x, y As Integer
        x = 30
        y = 30
        Try
            cid = txtlessonid.Text
            id = cid.Split(New Char() {" "c})
            qry = "select t.studentid from tblstudent t, tblstudentaccount t1, tblclass t2, tblstudentclass t3 where t1.studentaccid = t.studentaccid and t.status = 'Active' and t3.studentid = t.studentid and t3.classid = t2.classid and t3.classid = '" + Trim(id(0)) + "' group by(studentid) asc"
            'Form1.con.BindQueryTo(qry, "fullname", "t.studentid", txtstudentid)
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            studentlist = Form1.con.returnColumnFor(qry)
            For i = 0 To studentlist.Length - 1
                If lblstudentid Is Nothing Then
                    Me.groupinfo.Controls.Clear()
                End If
            Next i
            For i = 0 To studentlist.Length - 1
                Dim onestudent As String() = Nothing
                qry = "select t.studentid, CONCAT(firstname,' ', lastname,' ', fathername) AS fullname from tblstudent t, tblstudentaccount t1, tblclass t2, tblstudentclass t3 where t1.studentaccid = t.studentaccid and t.status = 'Active' and t3.studentid = t.studentid and t.studentid = '" + studentlist(i) + "' and t3.classid = t2.classid and t3.classid = '" + Trim(id(0)) + "' group by(studentid) asc"
                Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
                onestudent = Form1.con.nextRow()
                onestudent = Form1.con.previousRow()
                lblstudentid = New System.Windows.Forms.Label()
                lblstudentid.Location = New System.Drawing.Point(x, y)
                lblstudentid.Name = "txtstudentid" & i
                lblstudentid.Text = onestudent(0)
                lblstudentid.Width = 30
                Me.groupinfo.Controls.Add(lblstudentid)
                lblfullname = New System.Windows.Forms.Label()
                lblfullname.Location = New System.Drawing.Point(x + lblstudentid.Width, y)
                lblfullname.Name = "lblfullname" & i
                lblfullname.Text = onestudent(1)
                lblfullname.Visible = True
                lblfullname.Width = 200
                Me.groupinfo.Controls.Add(lblfullname)
                chckpresent = New System.Windows.Forms.CheckBox()
                chckpresent.Location = New System.Drawing.Point(x + lblfullname.Width + lblstudentid.Width + 50, y)
                chckpresent.Name = "chckid" & i
                chckpresent.CheckState = CheckState.Unchecked
                Me.groupinfo.Controls.Add(chckpresent)
                y = y + 30
            Next i

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cid As String = Nothing
        Dim id As String() = Nothing
        Dim studentlist As String() = Nothing


        Try

            cid = txtlessonid.Text
            id = cid.Split(New Char() {" "c})
            qry = "select t.studentid from tblstudent t, tblstudentaccount t1, tblclass t2, tblstudentclass t3 where t1.studentaccid = t.studentaccid and t.status = 'Active' and t3.studentid = t.studentid and t3.classid = t2.classid and t3.classid = '" + Trim(id(0)) + "' group by(studentid) asc"
            Form1.con.setCurrentDataTable() = Form1.con.returnDataTableFor(qry)
            studentlist = Form1.con.returnColumnFor(qry)
            For i = 0 To studentlist.Length - 1
                Dim ch As System.Windows.Forms.CheckBox
                ch = FindControl(Me.groupinfo, "chckid" & i)
                qry = "insert into tblabsences (studentid, lessonid, absent) values ('" + FindControl(Me.groupinfo, "txtstudentid" & i).Text + "', '" + txtlessonid.SelectedValue.ToString + "', '" + ch.CheckState.ToString + "')"
                If Form1.con.executeNonQuery(qry) = True Then
                    MsgBox("This absent has been saved!!!")
                Else
                    MsgBox("This absent has not been saved!!!")
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Function FindControl(ByVal parent As Control, ByVal ident As String) As Control
        Dim n As Integer
        Dim tmpctrl As Control
        Dim tmpctrl2 As Control
        For n = 0 To parent.Controls.Count - 1
            tmpctrl = parent.Controls(n)
            If tmpctrl.Name = ident Then
                Return parent.Controls(n)
            ElseIf tmpctrl.Controls.Count > 0 Then
                tmpctrl2 = FindControl(tmpctrl, ident)
                If Not IsNothing(tmpctrl2) Then
                    Return tmpctrl2
                End If
            End If
        Next
        ' Not found
        Return Nothing
    End Function

    Private Sub btnupdateclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateclass.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class