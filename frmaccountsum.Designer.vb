<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaccountsum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaccountsum))
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.enddate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbmonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboschoolyear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnshowsummall = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtresult = New System.Windows.Forms.MaskedTextBox()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.dgfilteredpayments = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnallbalance = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrnum1 = New System.Windows.Forms.TextBox()
        Me.txtrnum2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgfilteredpayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'startdate
        '
        Me.startdate.Location = New System.Drawing.Point(25, 101)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(254, 20)
        Me.startdate.TabIndex = 0
        '
        'enddate
        '
        Me.enddate.Location = New System.Drawing.Point(25, 165)
        Me.enddate.Name = "enddate"
        Me.enddate.Size = New System.Drawing.Size(254, 20)
        Me.enddate.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Starting Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Ending Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(13, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Show Summary"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(703, 619)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 32)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(13, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 32)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Show Summary"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbmonth
        '
        Me.cmbmonth.FormattingEnabled = True
        Me.cmbmonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbmonth.Location = New System.Drawing.Point(13, 26)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Size = New System.Drawing.Size(86, 21)
        Me.cmbmonth.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Select Month"
        '
        'comboschoolyear
        '
        Me.comboschoolyear.FormattingEnabled = True
        Me.comboschoolyear.Location = New System.Drawing.Point(13, 73)
        Me.comboschoolyear.Name = "comboschoolyear"
        Me.comboschoolyear.Size = New System.Drawing.Size(128, 21)
        Me.comboschoolyear.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "School Year"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnshowsummall)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 191)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'btnshowsummall
        '
        Me.btnshowsummall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnshowsummall.Location = New System.Drawing.Point(147, 143)
        Me.btnshowsummall.Name = "btnshowsummall"
        Me.btnshowsummall.Size = New System.Drawing.Size(128, 32)
        Me.btnshowsummall.TabIndex = 33
        Me.btnshowsummall.Text = "Show Summary All"
        Me.btnshowsummall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.comboschoolyear)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbmonth)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 161)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(129, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 32)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "Pay Selected Month"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtresult)
        Me.GroupBox3.Controls.Add(Me.lblresult)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 565)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 75)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(9, 44)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(205, 20)
        Me.txtresult.TabIndex = 32
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblresult.Location = New System.Drawing.Point(6, 16)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(43, 13)
        Me.lblresult.TabIndex = 31
        Me.lblresult.Text = "Result"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Blue
        Me.lbltitle.Location = New System.Drawing.Point(12, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(193, 35)
        Me.lbltitle.TabIndex = 84
        Me.lbltitle.Text = "Payment Totals"
        '
        'dgfilteredpayments
        '
        Me.dgfilteredpayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfilteredpayments.Location = New System.Drawing.Point(308, 47)
        Me.dgfilteredpayments.Name = "dgfilteredpayments"
        Me.dgfilteredpayments.Size = New System.Drawing.Size(561, 567)
        Me.dgfilteredpayments.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(309, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "List Of Filtered Payments"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button5.Location = New System.Drawing.Point(308, 619)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 32)
        Me.Button5.TabIndex = 87
        Me.Button5.Text = "Adult / Students"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'btnallbalance
        '
        Me.btnallbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnallbalance.Location = New System.Drawing.Point(495, 620)
        Me.btnallbalance.Name = "btnallbalance"
        Me.btnallbalance.Size = New System.Drawing.Size(181, 32)
        Me.btnallbalance.TabIndex = 88
        Me.btnallbalance.Text = "All Students Balance"
        Me.btnallbalance.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(117, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 32)
        Me.Button6.TabIndex = 88
        Me.Button6.Text = "Not pay selected month"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.txtrnum2)
        Me.GroupBox4.Controls.Add(Me.txtrnum1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 159)
        Me.GroupBox4.TabIndex = 89
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Starting Receipt Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ending Receipt Number"
        '
        'txtrnum1
        '
        Me.txtrnum1.Location = New System.Drawing.Point(16, 38)
        Me.txtrnum1.Name = "txtrnum1"
        Me.txtrnum1.Size = New System.Drawing.Size(114, 20)
        Me.txtrnum1.TabIndex = 33
        '
        'txtrnum2
        '
        Me.txtrnum2.Location = New System.Drawing.Point(16, 86)
        Me.txtrnum2.Name = "txtrnum2"
        Me.txtrnum2.Size = New System.Drawing.Size(114, 20)
        Me.txtrnum2.TabIndex = 34
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button7.Location = New System.Drawing.Point(13, 112)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 32)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Show Receipts"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(139, 112)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 32)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "Export to Excel"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmaccountsum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 679)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnallbalance)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgfilteredpayments)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.enddate)
        Me.Controls.Add(Me.startdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmaccountsum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payments Summary - Students mode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgfilteredpayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents enddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboschoolyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents txtresult As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents dgfilteredpayments As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnshowsummall As System.Windows.Forms.Button
    Friend WithEvents btnallbalance As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrnum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtrnum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
End Class
