Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Logistik_Duta.toDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class StockN

    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource




    Private Sub DaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Cabang.Show()
    End Sub



    Private Sub StockN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        toDB.itemCombo()

        btnExport.Enabled = False
        'txtSum.Enabled = False
        txtFile.Enabled = False
        'lblID.Visible = False
        btnBrowse.Enabled = False
        btnUpload.Enabled = False
        txtCriteria.MaxLength = 50
        With DataGridView1
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With

    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim kb, ckb As String
        'Dim field() As String
        Dim jmldata As Double = DataGridView1.RowCount - 1
        Loading.Maximum = jmldata
        Loading.Value = 0
        If cbSN.Checked = False Then
            For baris As Integer = 0 To DataGridView1.RowCount - 1

                If Not IsDBNull(DataGridView1.Rows(baris).Cells(0).Value) Then
                    If IsDBNull(DataGridView1.Rows(baris).Cells(2).Value) Then
                        DataGridView1.Rows(baris).Cells(2).Value = 0
                    End If
                    kb = DataGridView1.Rows(baris).Cells(0).Value.ToString()
                    ckb = kb.Replace("-", "")
                    toDB.SimpanStockCabang(ckb, lblID.Text, DataGridView1.Rows(baris).Cells(2).Value, cmbCabang.Text)
                    Loading.Value = Loading.Value + 1
                    lblData.Text = "Menyimpan data " & Loading.Value & " Dari " & jmldata
                Else
                    Exit For
                End If

            Next
        Else
            For c As Integer = 2 To DataGridView1.ColumnCount - 1
                'MsgBox(DataGridView1.Columns(c).HeaderCell.Value.ToString())
                For baris As Integer = 0 To DataGridView1.RowCount - 1
                    kb = DataGridView1.Rows(baris).Cells(0).Value.ToString()
                    ckb = kb.Replace("-", "")
                    simpanStockNasional(ckb, DataGridView1.Rows(baris).Cells(c).Value, DataGridView1.Columns(c).HeaderCell.Value.ToString())


                Next
            Next

        End If
        MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information)
        def()
    End Sub
    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub def()
        txtFile.Enabled = False
        txtFile.Text = ""
        lblID.Visible = False
        btnBrowse.Enabled = False
        btnUpload.Enabled = False
    End Sub
    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs)

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
                DataGridView1.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub
    Private Sub cmbCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCabang.SelectedIndexChanged
        If cmbCabang.SelectedItem <> "" Then
            toDB.getID(cmbCabang.Text)
            btnBrowse.Enabled = True
            btnUpload.Enabled = True
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        toDB.RefreshDataView()
        btnExport.Enabled = True
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If rbtKodeBuku.Checked = True Or RbtnJudulBuku.Checked = True Then
            toDB.Cari(txtCriteria.Text)
        Else
            MsgBox("Pilih Salah Satu Criteria Untuk Mencari Data !!", MsgBoxStyle.Critical, "Information")
        End If
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim i As Integer
        Dim j As Integer
        Dim curr_row As Double = 0
        curr_row = Val("3")
        If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then
            Exit Sub
        End If
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i = 0 To DataGridView1.ColumnCount - 1
            dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
        Next
        Dim dr1 As DataRow
        For i = 0 To DataGridView1.RowCount - 1

            dr1 = dset.Tables(0).NewRow
            For j = 0 To DataGridView1.Columns.Count - 1
                dr1(j) = DataGridView1.Rows(i).Cells(j).Value
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
        Dim strFileName As String = "D:\Stock-" & Format(Now, "dd-MM-yy") & ".xls"
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
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Buku.Show()
    End Sub

    Private Sub InputStockCabangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Refresh()
    End Sub


    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PermintaanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        RequestBook.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cbSN_CheckedChanged(sender As Object, e As EventArgs) Handles cbSN.CheckedChanged
        If cbSN.Checked = True Then
            cmbCabang.Enabled = False
            btnUpload.Enabled = True
            btnBrowse.Enabled = True
        Else
            cmbCabang.Enabled = True
        End If
    End Sub
End Class