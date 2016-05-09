Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Logistik_Duta.toDB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Buku
    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fBrowse As New OpenFileDialog
        With fBrowse
            .Filter = "excel files 2003-2007 (*.xls)|*.xls|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data From Excel File"
        End With
        If fBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtLokFile.Text = fBrowse.FileName
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
                bukuGridView.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            con.Close()



        End If
    End Sub

    Private Sub Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtLokFile.Enabled = False
        btnUpload.Enabled = False
        toDB.koneksi()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        For baris As Integer = 0 To bukuGridView.RowCount - 2
            If Not IsDBNull(bukuGridView.Rows(baris).Cells(0).Value) Then
                toDB.simpanBuku(bukuGridView.Rows(baris).Cells(0).Value, bukuGridView.Rows(baris).Cells(1).Value, bukuGridView.Rows(baris).Cells(2).Value, bukuGridView.Rows(baris).Cells(3).Value, bukuGridView.Rows(baris).Cells(4).Value, bukuGridView.Rows(baris).Cells(5).Value)
            End If
        Next
        MsgBox("Data Berhasil Tersimpan", MsgBoxStyle.Information)
        def()
    End Sub
    Sub def()
        btnUpload.Enabled = False
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        toDB.ViewBuku()
    End Sub

    Private Sub txtLokFile_TextChanged(sender As Object, e As EventArgs) Handles txtLokFile.TextChanged
        If txtLokFile.Text <> "" Then
            btnUpload.Enabled = True
        End If
    End Sub







    Private Sub Buku_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub




End Class