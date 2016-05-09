Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization
Public Class RequestBook
    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource
    Dim tgl As String
    Private Sub RequestBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        Kodenomor()
        nomoSurat()
        itemCombo4()
        tgl = Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        dtpPakai.CustomFormat = "dd/MM/yyyy"
        txtTPer.Text = tgl
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbNamacabang.Text <> "" And dtpPakai.Text.ToString <> "" Then
            If RbtnManual.Checked = True Then
                savePermin(txtNoP.Text, txtNoSurat.Text, cmbNamacabang.Text, txtTPer.Text, dtpPakai.Value.ToString)
                For baris As Integer = 0 To dgvPermintaan.RowCount - 2
                    If dgvPermintaan.Rows(baris).Cells(0).Value.ToString <> "" Then
                        toDB.tPermintaan(txtNoP.Text, dgvPermintaan.Rows(baris).Cells(0).Value, dgvPermintaan.Rows(baris).Cells(4).Value)
                    Else
                        Exit For
                    End If
                Next
                BookMutasion.txtNoP.Text = txtNoP.Text
                Me.Close()
                BookMutasion.Show()
            ElseIf RbtnExcel.Checked = True And txtFile.Text <> "" And cmbNamacabang.Text <> "" Then
                savePermin(txtNoP.Text, txtNoSurat.Text, cmbNamacabang.Text, txtTPer.Text, dtpPakai.Value.ToString)
                For baris As Integer = 0 To dgvPermintaan.RowCount - 2
                    If dgvPermintaan.Rows(baris).Cells(0).Value.ToString <> "" Then
                        toDB.tPermintaan(txtNoP.Text, dgvPermintaan.Rows(baris).Cells(0).Value, dgvPermintaan.Rows(baris).Cells(2).Value)
                    Else
                        Exit For
                    End If

                Next
                BookMutasion.txtNoP.Text = txtNoP.Text
                Me.Close()
                BookMutasion.Show()
            End If
        Else
                MsgBox("Pilih Nama Cabang Terlebih Dahulu !!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub dgvPermintaan_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPermintaan.CellValueChanged
        If RbtnManual.Checked = True Then
            For baris As Integer = 0 To dgvPermintaan.RowCount - 2
                toDB.ViewBuku2(dgvPermintaan.Rows(baris).Cells(0).Value, baris)
            Next
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Buku.Show()

    End Sub

    Private Sub CabangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Cabang.Show()
    End Sub

    Private Sub InputStockCabangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        StockN.Show()
    End Sub

    Private Sub PermintaanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Refresh()
    End Sub

    Private Sub LaporanPermintaanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        LPermintaan.Show()
    End Sub

    Private Sub dgvPermintaan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPermintaan.CellContentClick

    End Sub

    Private Sub RbtnExcel_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnExcel.CheckedChanged
        If RbtnExcel.Checked = True Then
            txtFile.Text = ""
            btnBrowse.Enabled = True
            dgvPermintaan.DataSource = Nothing
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fBrowse As New OpenFileDialog
        With fBrowse
            .Filter = "excel files 2003-2007 (*.xls)|*.xls|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data From Excel File"
        End With
        If fBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFile.Text = fBrowse.FileName
            Try
                con = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" &
                    "data source='" & fBrowse.FileName & "';Extended Properties=Excel 8.0;")
                da = New OleDbDataAdapter("select * from [Sheet1$]", con)
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Try
                ds.Reset()
                ds.Clear()
                ds.Tables.Clear()
                da.Fill(ds)
                dgvPermintaan.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub RbtnManual_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnManual.CheckedChanged
        If RbtnManual.Checked = True Then
            txtFile.Text = ""
            permintaandgv()
            btnBrowse.Enabled = False
        End If

    End Sub
End Class