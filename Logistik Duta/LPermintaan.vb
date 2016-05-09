Imports Logistik_Duta.toDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class LPermintaan
    Dim tinggi As Double = 0
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
        Me.Close()
        RequestBook.Show()
    End Sub

    Private Sub LaporanPermintaanToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Refresh()
    End Sub

    Private Sub txtTglPakai_TextChanged(sender As Object, e As EventArgs) Handles txtTglPakai.TextChanged

    End Sub

    Private Sub LPermintaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dis()
        toDB.koneksi()
        With dgvLPermintaan
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With
        With DataGridView1
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With
    End Sub
    Sub dis()
        txtNamaCabang.Enabled = False
        txtNoSurat.Enabled = False
        txtTanggal.Enabled = False
        txtTglPakai.Enabled = False
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtNoPermintaan.Text.Length > 0 And RbtnNP.Checked = True Then
            toDB.ViewPermintaan(txtNoPermintaan.Text)
        ElseIf txtNoPermintaan.Text.Length > 0 And RbtnKB.Checked = True Then
            toDB.ViewPermintaanBykodebuku(txtNoPermintaan.Text)
        Else
            MsgBox("Criteria Tidak Boleh Kosong !!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmbKodeBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeBuku.SelectedIndexChanged
        If txtNoPermintaan.Text <> "" And cmbKodeBuku.Text <> "" Then
            Dim total As Decimal
            detailMutasiPer(txtNoPermintaan.Text, cmbKodeBuku.Text)
            For baris As Integer = 0 To DataGridView1.RowCount - 2
                toDB.getHarga(DataGridView1.Rows(baris).Cells(2).Value.ToString, DataGridView1.Rows(baris).Cells(3).Value.ToString, baris)
                total = total + DataGridView1.Rows(baris).Cells(6).Value
            Next
            Dim akhir As Integer = DataGridView1.RowCount - 1
            DataGridView1.Rows(akhir).Cells(5).Value = "Total  Bayar"
            DataGridView1.Rows(akhir).Cells(6).Value = total
        Else
            MsgBox("No Permintaan Tidak Boleh kosong", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub btnInputMutasi_Click(sender As Object, e As EventArgs) Handles btnInputMutasi.Click
        If txtNoPermintaan.Text <> "" And dgvLPermintaan.DataSource IsNot Nothing Then
            BookMutasion.txtNoP.Text = txtNoPermintaan.Text
            Me.Close()
            BookMutasion.Show()
        Else
            MsgBox("Tidak Bisa Menginput Data", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Private Sub RbtnNP_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNP.CheckedChanged
        If RbtnNP.Checked = True Then
            txtNoPermintaan.Enabled = True
        End If
    End Sub

    Private Sub RbtnKB_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKB.CheckedChanged
        If RbtnKB.Checked = True Then
            txtNoPermintaan.Enabled = True
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        tinggi += 10
        e.Graphics.DrawString("PT.Penerbit Duta", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)

        tinggi += 10
        e.Graphics.DrawString("Jalan. XXX Bandung", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)

        tinggi += 10
        e.Graphics.DrawString("-----------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)

        For Each item As DataGridViewRow In dgvLPermintaan.Rows
            tinggi += 10
            e.Graphics.DrawString(+vbTab + item.Cells(0).Value.ToString + vbTab + item.Cells(1).Value.ToString + vbTab + item.Cells(2).Value.ToString, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        Next

        tinggi += 10
        e.Graphics.DrawString("-----------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)

        tinggi += 10
        e.Graphics.DrawString("Terimakasih", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim i As Integer
        Dim j As Integer
        Dim curr_row As Double = 0
        curr_row = Val("3")
        If ((dgvLPermintaan.Columns.Count = 0) Or (dgvLPermintaan.Rows.Count = 0)) Then
            Exit Sub
        End If
        If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then
            Exit Sub
        End If
        Dim dset, dset2 As New DataSet
        'add table to dataset
        dset.Tables.Add()
        dset2.Tables.Add()
        'add column to that table
        For i = 0 To dgvLPermintaan.ColumnCount - 1
            dset.Tables(0).Columns.Add(dgvLPermintaan.Columns(i).HeaderText)
        Next
        For i = 0 To DataGridView1.ColumnCount - 2
            dset2.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
        Next
        Dim dr1, dr2 As DataRow
        For i = 0 To dgvLPermintaan.RowCount - 1

            dr1 = dset.Tables(0).NewRow
            For j = 0 To dgvLPermintaan.Columns.Count - 1
                dr1(j) = dgvLPermintaan.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)

        Next
        For i = 0 To DataGridView1.RowCount - 2

            dr2 = dset2.Tables(0).NewRow
            For j = 0 To DataGridView1.Columns.Count - 2
                dr2(j) = DataGridView1.Rows(i).Cells(j).Value
            Next
            dset2.Tables(0).Rows.Add(dr2)

        Next
        Dim excel As New Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        Dim style As Excel.Style = wSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
        style.Font.Bold = True
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dt2 As System.Data.DataTable = dset2.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dc2 As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim dr3 As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        wSheet.Range("B1:F1").MergeCells = True
        wSheet.Range("B2:F2").MergeCells = True
        wSheet.Range("B3:F3").MergeCells = True
        wSheet.Range("B4:F4").MergeCells = True
        wSheet.Range("A5:F5").MergeCells = True
        wSheet.Range("A5:F5").Font.Bold = True
        wSheet.Range("A5:F5").Interior.ColorIndex = XLColor.Green


        excel.Cells(1, 1) = "No. IR"
        excel.Cells(2, 1) = "Request By "
        excel.Cells(3, 1) = "Request Date"
        excel.Cells(4, 1) = "Need Date"
        excel.Cells(5, 1) = "Inventory Request"
        excel.Cells(1, 2) = txtNoPermintaan.Text
        excel.Cells(2, 2) = "Cabang " & txtNamaCabang.Text
        excel.Cells(3, 2) = txtTanggal.Text
        excel.Cells(4, 2) = txtTglPakai.Text
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(6, colIndex) = dc.ColumnName

        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 6, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Range("A" & dgvLPermintaan.Rows.Count + 6 & ":F" & dgvLPermintaan.Rows.Count + 6 & "").MergeCells = True
        wSheet.Range("A" & dgvLPermintaan.Rows.Count + 6 & ":F" & dgvLPermintaan.Rows.Count + 6 & "").Font.Bold = True
        wSheet.Cells(dgvLPermintaan.Rows.Count + 6, 1).Interior.ColorIndex = XLColor.Green
        excel.Cells(dgvLPermintaan.Rows.Count + 6, 1) = "Detail Inventory Request"
        colIndex = 0
        For Each dc2 In dt2.Columns

            colIndex = colIndex + 1
            excel.Cells(7 + dgvLPermintaan.Rows.Count, colIndex) = dc2.ColumnName

        Next

        rowIndex = 0
        For Each dr3 In dt2.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc2 In dt2.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + (7 + dgvLPermintaan.Rows.Count), colIndex) = dr3(dc2.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        Dim strFileName As String
        Dim fsave As New SaveFileDialog
        With fsave
            .Filter = "excel files 2007 (*.xlsx)|*.xlsx|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Save Data Export "
        End With
        If fsave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = fsave.FileName
        End If
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
    Public Enum XLColor
        Aqua = 42
        Black = 1
        Blue = 5
        BlueGray = 47
        BrightGreen = 4
        Brown = 53
        Cream = 19
        DarkBlue = 11
        DarkGreen = 51
        DarkPurple = 21
        DarkRed = 9
        DarkTeal = 49
        DarkYellow = 12
        Gold = 44
        Gray25 = 15
        Gray40 = 48
        Gray50 = 16
        Gray80 = 56
        Green = 10
        Indigo = 55
        Lavender = 39
        LightBlue = 41
        LightGreen = 35
        LightLavender = 24
        LightOrange = 45
        LightTurquoise = 20
        LightYellow = 36
        Lime = 43
        NavyBlue = 23
        OliveGreen = 52
        Orange = 46
        PaleBlue = 37
        Pink = 7
        Plum = 18
        PowderBlue = 17
        Red = 3
        Rose = 38
        Salmon = 22
        SeaGreen = 50
        SkyBlue = 33
        Tan = 40
        Teal = 14
        Turquoise = 8
        Violet = 13
        White = 2
        Yellow = 6
    End Enum

    Private Sub CheckBoxTS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTS.CheckedChanged
        If CheckBoxTS.Checked = True And txtNoPermintaan.Text <> "" And dgvLPermintaan.DataSource IsNot Nothing Then
            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()
            detailMutasiPerkomplit(txtNoPermintaan.Text)
        ElseIf CheckBoxTS.Checked = False Then
            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = Nothing
        Else
            MsgBox("Tidak Ada Data Yang dapat Di tampilkan", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub
End Class