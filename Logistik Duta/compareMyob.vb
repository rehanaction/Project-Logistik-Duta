Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Logistik_Duta.toDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class compareMyob
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

    Private Sub DistribusiToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
        Compare.Show()
    End Sub



    Private Sub txtTahun_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub compareMyob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        toDB.autoKomplete()
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If txtNamacabang.Text <> "" Then
            Dim fBrowse As New OpenFileDialog
            With fBrowse
                .Filter = "excel files 2003-2007 (*.xls)|*.xls|all files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import data From Excel File"
            End With
            If fBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtFile.Text = fBrowse.FileName
                dgvHasilCompare.DataSource = Nothing
                btnCompare.Enabled = True
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
                    dgvCompareMyob.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                con.Close()
            End If
        Else
            MsgBox("Tahun dan Kota tidak boleh Kosong")
        End If
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim cabang, angka, aa As String
        Dim qty As Double
        cabang = txtNamacabang.Text
        For baris As Integer = 0 To dgvCompareMyob.RowCount - 2
            angka = dgvCompareMyob.Rows(baris).Cells(1).Value
            aa = angka.Replace(",", "")
            qty = aa

            hasilCompare(dgvCompareMyob.Rows(baris).Cells(8).Value, dgvCompareMyob.Rows(baris).Cells(2).Value, qty, cabang)
        Next
        Dim result As Integer = MessageBox.Show("Tampilkan Hasil Compare Data ?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            compareHasil(cabang)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim i As Integer
        Dim j As Integer
        Dim curr_row As Double = 0
        curr_row = Val("3")
        If ((dgvHasilCompare.Columns.Count = 0) Or (dgvHasilCompare.Rows.Count = 0)) Then
            Exit Sub
        End If
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i = 0 To dgvHasilCompare.ColumnCount - 1
            dset.Tables(0).Columns.Add(dgvHasilCompare.Columns(i).HeaderText)
        Next
        Dim dr1 As DataRow
        For i = 0 To dgvHasilCompare.RowCount - 1

            dr1 = dset.Tables(0).NewRow
            For j = 0 To dgvHasilCompare.Columns.Count - 1
                dr1(j) = dgvHasilCompare.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next
        Dim excel As New Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        Dim strFileName As String = "D:\" & txtNamacabang.Text & "-Compare.xlsx"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try
        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If
        wBook.SaveAs(strFileName)
        excel.Visible = True
    End Sub
End Class