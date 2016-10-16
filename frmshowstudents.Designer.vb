<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshowstudents
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
        Me.dgshowstudents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnexporttoexcel = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgshowstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgshowstudents
        '
        Me.dgshowstudents.AllowUserToAddRows = False
        Me.dgshowstudents.AllowUserToDeleteRows = False
        Me.dgshowstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgshowstudents.Location = New System.Drawing.Point(14, 84)
        Me.dgshowstudents.Name = "dgshowstudents"
        Me.dgshowstudents.Size = New System.Drawing.Size(658, 302)
        Me.dgshowstudents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Show Students Active Form"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnclose.Location = New System.Drawing.Point(473, 411)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(199, 49)
        Me.btnclose.TabIndex = 58
        Me.btnclose.Text = "Close Form "
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnexporttoexcel
        '
        Me.btnexporttoexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnexporttoexcel.Location = New System.Drawing.Point(14, 411)
        Me.btnexporttoexcel.Name = "btnexporttoexcel"
        Me.btnexporttoexcel.Size = New System.Drawing.Size(199, 49)
        Me.btnexporttoexcel.TabIndex = 59
        Me.btnexporttoexcel.Text = "Export to Excel"
        Me.btnexporttoexcel.UseVisualStyleBackColor = True
        '
        'frmshowstudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 472)
        Me.Controls.Add(Me.btnexporttoexcel)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgshowstudents)
        Me.MaximizeBox = False
        Me.Name = "frmshowstudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Students"
        CType(Me.dgshowstudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgshowstudents As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnexporttoexcel As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
End Class
