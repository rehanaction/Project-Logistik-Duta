<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAwal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CabangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribusiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputStockCabangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Permintaan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompareSalesDistribusiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPermintaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserActivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.UserManagementToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(687, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukuToolStripMenuItem, Me.CabangToolStripMenuItem, Me.DistribusiToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Image = CType(resources.GetObject("DataMasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataMasterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(114, 36)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'CabangToolStripMenuItem
        '
        Me.CabangToolStripMenuItem.Name = "CabangToolStripMenuItem"
        Me.CabangToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CabangToolStripMenuItem.Text = "Cabang"
        '
        'DistribusiToolStripMenuItem
        '
        Me.DistribusiToolStripMenuItem.Name = "DistribusiToolStripMenuItem"
        Me.DistribusiToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DistribusiToolStripMenuItem.Text = "Distribusi"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputStockCabangToolStripMenuItem, Me.Permintaan2ToolStripMenuItem, Me.CompareSalesDistribusiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(100, 36)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'InputStockCabangToolStripMenuItem
        '
        Me.InputStockCabangToolStripMenuItem.Name = "InputStockCabangToolStripMenuItem"
        Me.InputStockCabangToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InputStockCabangToolStripMenuItem.Text = "Input Stock Cabang"
        '
        'Permintaan2ToolStripMenuItem
        '
        Me.Permintaan2ToolStripMenuItem.Name = "Permintaan2ToolStripMenuItem"
        Me.Permintaan2ToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.Permintaan2ToolStripMenuItem.Text = "Permintaan Buku"
        '
        'CompareSalesDistribusiToolStripMenuItem
        '
        Me.CompareSalesDistribusiToolStripMenuItem.Name = "CompareSalesDistribusiToolStripMenuItem"
        Me.CompareSalesDistribusiToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CompareSalesDistribusiToolStripMenuItem.Text = "Perbandingan Data"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPermintaanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(94, 36)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPermintaanToolStripMenuItem
        '
        Me.LaporanPermintaanToolStripMenuItem.Name = "LaporanPermintaanToolStripMenuItem"
        Me.LaporanPermintaanToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LaporanPermintaanToolStripMenuItem.Text = "Laporan Permintaan"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserActivityToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(116, 36)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'UserActivityToolStripMenuItem
        '
        Me.UserActivityToolStripMenuItem.Name = "UserActivityToolStripMenuItem"
        Me.UserActivityToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.UserActivityToolStripMenuItem.Text = "User Activity"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(687, 24)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(600, 19)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = " Inventory Sederhana by Click-IT"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(41, 19)
        Me.ToolStripStatusLabel2.Text = "Waktu"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 508)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuAwal"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CabangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputStockCabangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPermintaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Permintaan2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompareSalesDistribusiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistribusiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserActivityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
