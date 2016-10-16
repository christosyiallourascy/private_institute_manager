<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdisplaystudentsforthisbranch
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
        Me.dgstudentsbybranch = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btncalculateroyalties = New System.Windows.Forms.Button()
        Me.cmbsy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbmonth = New System.Windows.Forms.ComboBox()
        CType(Me.dgstudentsbybranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgstudentsbybranch
        '
        Me.dgstudentsbybranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstudentsbybranch.Location = New System.Drawing.Point(12, 51)
        Me.dgstudentsbybranch.Name = "dgstudentsbybranch"
        Me.dgstudentsbybranch.Size = New System.Drawing.Size(881, 382)
        Me.dgstudentsbybranch.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button1.Location = New System.Drawing.Point(694, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Blue
        Me.lbltitle.Location = New System.Drawing.Point(12, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(210, 35)
        Me.lbltitle.TabIndex = 3
        Me.lbltitle.Text = "Display Students"
        '
        'btncalculateroyalties
        '
        Me.btncalculateroyalties.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btncalculateroyalties.Location = New System.Drawing.Point(371, 448)
        Me.btncalculateroyalties.Name = "btncalculateroyalties"
        Me.btncalculateroyalties.Size = New System.Drawing.Size(120, 54)
        Me.btncalculateroyalties.TabIndex = 4
        Me.btncalculateroyalties.Text = "Calculate Royalties"
        Me.btncalculateroyalties.UseVisualStyleBackColor = True
        '
        'cmbsy
        '
        Me.cmbsy.FormattingEnabled = True
        Me.cmbsy.Location = New System.Drawing.Point(177, 448)
        Me.cmbsy.Name = "cmbsy"
        Me.cmbsy.Size = New System.Drawing.Size(165, 21)
        Me.cmbsy.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select School Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Month"
        '
        'cmbmonth
        '
        Me.cmbmonth.FormattingEnabled = True
        Me.cmbmonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbmonth.Location = New System.Drawing.Point(177, 481)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Size = New System.Drawing.Size(165, 21)
        Me.cmbmonth.TabIndex = 7
        '
        'frmdisplaystudentsforthisbranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 516)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbmonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbsy)
        Me.Controls.Add(Me.btncalculateroyalties)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgstudentsbybranch)
        Me.MaximizeBox = False
        Me.Name = "frmdisplaystudentsforthisbranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispaly Students"
        CType(Me.dgstudentsbybranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgstudentsbybranch As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btncalculateroyalties As System.Windows.Forms.Button
    Friend WithEvents cmbsy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbmonth As System.Windows.Forms.ComboBox
End Class
