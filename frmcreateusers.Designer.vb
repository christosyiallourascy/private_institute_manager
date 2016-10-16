<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcreateusers
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.MaskedTextBox()
        Me.txtuserid = New System.Windows.Forms.MaskedTextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnupdateclass = New System.Windows.Forms.Button()
        Me.btnaddclass = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.txtmax = New System.Windows.Forms.MaskedTextBox()
        Me.txtcreate = New System.Windows.Forms.CheckBox()
        Me.txtread = New System.Windows.Forms.CheckBox()
        Me.txtupdate = New System.Windows.Forms.CheckBox()
        Me.txtdalete = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Create User Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmax)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.txtuserid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 178)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(151, 76)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(172, 20)
        Me.txtpassword.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label18.Location = New System.Drawing.Point(54, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Notes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "User ID"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtusername.Location = New System.Drawing.Point(150, 50)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(172, 20)
        Me.txtusername.TabIndex = 7
        '
        'txtuserid
        '
        Me.txtuserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuserid.Enabled = False
        Me.txtuserid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(150, 21)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(172, 20)
        Me.txtuserid.TabIndex = 3
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnsave.Location = New System.Drawing.Point(12, 286)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(149, 35)
        Me.btnsave.TabIndex = 64
        Me.btnsave.Text = "Save Record"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnclose.Location = New System.Drawing.Point(504, 286)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(156, 37)
        Me.btnclose.TabIndex = 63
        Me.btnclose.Text = "Close Form "
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnupdateclass
        '
        Me.btnupdateclass.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupdateclass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdateclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnupdateclass.Location = New System.Drawing.Point(322, 241)
        Me.btnupdateclass.Name = "btnupdateclass"
        Me.btnupdateclass.Size = New System.Drawing.Size(149, 37)
        Me.btnupdateclass.TabIndex = 62
        Me.btnupdateclass.Text = "Update Class"
        Me.btnupdateclass.UseVisualStyleBackColor = False
        '
        'btnaddclass
        '
        Me.btnaddclass.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddclass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnaddclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnaddclass.Location = New System.Drawing.Point(322, 286)
        Me.btnaddclass.Name = "btnaddclass"
        Me.btnaddclass.Size = New System.Drawing.Size(149, 37)
        Me.btnaddclass.TabIndex = 61
        Me.btnaddclass.Text = "Add New Class"
        Me.btnaddclass.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Red
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btndelete.Location = New System.Drawing.Point(166, 286)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(150, 37)
        Me.btndelete.TabIndex = 60
        Me.btndelete.Text = "Delete Record"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnprevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnprevious.Location = New System.Drawing.Point(12, 241)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(150, 37)
        Me.btnprevious.TabIndex = 59
        Me.btnprevious.Text = "Previous Record"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnnext.Location = New System.Drawing.Point(166, 241)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(150, 37)
        Me.btnnext.TabIndex = 58
        Me.btnnext.Text = "Next Record"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'txtmax
        '
        Me.txtmax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtmax.Location = New System.Drawing.Point(150, 102)
        Me.txtmax.Name = "txtmax"
        Me.txtmax.Size = New System.Drawing.Size(172, 20)
        Me.txtmax.TabIndex = 8
        '
        'txtcreate
        '
        Me.txtcreate.AutoSize = True
        Me.txtcreate.Location = New System.Drawing.Point(82, 35)
        Me.txtcreate.Name = "txtcreate"
        Me.txtcreate.Size = New System.Drawing.Size(73, 20)
        Me.txtcreate.TabIndex = 38
        Me.txtcreate.Text = "Create"
        Me.txtcreate.UseVisualStyleBackColor = True
        '
        'txtread
        '
        Me.txtread.AutoSize = True
        Me.txtread.Location = New System.Drawing.Point(82, 61)
        Me.txtread.Name = "txtread"
        Me.txtread.Size = New System.Drawing.Size(65, 20)
        Me.txtread.TabIndex = 39
        Me.txtread.Text = "Read"
        Me.txtread.UseVisualStyleBackColor = True
        '
        'txtupdate
        '
        Me.txtupdate.AutoSize = True
        Me.txtupdate.Location = New System.Drawing.Point(82, 87)
        Me.txtupdate.Name = "txtupdate"
        Me.txtupdate.Size = New System.Drawing.Size(78, 20)
        Me.txtupdate.TabIndex = 40
        Me.txtupdate.Text = "Update"
        Me.txtupdate.UseVisualStyleBackColor = True
        '
        'txtdalete
        '
        Me.txtdalete.AutoSize = True
        Me.txtdalete.Location = New System.Drawing.Point(82, 113)
        Me.txtdalete.Name = "txtdalete"
        Me.txtdalete.Size = New System.Drawing.Size(73, 20)
        Me.txtdalete.TabIndex = 41
        Me.txtdalete.Text = "Delete"
        Me.txtdalete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdalete)
        Me.GroupBox2.Controls.Add(Me.txtcreate)
        Me.GroupBox2.Controls.Add(Me.txtread)
        Me.GroupBox2.Controls.Add(Me.txtupdate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(369, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 178)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Privileges"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(504, 243)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(156, 37)
        Me.btnrefresh.TabIndex = 66
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'frmcreateusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 331)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdateclass)
        Me.Controls.Add(Me.btnaddclass)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmcreateusers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create User Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtuserid As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnupdateclass As System.Windows.Forms.Button
    Friend WithEvents btnaddclass As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents txtmax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcreate As System.Windows.Forms.CheckBox
    Friend WithEvents txtread As System.Windows.Forms.CheckBox
    Friend WithEvents txtupdate As System.Windows.Forms.CheckBox
    Friend WithEvents txtdalete As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class
