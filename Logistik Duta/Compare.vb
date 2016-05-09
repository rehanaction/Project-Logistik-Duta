Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Logistik_Duta.toDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Compare
    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource
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
    Private Sub Permintaan2ToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
        RequestBook.Show()
    End Sub
    Private Sub LaporanPermintaanToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
        LPermintaan.Show()
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
            btnUpload.Enabled = True
            Try
                con = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" &
                    "data source='" & fBrowse.FileName & "';Extended Properties=Excel 8.0;")
                da = New OleDbDataAdapter("select * from [Sheet1$]", con)
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Try
                ds.Clear()
                da.Fill(ds)
                dgvDistribusi.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim coba, cc As String
        Dim tahun, tgl As String
        Dim jmldata As Double = dgvDistribusi.RowCount - 1
        Loading.Maximum = jmldata
        Loading.Value = 0
        For baris As Integer = 0 To dgvDistribusi.RowCount - 2
            coba = dgvDistribusi.Rows(baris).Cells(4).Value.ToString()
            tahun = dgvDistribusi.Rows(baris).Cells(2).Value.ToString()
            cc = coba.Replace("-", "")
            tgl = dgvDistribusi.Rows(baris).Cells(2).Value.ToString
            simpanCompare(dgvDistribusi.Rows(baris).Cells(1).Value, tgl.ToString, tahun.Substring(6, 4), dgvDistribusi.Rows(baris).Cells(3).Value, cc, dgvDistribusi.Rows(baris).Cells(5).Value, dgvDistribusi.Rows(baris).Cells(6).Value)
            tDistribusi(dgvDistribusi.Rows(baris).Cells(1).Value, tgl.Substring(0, 10).ToString, tahun.Substring(6, 4), dgvDistribusi.Rows(baris).Cells(3).Value, cc, dgvDistribusi.Rows(baris).Cells(5).Value, dgvDistribusi.Rows(baris).Cells(6).Value)
            Loading.Value = Loading.Value + 1
            lblData.Text = "Menyimpan data " & Loading.Value & " Dari " & jmldata
        Next
        MsgBox(Loading.Value & " Data Tersimpan Dari " & jmldata & " Yang Di upload ", MsgBoxStyle.Information, "Distribusi")
        btnUpload.Enabled = False
        dgvDistribusi.DataSource = Nothing
        txtFile.Text = ""
    End Sub

    Private Sub DistribusiToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Refresh()
    End Sub

    Private Sub PerbadinganDataToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
        compareMyob.Show()
    End Sub

    Private Sub Compare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
    End Sub
End Class