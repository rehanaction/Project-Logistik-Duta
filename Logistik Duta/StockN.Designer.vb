<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockN))
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblcabang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Loading = New System.Windows.Forms.ProgressBar()
        Me.lblData = New System.Windows.Forms.Label()
        Me.GBexport = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.RbtnJudulBuku = New System.Windows.Forms.RadioButton()
        Me.rbtKodeBuku = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSN = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBexport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(360, 40)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(587, 504)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(113, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(706, 504)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Report"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(202, 40)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(103, 23)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblcabang
        '
        Me.lblcabang.AutoSize = True
        Me.lblcabang.Location = New System.Drawing.Point(15, 19)
        Me.lblcabang.Name = "lblcabang"
        Me.lblcabang.Size = New System.Drawing.Size(44, 13)
        Me.lblcabang.TabIndex = 10
        Me.lblcabang.Text = "Cabang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Lokasi Data"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(270, 40)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(84, 23)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "Browse...."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(96, 43)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(167, 20)
        Me.txtFile.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(769, 419)
        Me.DataGridView1.TabIndex = 16
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(269, 19)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(15, 13)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "id"
        Me.lblID.Visible = False
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(96, 16)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(167, 21)
        Me.cmbCabang.TabIndex = 18
        '
        'Loading
        '
        Me.Loading.Location = New System.Drawing.Point(12, 502)
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(405, 23)
        Me.Loading.TabIndex = 21
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(423, 509)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(70, 13)
        Me.lblData.TabIndex = 23
        Me.lblData.Text = "0 Data Dari 0"
        '
        'GBexport
        '
        Me.GBexport.Controls.Add(Me.cbSN)
        Me.GBexport.Controls.Add(Me.lblcabang)
        Me.GBexport.Controls.Add(Me.Label1)
        Me.GBexport.Controls.Add(Me.txtFile)
        Me.GBexport.Controls.Add(Me.cmbCabang)
        Me.GBexport.Controls.Add(Me.btnBrowse)
        Me.GBexport.Controls.Add(Me.lblID)
        Me.GBexport.Controls.Add(Me.btnUpload)
        Me.GBexport.Location = New System.Drawing.Point(12, 2)
        Me.GBexport.Name = "GBexport"
        Me.GBexport.Size = New System.Drawing.Size(452, 69)
        Me.GBexport.TabIndex = 24
        Me.GBexport.TabStop = False
        Me.GBexport.Text = "Upload Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCriteria)
        Me.GroupBox1.Controls.Add(Me.RbtnJudulBuku)
        Me.GroupBox1.Controls.Add(Me.rbtKodeBuku)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 68)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data Buku"
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(9, 42)
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(187, 20)
        Me.txtCriteria.TabIndex = 8
        '
        'RbtnJudulBuku
        '
        Me.RbtnJudulBuku.AutoSize = True
        Me.RbtnJudulBuku.Location = New System.Drawing.Point(202, 14)
        Me.RbtnJudulBuku.Name = "RbtnJudulBuku"
        Me.RbtnJudulBuku.Size = New System.Drawing.Size(78, 17)
        Me.RbtnJudulBuku.TabIndex = 2
        Me.RbtnJudulBuku.TabStop = True
        Me.RbtnJudulBuku.Text = "Judul Buku"
        Me.RbtnJudulBuku.UseVisualStyleBackColor = True
        '
        'rbtKodeBuku
        '
        Me.rbtKodeBuku.AutoSize = True
        Me.rbtKodeBuku.Location = New System.Drawing.Point(106, 15)
        Me.rbtKodeBuku.Name = "rbtKodeBuku"
        Me.rbtKodeBuku.Size = New System.Drawing.Size(78, 17)
        Me.rbtKodeBuku.TabIndex = 1
        Me.rbtKodeBuku.TabStop = True
        Me.rbtKodeBuku.Text = "Kode Buku"
        Me.rbtKodeBuku.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cari Berdasarkan :"
        '
        'cbSN
        '
        Me.cbSN.AutoSize = True
        Me.cbSN.Location = New System.Drawing.Point(307, 18)
        Me.cbSN.Name = "cbSN"
        Me.cbSN.Size = New System.Drawing.Size(98, 17)
        Me.cbSN.TabIndex = 19
        Me.cbSN.Text = "Stock Nasional"
        Me.cbSN.UseVisualStyleBackColor = True
        '
        'StockN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBexport)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.Loading)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StockN"
        Me.Text = "Input Stock Cabang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBexport.ResumeLayout(False)
        Me.GBexport.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents lblcabang As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Loading As ProgressBar
    Friend WithEvents lblData As Label
    Friend WithEvents GBexport As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCriteria As TextBox
    Friend WithEvents RbtnJudulBuku As RadioButton
    Friend WithEvents rbtKodeBuku As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSN As CheckBox
End Class
