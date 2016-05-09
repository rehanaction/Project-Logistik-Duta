<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.btnSuspend = New System.Windows.Forms.Button()
        Me.BtnActive = New System.Windows.Forms.Button()
        Me.txtUname = New System.Windows.Forms.TextBox()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(12, 59)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(488, 266)
        Me.dgvUser.TabIndex = 0
        '
        'btnSuspend
        '
        Me.btnSuspend.Enabled = False
        Me.btnSuspend.Location = New System.Drawing.Point(10, 30)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.Size = New System.Drawing.Size(75, 23)
        Me.btnSuspend.TabIndex = 2
        Me.btnSuspend.Text = "Suspend"
        Me.btnSuspend.UseVisualStyleBackColor = True
        '
        'BtnActive
        '
        Me.BtnActive.Enabled = False
        Me.BtnActive.Location = New System.Drawing.Point(86, 30)
        Me.BtnActive.Name = "BtnActive"
        Me.BtnActive.Size = New System.Drawing.Size(75, 23)
        Me.BtnActive.TabIndex = 3
        Me.BtnActive.Text = "Active"
        Me.BtnActive.UseVisualStyleBackColor = True
        '
        'txtUname
        '
        Me.txtUname.Enabled = False
        Me.txtUname.Location = New System.Drawing.Point(167, 32)
        Me.txtUname.MaxLength = 10
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(100, 20)
        Me.txtUname.TabIndex = 4
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 337)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.BtnActive)
        Me.Controls.Add(Me.btnSuspend)
        Me.Controls.Add(Me.dgvUser)
        Me.Name = "UserManagement"
        Me.Text = "UserManagement"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents btnSuspend As Button
    Friend WithEvents BtnActive As Button
    Friend WithEvents txtUname As TextBox
End Class
