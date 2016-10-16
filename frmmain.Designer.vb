<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.btnaddbarnch = New System.Windows.Forms.Button()
        Me.lblrights = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbldatetimenow = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnaddnewsy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Private Institute Manager Central"
        '
        'btnaddbarnch
        '
        Me.btnaddbarnch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnaddbarnch.Location = New System.Drawing.Point(36, 81)
        Me.btnaddbarnch.Name = "btnaddbarnch"
        Me.btnaddbarnch.Size = New System.Drawing.Size(123, 57)
        Me.btnaddbarnch.TabIndex = 76
        Me.btnaddbarnch.Text = "Branches"
        Me.btnaddbarnch.UseVisualStyleBackColor = True
        '
        'lblrights
        '
        Me.lblrights.AutoSize = True
        Me.lblrights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblrights.Location = New System.Drawing.Point(284, 449)
        Me.lblrights.Name = "lblrights"
        Me.lblrights.Size = New System.Drawing.Size(61, 20)
        Me.lblrights.TabIndex = 79
        Me.lblrights.Text = "Rights"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnexit.Location = New System.Drawing.Point(624, 411)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(172, 61)
        Me.btnexit.TabIndex = 78
        Me.btnexit.Text = "Exit Program"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbldatetimenow
        '
        Me.lbldatetimenow.AutoSize = True
        Me.lbldatetimenow.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbldatetimenow.Location = New System.Drawing.Point(25, 449)
        Me.lbldatetimenow.Name = "lbldatetimenow"
        Me.lbldatetimenow.Size = New System.Drawing.Size(68, 23)
        Me.lbldatetimenow.TabIndex = 77
        Me.lbldatetimenow.Text = "Today"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(165, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 57)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Set Royalties Levels"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnaddnewsy
        '
        Me.btnaddnewsy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnaddnewsy.Location = New System.Drawing.Point(333, 81)
        Me.btnaddnewsy.Name = "btnaddnewsy"
        Me.btnaddnewsy.Size = New System.Drawing.Size(162, 57)
        Me.btnaddnewsy.TabIndex = 81
        Me.btnaddnewsy.Text = "Add New School Year"
        Me.btnaddnewsy.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 484)
        Me.Controls.Add(Me.btnaddnewsy)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblrights)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lbldatetimenow)
        Me.Controls.Add(Me.btnaddbarnch)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Private Institute Manager Central"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnaddbarnch As System.Windows.Forms.Button
    Friend WithEvents lblrights As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lbldatetimenow As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnaddnewsy As System.Windows.Forms.Button

End Class
