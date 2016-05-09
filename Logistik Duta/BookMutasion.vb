Public Class BookMutasion
    Private Sub txtNoP_TextChanged(sender As Object, e As EventArgs) Handles txtNoP.TextChanged
        If txtNoP.Text <> "" Then
            getdataRequest(txtNoP.Text)
            codeBookR(txtNoP.Text)
        End If
    End Sub

    Private Sub cmbKodeBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeBuku.SelectedIndexChanged
        If cmbKodeBuku.Text <> "" Then
            ' DataGridView1.DataSource = Nothing

            stockbycodeBook(cmbKodeBuku.Text)
            Call Kolombaru()
            getJper(txtNoP.Text, cmbKodeBuku.Text)
        End If
    End Sub

    Private Sub BookMutasion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        With DataGridView1
            .ReadOnly = True
        End With
        'mutasidgv()
    End Sub
    Sub Kolombaru()
        dgvMutasi.Columns.Clear()
        Call ListBarang()
        'dgvMutasi.Columns.Add("namaCabang", "Nama Cabang")
        dgvMutasi.Columns.Add("Jumlah Stock", "Jumlah Stock")
        dgvMutasi.Columns.Add("Jumlah permintaan", "Jumlah Permintaan")
        dgvMutasi.Columns.Add("Jumlah Mutasi", "Jumlah Mutasi")
    End Sub
    Sub ListBarang()
        toDB.koneksi()
        SDA = New MySql.Data.MySqlClient.MySqlDataAdapter("Select namacabang as Cabang from ListCabang", conn)
        SDS = New DataSet
        SDS.Reset()
        SDS.Tables.Clear()
        SDS.Clear()
        SDA.Fill(SDS)
        Dim cols As New DataGridViewComboBoxColumn
        ' definisikan sebuah object di dgv berupa combo
        cols.DataSource = SDS.Tables(0)
        ' ambil data dari dataset
        cols.DisplayMember = "Cabang"
        ' ambil kolom nama barang
        dgvMutasi.Columns.Add(cols)
        ' tambahkan object tersebut
        cols.HeaderText = "Nama Cabang"
        ' buat header text
        cols.Width = 100
        ' atur lebar kolom
        conn.Close()
    End Sub
    Private Sub dgvMutasi_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMutasi.CellEndEdit
        If (e.ColumnIndex = 3) Then 'checking numeric value for column 3 only
            Dim jp As Double
            jp = txtJPer.Text
            For baris As Integer = 0 To dgvMutasi.RowCount - 2

                If dgvMutasi.Rows(baris).Cells(3).Value > dgvMutasi.Rows(baris).Cells(2).Value Then
                    MsgBox("Jumlah Yang anda input melebihi Jumlah Permintaan", MsgBoxStyle.Information)
                    dgvMutasi.Rows(baris).Cells(3).Value = 0
                ElseIf dgvMutasi.Rows(baris).Cells(3).Value > dgvMutasi.Rows(baris).Cells(1).Value Then
                    MsgBox("Jumlah Yang anda input melebihi Stock cabang", MsgBoxStyle.Information)
                    dgvMutasi.Rows(baris).Cells(3).Value = 0
                ElseIf dgvMutasi.Rows(baris).Cells(3).Value = 0 Then
                    MsgBox("Jumlah Mutasi Tidak Boleh diisi Angka 0", MsgBoxStyle.Information)
                    dgvMutasi.Rows(baris).Cells(3).Value = 0
                End If
                txtJPer.Text = jp - dgvMutasi.Rows(baris).Cells(3).Value
            Next
        End If
    End Sub

    Private Sub dgvMutasi_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMutasi.CellValueChanged
        If cmbKodeBuku.Text <> "" Then
            For baris As Integer = 0 To dgvMutasi.RowCount - 2
                toDB.getPermintaan(dgvMutasi.Rows(baris).Cells(0).Value, cmbKodeBuku.Text, txtNoP.Text, baris)
            Next
        Else
            MsgBox("Pilih Kode buku Terlebih dahulu", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub dgvMutasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvMutasi.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtJPer_TextChanged(sender As Object, e As EventArgs) Handles txtJPer.TextChanged
        btnSimpan.Enabled = True
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jm As Double = 0
        For baris As Integer = 0 To dgvMutasi.RowCount - 2
            updateSC(cmbKodeBuku.Text, dgvMutasi.Rows(baris).Cells(0).Value, dgvMutasi.Rows(baris).Cells(3).Value)
            mutasiBuku(cmbKodeBuku.Text, txtNamaCabang.Text, dgvMutasi.Rows(baris).Cells(3).Value)
            InsertMutasi(txtNoP.Text, cmbKodeBuku.Text, dgvMutasi.Rows(baris).Cells(0).Value, dgvMutasi.Rows(baris).Cells(3).Value)
            jm = jm + dgvMutasi.Rows(baris).Cells(3).Value
        Next
        updatstat(cmbKodeBuku.Text, txtNoP.Text, jm)
        codeBookR(txtNoP.Text)
        def()
        MsgBox("Data Tersimpan")
    End Sub
    Sub def()
        DataGridView1.DataSource = Nothing
        dgvMutasi.Columns.Clear()
        dgvMutasi.Rows.Clear()
        cmbKodeBuku.Text = ""
        btnSimpan.Enabled = False
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub


End Class