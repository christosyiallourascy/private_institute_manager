<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearchbystudent
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcritiria = New System.Windows.Forms.TextBox()
        Me.studentresult = New System.Windows.Forms.DataGridView()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ttinfo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.studentresult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search By Student"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Enter Student Surname Or Name"
        '
        'txtcritiria
        '
        Me.txtcritiria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcritiria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtcritiria.Location = New System.Drawing.Point(226, 72)
        Me.txtcritiria.Name = "txtcritiria"
        Me.txtcritiria.Size = New System.Drawing.Size(203, 22)
        Me.txtcritiria.TabIndex = 50
        '
        'studentresult
        '
        Me.studentresult.AllowUserToAddRows = False
        Me.studentresult.AllowUserToDeleteRows = False
        Me.studentresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentresult.Location = New System.Drawing.Point(27, 124)
        Me.studentresult.Name = "studentresult"
        Me.studentresult.Size = New System.Drawing.Size(646, 212)
        Me.studentresult.TabIndex = 52
        Me.studentresult.Tag = "Double Click on Student Account Number for Receipt and Right Click for Account St" & _
            "atement"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnclose.Location = New System.Drawing.Point(445, 351)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(228, 37)
        Me.btnclose.TabIndex = 56
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'ttinfo
        '
        '
        'frmsearchbystudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 400)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.studentresult)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcritiria)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmsearchbystudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search By Student"
        CType(Me.studentresult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcritiria As System.Windows.Forms.TextBox
    Friend WithEvents studentresult As System.Windows.Forms.DataGridView
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ttinfo As System.Windows.Forms.ToolTip
End Class
