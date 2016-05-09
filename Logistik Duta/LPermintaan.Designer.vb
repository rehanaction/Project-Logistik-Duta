<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LPermintaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LPermintaan))
        Me.txtNoPermintaan = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvLPermintaan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaCabang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.txtTglPakai = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnInputMutasi = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbKodeBuku = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbtnKB = New System.Windows.Forms.RadioButton()
        Me.RbtnNP = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.CheckBoxTS = New System.Windows.Forms.CheckBox()
        CType(Me.dgvLPermintaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNoPermintaan
        '
        Me.txtNoPermintaan.Enabled = False
        Me.txtNoPermintaan.Location = New System.Drawing.Point(5, 36)
        Me.txtNoPermintaan.Name = "txtNoPermintaan"
        Me.txtNoPermintaan.Size = New System.Drawing.Size(204, 20)
        Me.txtNoPermintaan.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(215, 34)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dgvLPermintaan
        '
        Me.dgvLPermintaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLPermintaan.Location = New System.Drawing.Point(1, 99)
        Me.dgvLPermintaan.Name = "dgvLPermintaan"
        Me.dgvLPermintaan.Size = New System.Drawing.Size(733, 195)
        Me.dgvLPermintaan.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. Surat"
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(99, 22)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(131, 20)
        Me.txtNoSurat.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Cabang"
        '
        'txtNamaCabang
        '
        Me.txtNamaCabang.Location = New System.Drawing.Point(99, 45)
        Me.txtNamaCabang.Name = "txtNamaCabang"
        Me.txtNamaCabang.Size = New System.Drawing.Size(131, 20)
        Me.txtNamaCabang.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tanggal Pakai"
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(318, 18)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(100, 20)
        Me.txtTanggal.TabIndex = 12
        '
        'txtTglPakai
        '
        Me.txtTglPakai.Location = New System.Drawing.Point(318, 45)
        Me.txtTglPakai.Name = "txtTglPakai"
        Me.txtTglPakai.Size = New System.Drawing.Size(100, 20)
        Me.txtTglPakai.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxTS)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnInputMutasi)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.cmbKodeBuku)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 283)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Mutasi"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(546, 254)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 23)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print To Excel"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnInputMutasi
        '
        Me.btnInputMutasi.Location = New System.Drawing.Point(655, 254)
        Me.btnInputMutasi.Name = "btnInputMutasi"
        Me.btnInputMutasi.Size = New System.Drawing.Size(75, 23)
        Me.btnInputMutasi.TabIndex = 20
        Me.btnInputMutasi.Text = "Input Mutasi"
        Me.btnInputMutasi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(727, 202)
        Me.DataGridView1.TabIndex = 19
        '
        'cmbKodeBuku
        '
        Me.cmbKodeBuku.FormattingEnabled = True
        Me.cmbKodeBuku.Location = New System.Drawing.Point(63, 19)
        Me.cmbKodeBuku.Name = "cmbKodeBuku"
        Me.cmbKodeBuku.Size = New System.Drawing.Size(121, 21)
        Me.cmbKodeBuku.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kode Buku"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTglPakai)
        Me.GroupBox2.Controls.Add(Me.txtTanggal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNoSurat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNamaCabang)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 81)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informasi Data Permintaan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbtnKB)
        Me.GroupBox3.Controls.Add(Me.RbtnNP)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtNoPermintaan)
        Me.GroupBox3.Controls.Add(Me.btnCari)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 70)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criteria"
        '
        'RbtnKB
        '
        Me.RbtnKB.AutoSize = True
        Me.RbtnKB.Location = New System.Drawing.Point(212, 15)
        Me.RbtnKB.Name = "RbtnKB"
        Me.RbtnKB.Size = New System.Drawing.Size(78, 17)
        Me.RbtnKB.TabIndex = 6
        Me.RbtnKB.TabStop = True
        Me.RbtnKB.Text = "&Kode Buku&"
        Me.RbtnKB.UseVisualStyleBackColor = True
        '
        'RbtnNP
        '
        Me.RbtnNP.AutoSize = True
        Me.RbtnNP.Location = New System.Drawing.Point(108, 14)
        Me.RbtnNP.Name = "RbtnNP"
        Me.RbtnNP.Size = New System.Drawing.Size(98, 17)
        Me.RbtnNP.TabIndex = 5
        Me.RbtnNP.TabStop = True
        Me.RbtnNP.Text = "&No. Permintaan&"
        Me.RbtnNP.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "&Cari Berdasarkan : &"
        '
        'PrintDocument1
        '
        '
        'CheckBoxTS
        '
        Me.CheckBoxTS.AutoSize = True
        Me.CheckBoxTS.Location = New System.Drawing.Point(205, 21)
        Me.CheckBoxTS.Name = "CheckBoxTS"
        Me.CheckBoxTS.Size = New System.Drawing.Size(111, 17)
        Me.CheckBoxTS.TabIndex = 22
        Me.CheckBoxTS.Text = "Tampilkan Semua"
        Me.CheckBoxTS.UseVisualStyleBackColor = True
        '
        'LPermintaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 595)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvLPermintaan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LPermintaan"
        Me.Text = "Laporan Permintaan"
        CType(Me.dgvLPermintaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNoPermintaan As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents dgvLPermintaan As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaCabang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtTglPakai As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbKodeBuku As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnInputMutasi As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbtnKB As RadioButton
    Friend WithEvents RbtnNP As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents CheckBoxTS As CheckBox
End Class
