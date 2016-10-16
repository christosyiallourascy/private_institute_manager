<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearchforaccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusertype = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfamilyname = New System.Windows.Forms.TextBox()
        Me.txtmobilemother = New System.Windows.Forms.TextBox()
        Me.txtmobilefather = New System.Windows.Forms.TextBox()
        Me.txtworkphone = New System.Windows.Forms.TextBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txthomephone = New System.Windows.Forms.TextBox()
        Me.txtmothername = New System.Windows.Forms.TextBox()
        Me.txtfathername = New System.Windows.Forms.TextBox()
        Me.txtstudentaccountnumber = New System.Windows.Forms.TextBox()
        Me.btnaddstudent = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnprintaccstatement = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search For An Account"
        '
        'txtusertype
        '
        Me.txtusertype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtusertype.Location = New System.Drawing.Point(219, 67)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.Size = New System.Drawing.Size(201, 20)
        Me.txtusertype.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Please Enter Phone Number"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtfamilyname)
        Me.Panel1.Controls.Add(Me.txtmobilemother)
        Me.Panel1.Controls.Add(Me.txtmobilefather)
        Me.Panel1.Controls.Add(Me.txtworkphone)
        Me.Panel1.Controls.Add(Me.txtdiscount)
        Me.Panel1.Controls.Add(Me.txthomephone)
        Me.Panel1.Controls.Add(Me.txtmothername)
        Me.Panel1.Controls.Add(Me.txtfathername)
        Me.Panel1.Location = New System.Drawing.Point(17, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 276)
        Me.Panel1.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Mother Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Discount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Home Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Work Phone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Mobile Father"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Mobile Mother"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Family Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Father Name"
        '
        'txtfamilyname
        '
        Me.txtfamilyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfamilyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtfamilyname.Location = New System.Drawing.Point(219, 218)
        Me.txtfamilyname.Name = "txtfamilyname"
        Me.txtfamilyname.Size = New System.Drawing.Size(195, 20)
        Me.txtfamilyname.TabIndex = 7
        '
        'txtmobilemother
        '
        Me.txtmobilemother.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmobilemother.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtmobilemother.Location = New System.Drawing.Point(219, 192)
        Me.txtmobilemother.Name = "txtmobilemother"
        Me.txtmobilemother.Size = New System.Drawing.Size(195, 20)
        Me.txtmobilemother.TabIndex = 6
        '
        'txtmobilefather
        '
        Me.txtmobilefather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmobilefather.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtmobilefather.Location = New System.Drawing.Point(219, 166)
        Me.txtmobilefather.Name = "txtmobilefather"
        Me.txtmobilefather.Size = New System.Drawing.Size(195, 20)
        Me.txtmobilefather.TabIndex = 5
        '
        'txtworkphone
        '
        Me.txtworkphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtworkphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtworkphone.Location = New System.Drawing.Point(218, 140)
        Me.txtworkphone.Name = "txtworkphone"
        Me.txtworkphone.Size = New System.Drawing.Size(195, 20)
        Me.txtworkphone.TabIndex = 4
        '
        'txtdiscount
        '
        Me.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(218, 88)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(195, 20)
        Me.txtdiscount.TabIndex = 3
        '
        'txthomephone
        '
        Me.txthomephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthomephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txthomephone.Location = New System.Drawing.Point(218, 114)
        Me.txthomephone.Name = "txthomephone"
        Me.txthomephone.Size = New System.Drawing.Size(195, 20)
        Me.txthomephone.TabIndex = 2
        '
        'txtmothername
        '
        Me.txtmothername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmothername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtmothername.Location = New System.Drawing.Point(219, 62)
        Me.txtmothername.Name = "txtmothername"
        Me.txtmothername.Size = New System.Drawing.Size(195, 20)
        Me.txtmothername.TabIndex = 1
        '
        'txtfathername
        '
        Me.txtfathername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfathername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtfathername.Location = New System.Drawing.Point(218, 36)
        Me.txtfathername.Name = "txtfathername"
        Me.txtfathername.Size = New System.Drawing.Size(195, 20)
        Me.txtfathername.TabIndex = 0
        '
        'txtstudentaccountnumber
        '
        Me.txtstudentaccountnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstudentaccountnumber.Location = New System.Drawing.Point(291, 41)
        Me.txtstudentaccountnumber.Name = "txtstudentaccountnumber"
        Me.txtstudentaccountnumber.Size = New System.Drawing.Size(193, 20)
        Me.txtstudentaccountnumber.TabIndex = 35
        Me.txtstudentaccountnumber.Visible = False
        '
        'btnaddstudent
        '
        Me.btnaddstudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddstudent.Enabled = False
        Me.btnaddstudent.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnaddstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnaddstudent.Location = New System.Drawing.Point(17, 375)
        Me.btnaddstudent.Name = "btnaddstudent"
        Me.btnaddstudent.Size = New System.Drawing.Size(228, 37)
        Me.btnaddstudent.TabIndex = 21
        Me.btnaddstudent.Text = "Add Student"
        Me.btnaddstudent.UseVisualStyleBackColor = False
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnpayment.Enabled = False
        Me.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnpayment.Location = New System.Drawing.Point(251, 375)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(228, 37)
        Me.btnpayment.TabIndex = 20
        Me.btnpayment.Text = "Add Payment"
        Me.btnpayment.UseVisualStyleBackColor = False
        '
        'btnprintaccstatement
        '
        Me.btnprintaccstatement.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprintaccstatement.Enabled = False
        Me.btnprintaccstatement.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnprintaccstatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnprintaccstatement.Location = New System.Drawing.Point(17, 418)
        Me.btnprintaccstatement.Name = "btnprintaccstatement"
        Me.btnprintaccstatement.Size = New System.Drawing.Size(228, 37)
        Me.btnprintaccstatement.TabIndex = 19
        Me.btnprintaccstatement.Text = "Account Statement"
        Me.btnprintaccstatement.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnclose.Location = New System.Drawing.Point(251, 418)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(228, 37)
        Me.btnclose.TabIndex = 23
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmsearchforaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 471)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtstudentaccountnumber)
        Me.Controls.Add(Me.btnaddstudent)
        Me.Controls.Add(Me.btnpayment)
        Me.Controls.Add(Me.btnprintaccstatement)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtusertype)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmsearchforaccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search For An Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtfamilyname As System.Windows.Forms.TextBox
    Friend WithEvents txtmobilemother As System.Windows.Forms.TextBox
    Friend WithEvents txtmobilefather As System.Windows.Forms.TextBox
    Friend WithEvents txtworkphone As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txthomephone As System.Windows.Forms.TextBox
    Friend WithEvents txtmothername As System.Windows.Forms.TextBox
    Friend WithEvents txtfathername As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnaddstudent As System.Windows.Forms.Button
    Friend WithEvents btnpayment As System.Windows.Forms.Button
    Friend WithEvents btnprintaccstatement As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtstudentaccountnumber As System.Windows.Forms.TextBox
End Class
