<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestBook))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.RbtnManual = New System.Windows.Forms.RadioButton()
        Me.RbtnExcel = New System.Windows.Forms.RadioButton()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.dgvPermintaan = New System.Windows.Forms.DataGridView()
        Me.dtpPakai = New System.Windows.Forms.DateTimePicker()
        Me.txtTPer = New System.Windows.Forms.TextBox()
        Me.cmbNamacabang = New System.Windows.Forms.ComboBox()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.txtNoP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPermintaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFile)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.RbtnManual)
        Me.GroupBox1.Controls.Add(Me.RbtnExcel)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.dgvPermintaan)
        Me.GroupBox1.Controls.Add(Me.dtpPakai)
        Me.GroupBox1.Controls.Add(Me.txtTPer)
        Me.GroupBox1.Controls.Add(Me.cmbNamacabang)
        Me.GroupBox1.Controls.Add(Me.txtNoSurat)
        Me.GroupBox1.Controls.Add(Me.txtNoP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permintaan Buku"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(476, 85)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(100, 20)
        Me.txtFile.TabIndex = 16
        '
        'btnBrowse
        '
        Me.btnBrowse.Enabled = False
        Me.btnBrowse.Location = New System.Drawing.Point(582, 83)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'RbtnManual
        '
        Me.RbtnManual.AutoSize = True
        Me.RbtnManual.Location = New System.Drawing.Point(390, 87)
        Me.RbtnManual.Name = "RbtnManual"
        Me.RbtnManual.Size = New System.Drawing.Size(87, 17)
        Me.RbtnManual.TabIndex = 14
        Me.RbtnManual.TabStop = True
        Me.RbtnManual.Text = "Input Manual"
        Me.RbtnManual.UseVisualStyleBackColor = True
        '
        'RbtnExcel
        '
        Me.RbtnExcel.AutoSize = True
        Me.RbtnExcel.Location = New System.Drawing.Point(285, 88)
        Me.RbtnExcel.Name = "RbtnExcel"
        Me.RbtnExcel.Size = New System.Drawing.Size(99, 17)
        Me.RbtnExcel.TabIndex = 13
        Me.RbtnExcel.TabStop = True
        Me.RbtnExcel.Text = "Data Dari Excel"
        Me.RbtnExcel.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(87, 467)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(6, 467)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'dgvPermintaan
        '
        Me.dgvPermintaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPermintaan.Location = New System.Drawing.Point(6, 123)
        Me.dgvPermintaan.Name = "dgvPermintaan"
        Me.dgvPermintaan.Size = New System.Drawing.Size(651, 338)
        Me.dgvPermintaan.TabIndex = 10
        '
        'dtpPakai
        '
        Me.dtpPakai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPakai.Location = New System.Drawing.Point(404, 54)
        Me.dtpPakai.Name = "dtpPakai"
        Me.dtpPakai.Size = New System.Drawing.Size(124, 20)
        Me.dtpPakai.TabIndex = 9
        Me.dtpPakai.Value = New Date(2016, 3, 2, 0, 0, 0, 0)
        '
        'txtTPer
        '
        Me.txtTPer.Enabled = False
        Me.txtTPer.Location = New System.Drawing.Point(404, 26)
        Me.txtTPer.Name = "txtTPer"
        Me.txtTPer.Size = New System.Drawing.Size(124, 20)
        Me.txtTPer.TabIndex = 8
        '
        'cmbNamacabang
        '
        Me.cmbNamacabang.FormattingEnabled = True
        Me.cmbNamacabang.Location = New System.Drawing.Point(121, 84)
        Me.cmbNamacabang.Name = "cmbNamacabang"
        Me.cmbNamacabang.Size = New System.Drawing.Size(141, 21)
        Me.cmbNamacabang.TabIndex = 7
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Enabled = False
        Me.txtNoSurat.Location = New System.Drawing.Point(121, 57)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(141, 20)
        Me.txtNoSurat.TabIndex = 6
        '
        'txtNoP
        '
        Me.txtNoP.Enabled = False
        Me.txtNoP.Location = New System.Drawing.Point(121, 26)
        Me.txtNoP.Name = "txtNoP"
        Me.txtNoP.Size = New System.Drawing.Size(141, 20)
        Me.txtNoP.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Pakai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Permintaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama cabang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Surat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Permintaan"
        '
        'RequestBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RequestBook"
        Me.Text = "Permintaan Buku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPermintaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dgvPermintaan As System.Windows.Forms.DataGridView
    Friend WithEvents dtpPakai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTPer As System.Windows.Forms.TextBox
    Friend WithEvents cmbNamacabang As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents RbtnManual As RadioButton
    Friend WithEvents RbtnExcel As RadioButton
End Class
