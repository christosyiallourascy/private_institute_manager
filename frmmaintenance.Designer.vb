<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmaintenance
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblconnmessage = New System.Windows.Forms.Label()
        Me.btnenrollworkstation = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_mac_address = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblnumofrecords = New System.Windows.Forms.Label()
        Me.lblnumoftables = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tablelist = New System.Windows.Forms.ListBox()
        Me.fd = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button1.Location = New System.Drawing.Point(383, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Label1.Text = "Maintenance Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblconnmessage)
        Me.GroupBox1.Controls.Add(Me.btnenrollworkstation)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_mac_address)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(344, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 267)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'lblconnmessage
        '
        Me.lblconnmessage.AutoSize = True
        Me.lblconnmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblconnmessage.ForeColor = System.Drawing.Color.Lime
        Me.lblconnmessage.Location = New System.Drawing.Point(6, 235)
        Me.lblconnmessage.Name = "lblconnmessage"
        Me.lblconnmessage.Size = New System.Drawing.Size(71, 13)
        Me.lblconnmessage.TabIndex = 72
        Me.lblconnmessage.Text = "Connection"
        Me.lblconnmessage.Visible = False
        '
        'btnenrollworkstation
        '
        Me.btnenrollworkstation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnenrollworkstation.Location = New System.Drawing.Point(7, 170)
        Me.btnenrollworkstation.Name = "btnenrollworkstation"
        Me.btnenrollworkstation.Size = New System.Drawing.Size(167, 53)
        Me.btnenrollworkstation.TabIndex = 71
        Me.btnenrollworkstation.Text = "Enroll Workstation"
        Me.btnenrollworkstation.UseVisualStyleBackColor = True
        Me.btnenrollworkstation.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "PC MAC Address:"
        '
        'lbl_mac_address
        '
        Me.lbl_mac_address.AutoSize = True
        Me.lbl_mac_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_mac_address.ForeColor = System.Drawing.Color.Lime
        Me.lbl_mac_address.Location = New System.Drawing.Point(6, 145)
        Me.lbl_mac_address.Name = "lbl_mac_address"
        Me.lbl_mac_address.Size = New System.Drawing.Size(85, 13)
        Me.lbl_mac_address.TabIndex = 69
        Me.lbl_mac_address.Text = "MAC_Address"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 37)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Restore Database"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "BackUp Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblnumofrecords)
        Me.GroupBox2.Controls.Add(Me.lblnumoftables)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tablelist)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 267)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table List"
        '
        'lblnumofrecords
        '
        Me.lblnumofrecords.AutoSize = True
        Me.lblnumofrecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblnumofrecords.Location = New System.Drawing.Point(164, 47)
        Me.lblnumofrecords.Name = "lblnumofrecords"
        Me.lblnumofrecords.Size = New System.Drawing.Size(118, 13)
        Me.lblnumofrecords.TabIndex = 8
        Me.lblnumofrecords.Text = "Number Of Records"
        '
        'lblnumoftables
        '
        Me.lblnumoftables.AutoSize = True
        Me.lblnumoftables.Location = New System.Drawing.Point(14, 235)
        Me.lblnumoftables.Name = "lblnumoftables"
        Me.lblnumoftables.Size = New System.Drawing.Size(93, 13)
        Me.lblnumoftables.TabIndex = 2
        Me.lblnumoftables.Text = "Number Of Tables"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "List Of Tables"
        '
        'tablelist
        '
        Me.tablelist.FormattingEnabled = True
        Me.tablelist.Location = New System.Drawing.Point(17, 46)
        Me.tablelist.Name = "tablelist"
        Me.tablelist.Size = New System.Drawing.Size(141, 186)
        Me.tablelist.TabIndex = 6
        '
        'fd
        '
        Me.fd.FileName = "OpenFileDialog1"
        '
        'frmmaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 386)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "frmmaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tablelist As System.Windows.Forms.ListBox
    Friend WithEvents lblnumoftables As System.Windows.Forms.Label
    Friend WithEvents fd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblnumofrecords As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_mac_address As System.Windows.Forms.Label
    Friend WithEvents lblconnmessage As System.Windows.Forms.Label
    Friend WithEvents btnenrollworkstation As System.Windows.Forms.Button
End Class
