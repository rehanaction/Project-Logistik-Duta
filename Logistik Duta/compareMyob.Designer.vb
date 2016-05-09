<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compareMyob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(compareMyob))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamacabang = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCompareMyob = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dgvHasilCompare = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCompareMyob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvHasilCompare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamacabang)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.txtFile)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnCompare)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compare Data"
        '
        'txtNamacabang
        '
        Me.txtNamacabang.Location = New System.Drawing.Point(84, 19)
        Me.txtNamacabang.Name = "txtNamacabang"
        Me.txtNamacabang.Size = New System.Drawing.Size(100, 20)
        Me.txtNamacabang.TabIndex = 9
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(373, 17)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(84, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(264, 19)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(100, 20)
        Me.txtFile.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "File Compare"
        '
        'btnCompare
        '
        Me.btnCompare.Enabled = False
        Me.btnCompare.Location = New System.Drawing.Point(463, 17)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(83, 23)
        Me.btnCompare.TabIndex = 4
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kota/Cabang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCompareMyob)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 210)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Compare"
        '
        'dgvCompareMyob
        '
        Me.dgvCompareMyob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompareMyob.Location = New System.Drawing.Point(12, 19)
        Me.dgvCompareMyob.Name = "dgvCompareMyob"
        Me.dgvCompareMyob.Size = New System.Drawing.Size(645, 185)
        Me.dgvCompareMyob.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExport)
        Me.GroupBox3.Controls.Add(Me.dgvHasilCompare)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 262)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hasil Compare"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(544, 229)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 23)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dgvHasilCompare
        '
        Me.dgvHasilCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasilCompare.Location = New System.Drawing.Point(11, 17)
        Me.dgvHasilCompare.Name = "dgvHasilCompare"
        Me.dgvHasilCompare.Size = New System.Drawing.Size(645, 206)
        Me.dgvHasilCompare.TabIndex = 0
        '
        'compareMyob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 568)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "compareMyob"
        Me.Text = "Compare Data "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCompareMyob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvHasilCompare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCompareMyob As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExport As Button
    Friend WithEvents dgvHasilCompare As DataGridView
    Friend WithEvents txtNamacabang As TextBox
End Class
