<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookMutasion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookMutasion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJPer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbKodeBuku = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPakai = New System.Windows.Forms.TextBox()
        Me.txtNamaCabang = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.dgvMutasi = New System.Windows.Forms.DataGridView()
        Me.txtTPer = New System.Windows.Forms.TextBox()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.txtNoP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMutasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJPer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbKodeBuku)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPakai)
        Me.GroupBox1.Controls.Add(Me.txtNamaCabang)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.dgvMutasi)
        Me.GroupBox1.Controls.Add(Me.txtTPer)
        Me.GroupBox1.Controls.Add(Me.txtNoSurat)
        Me.GroupBox1.Controls.Add(Me.txtNoP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 451)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mutasi Buku"
        '
        'txtJPer
        '
        Me.txtJPer.Enabled = False
        Me.txtJPer.Location = New System.Drawing.Point(473, 412)
        Me.txtJPer.Name = "txtJPer"
        Me.txtJPer.Size = New System.Drawing.Size(157, 20)
        Me.txtJPer.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total Permintaan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 114)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Stock Buku"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 89)
        Me.DataGridView1.TabIndex = 0
        '
        'cmbKodeBuku
        '
        Me.cmbKodeBuku.FormattingEnabled = True
        Me.cmbKodeBuku.Location = New System.Drawing.Point(404, 85)
        Me.cmbKodeBuku.Name = "cmbKodeBuku"
        Me.cmbKodeBuku.Size = New System.Drawing.Size(124, 21)
        Me.cmbKodeBuku.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Kode Buku"
        '
        'txtPakai
        '
        Me.txtPakai.Enabled = False
        Me.txtPakai.Location = New System.Drawing.Point(404, 57)
        Me.txtPakai.Name = "txtPakai"
        Me.txtPakai.Size = New System.Drawing.Size(124, 20)
        Me.txtPakai.TabIndex = 14
        '
        'txtNamaCabang
        '
        Me.txtNamaCabang.Enabled = False
        Me.txtNamaCabang.Location = New System.Drawing.Point(121, 87)
        Me.txtNamaCabang.Name = "txtNamaCabang"
        Me.txtNamaCabang.Size = New System.Drawing.Size(141, 20)
        Me.txtNamaCabang.TabIndex = 13
        '
        'btnBatal
        '
        Me.btnBatal.Enabled = False
        Me.btnBatal.Location = New System.Drawing.Point(102, 412)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Selesai"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Location = New System.Drawing.Point(21, 412)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'dgvMutasi
        '
        Me.dgvMutasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMutasi.Location = New System.Drawing.Point(21, 247)
        Me.dgvMutasi.Name = "dgvMutasi"
        Me.dgvMutasi.Size = New System.Drawing.Size(609, 159)
        Me.dgvMutasi.TabIndex = 10
        '
        'txtTPer
        '
        Me.txtTPer.Enabled = False
        Me.txtTPer.Location = New System.Drawing.Point(404, 26)
        Me.txtTPer.Name = "txtTPer"
        Me.txtTPer.Size = New System.Drawing.Size(124, 20)
        Me.txtTPer.TabIndex = 8
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
        'BookMutasion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookMutasion"
        Me.Text = "Mutasi Buku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMutasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPakai As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaCabang As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dgvMutasi As System.Windows.Forms.DataGridView
    Friend WithEvents txtTPer As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKodeBuku As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtJPer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
