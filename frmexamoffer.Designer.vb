<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexamoffer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgexamofferlist = New System.Windows.Forms.DataGridView()
        Me.btnupdateexamoffer = New System.Windows.Forms.Button()
        Me.btnaddexamoffer = New System.Windows.Forms.Button()
        Me.btnsaveexamoffer = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcompany = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtexamcode = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtexname = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtexamofferid = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtpass = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgexamofferlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "List of exam offer"
        '
        'dgexamofferlist
        '
        Me.dgexamofferlist.AllowUserToAddRows = False
        Me.dgexamofferlist.AllowUserToDeleteRows = False
        Me.dgexamofferlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexamofferlist.Location = New System.Drawing.Point(16, 242)
        Me.dgexamofferlist.Name = "dgexamofferlist"
        Me.dgexamofferlist.Size = New System.Drawing.Size(645, 231)
        Me.dgexamofferlist.TabIndex = 73
        '
        'btnupdateexamoffer
        '
        Me.btnupdateexamoffer.BackColor = System.Drawing.Color.Green
        Me.btnupdateexamoffer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdateexamoffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnupdateexamoffer.Location = New System.Drawing.Point(524, 29)
        Me.btnupdateexamoffer.Name = "btnupdateexamoffer"
        Me.btnupdateexamoffer.Size = New System.Drawing.Size(111, 82)
        Me.btnupdateexamoffer.TabIndex = 72
        Me.btnupdateexamoffer.Text = "Update Record"
        Me.btnupdateexamoffer.UseVisualStyleBackColor = False
        '
        'btnaddexamoffer
        '
        Me.btnaddexamoffer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddexamoffer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnaddexamoffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnaddexamoffer.Location = New System.Drawing.Point(368, 31)
        Me.btnaddexamoffer.Name = "btnaddexamoffer"
        Me.btnaddexamoffer.Size = New System.Drawing.Size(150, 37)
        Me.btnaddexamoffer.TabIndex = 71
        Me.btnaddexamoffer.Text = "Add New Exam"
        Me.btnaddexamoffer.UseVisualStyleBackColor = False
        '
        'btnsaveexamoffer
        '
        Me.btnsaveexamoffer.BackColor = System.Drawing.Color.Green
        Me.btnsaveexamoffer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsaveexamoffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnsaveexamoffer.Location = New System.Drawing.Point(368, 74)
        Me.btnsaveexamoffer.Name = "btnsaveexamoffer"
        Me.btnsaveexamoffer.Size = New System.Drawing.Size(150, 37)
        Me.btnsaveexamoffer.TabIndex = 70
        Me.btnsaveexamoffer.Text = "Save Record"
        Me.btnsaveexamoffer.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Distributor"
        '
        'txtcompany
        '
        Me.txtcompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcompany.Location = New System.Drawing.Point(99, 109)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(254, 22)
        Me.txtcompany.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Exam Code"
        '
        'txtexamcode
        '
        Me.txtexamcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtexamcode.Location = New System.Drawing.Point(99, 81)
        Me.txtexamcode.Name = "txtexamcode"
        Me.txtexamcode.Size = New System.Drawing.Size(254, 22)
        Me.txtexamcode.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Exam Name"
        '
        'txtexname
        '
        Me.txtexname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtexname.Location = New System.Drawing.Point(99, 53)
        Me.txtexname.Name = "txtexname"
        Me.txtexname.Size = New System.Drawing.Size(254, 22)
        Me.txtexname.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Exam offer ID"
        '
        'txtexamofferid
        '
        Me.txtexamofferid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtexamofferid.Enabled = False
        Me.txtexamofferid.Location = New System.Drawing.Point(99, 25)
        Me.txtexamofferid.Name = "txtexamofferid"
        Me.txtexamofferid.Size = New System.Drawing.Size(254, 22)
        Me.txtexamofferid.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 35)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Exams Offer Form"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button1.Location = New System.Drawing.Point(511, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 37)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnupdateexamoffer)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtexamcode)
        Me.GroupBox1.Controls.Add(Me.txtexname)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btnaddexamoffer)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnsaveexamoffer)
        Me.GroupBox1.Controls.Add(Me.txtcompany)
        Me.GroupBox1.Controls.Add(Me.txtexamofferid)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 176)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam information"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Location = New System.Drawing.Point(99, 137)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(254, 22)
        Me.txtpass.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Base"
        '
        'frmexamoffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgexamofferlist)
        Me.MaximizeBox = False
        Me.Name = "frmexamoffer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Offer Form"
        CType(Me.dgexamofferlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgexamofferlist As System.Windows.Forms.DataGridView
    Friend WithEvents btnupdateexamoffer As System.Windows.Forms.Button
    Friend WithEvents btnaddexamoffer As System.Windows.Forms.Button
    Friend WithEvents btnsaveexamoffer As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcompany As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtexamcode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtexname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtexamofferid As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
