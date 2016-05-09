Imports Logistik_Duta.toDB
Imports MySql.Data.MySqlClient
Public Class Permintaan
    Dim tgl As Date
    Dim sisa, sisa2, sisa3, sisa4 As Integer
    Dim jumlah As Integer
    Dim stockC As Double
    Dim sisaSC As Double
    Private Sub Permintaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        Label9.Visible = False
        Label8.Visible = False
        dis()
        tgl = Date.Now.Date
        txtTanggal.Text = tgl
        toDB.itemCombo2()
        txtKodeBuku.MaxLength = 10
        txtNoPermintaan.MaxLength = 10
        txtNoSurat.MaxLength = 10
        txtJumlah.MaxLength = 6
        With DataGridView1
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
    End Sub
    Sub dis()
        txtNoPermintaan.Enabled = False
        txtKb1.Enabled = False
        cmbNC1.Enabled = False
        cmbNC2.Enabled = False
        cmbNc3.Enabled = False
        cmbNC4.Enabled = False
        txtNoSurat.Enabled = False
        cmbNamaCabang.Enabled = False
        txtJumlah.Enabled = False
        txtTanggal.Enabled = False
        dtpTanggalPakai.Enabled = False
        txtJstock.Enabled = False
        txtJstock2.Enabled = False
        txtJstock3.Enabled = False
        txtJstock4.Enabled = False
        txtRstock.Enabled = False
        txtRstock2.Enabled = False
        txtRstock3.Enabled = False
        txtRstock4.Enabled = False
        txtKb2.Enabled = False
        txtKb3.Enabled = False
        txtKb4.Enabled = False
        btnSU.Enabled = False
        btnSU2.Enabled = False
        btnSu3.Enabled = False
        btnSu4.Enabled = False
        btnSP.Enabled = False
        btnBaru.Enabled = False
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If btnCari.Text = "Cari" Then
            toDB.CariPermintaan(txtKodeBuku.Text)
            If DataGridView1.RowCount <> 0 Then
                txtKb1.Text = txtKodeBuku.Text
                cmbNamaCabang.Enabled = True
                txtJumlah.Enabled = True
                dtpTanggalPakai.Enabled = True
                txtNoPermintaan.Enabled = True
                txtNoSurat.Enabled = True
                btnSP.Enabled = True
                btnCari.Text = "Refresh"
            End If

        ElseIf btnCari.Text = "Refresh" Then
            toDB.CariPermintaan(txtKodeBuku.Text)
        End If
        
    End Sub

    Private Sub txtKb1_TextChanged(sender As Object, e As EventArgs) Handles txtKb1.TextChanged
       
    End Sub

    Private Sub cmbNC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNC1.SelectedIndexChanged
        Dim query As String
        If conn.State >= 1 Then
            conn.Close()
            conn.Open()
            query = "select " & cmbNC1.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If txtJumlah.Text <= RD.Item(0) Then
                    txtJstock.Text = RD.Item(0)
                    txtRstock.Enabled = True
                Else
                    txtRstock.Enabled = False
                    txtJstock.Text = ""
                    MsgBox("stock tidak cukup")
                End If
            End While
        Else
            conn.Close()
            conn.Open()
            query = "select " & cmbNC1.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If txtJumlah.Text <= RD.Item(0) Then
                    txtJstock.Text = RD.Item(0)
                    txtRstock.Enabled = True
                ElseIf txtJumlah.Text > RD.Item(0) Then
                    txtJstock.Text = ""
                    txtRstock.Enabled = False
                    MsgBox("stock tidak cukup")

                End If
            End While

        End If
    End Sub

    Private Sub txtKodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBuku.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtKodeBuku_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBuku.TextChanged

    End Sub

    

    Private Sub txtRstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRstock.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtRstock_TextChanged(sender As Object, e As EventArgs) Handles txtRstock.TextChanged
        If jumlah <> 0 And txtRstock.Text.Length > 0 Then
            'sisa = jumlah - CInt(Int(txtRstock2.Text))
            'sisaSC = stockC - CInt(Int(txtRstock2.Text))
            'sisa2 = sisa
            'Label8.Text = sisaSC
            'Label9.Text = sisa
        Else
            MsgBox("Jumlah Mutasi Tidak boleh kosong / 0 !!")
            sisa = sisa2
        End If
    End Sub
    

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtJumlah_LostFocus(sender As Object, e As EventArgs) Handles txtJumlah.LostFocus
       
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If txtJumlah.Text.Length > 0 And txtJumlah.Text <> 0 Then
            jumlah = txtJumlah.Text
        Else
            MsgBox("Jumlah Wajib Diisi dan Tidak diisi angka 0")
        End If
    End Sub

    Private Sub txtJstock_TextChanged(sender As Object, e As EventArgs) Handles txtJstock.TextChanged
        'stockC = txtJstock.Text
    End Sub

    Private Sub btnSU_Click(sender As Object, e As EventArgs) Handles btnSU.Click
        If txtRstock.Text <= txtJumlah.Text And txtRstock.Text <> 0 Then
            sisa = jumlah - CInt(Int(txtRstock.Text))
            sisaSC = stockC - CInt(Int(txtRstock.Text))
            sisa2 = sisa
            Label8.Text = sisaSC
            Label9.Text = sisa
            toDB.SimpanDetailPermintaan(txtNoPermintaan.Text, cmbNC1.Text, txtRstock.Text)
            toDB.updateSC(txtKb1.Text, cmbNC1.Text, txtRstock.Text)
            toDB.mutasiBuku(txtKodeBuku.Text, cmbNamaCabang.Text, txtRstock.Text)
            cmbNC1.Enabled = False
            txtRstock.Enabled = False
            If Label9.Text <> 0 Then
                txtKb2.Text = txtKb1.Text
                cmbNC2.Enabled = True
                btnSU2.Enabled = True
            End If
            btnSU.Enabled = False
        ElseIf txtRstock.Text > txtJumlah.Text Then
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        Else
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        End If
    End Sub

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        If txtKodeBuku.Text <> "" And txtNoPermintaan.Text <> "" And txtNoSurat.Text <> "" And txtTanggal.Text <> "" And cmbNamaCabang.Text <> "" And dtpTanggalPakai.Text <> "" And txtJumlah.Text <> "" Then
            jumlah = txtJumlah.Text
            If btnSP.Text = "Simpan Permintaan" And txtJumlah.Text > 0 Then
                Dim tp As String
                Dim tgl As String
                tgl = txtTanggal.Text
                tp = dtpTanggalPakai.Text
                toDB.SimpanPermintaan(txtNoPermintaan.Text, txtNoSurat.Text, txtKodeBuku.Text, cmbNamaCabang.Text, tgl, tp, txtJumlah.Text)
                cmbNC1.Enabled = True
                btnSU.Enabled = True
                jumlah = txtJumlah.Text
                Label8.Text = jumlah
            ElseIf btnSP.Text = "Simpan Perubahan" Then
                Dim tp As String
                Dim tgl As String
                tgl = txtTanggal.Text
                tp = dtpTanggalPakai.Text
                sisa = jumlah - CInt(Int(txtRstock.Text))
                sisaSC = stockC - CInt(Int(txtRstock.Text))
                sisa2 = sisa
                Label8.Text = sisaSC
                Label9.Text = sisa
                toDB.UpdatePermintaan(txtNoPermintaan.Text, txtNoSurat.Text, txtKodeBuku.Text, cmbNamaCabang.Text, tgl, tp, txtJumlah.Text)
                If txtRstock.Text = "" Then
                    cmbNC1.Enabled = True
                    btnSU.Enabled = True
                ElseIf sisa <> 0 Then
                    Dim s As Integer = txtRstock.Text
                    txtRstock.Text = s
                    cmbNC1.Enabled = False
                    btnSU.Enabled = False
                    cmbNC2.Enabled = True
                    btnSU2.Enabled = True
                End If
               
                jumlah = txtJumlah.Text
                Label8.Text = jumlah
                btnSP.Text = "Simpan Permintaan"
            ElseIf btnSP.Text = "Ubah Data" Then
                Dim result As Integer = MessageBox.Show("Apakah anda Akan Merubah Jumlah permintaan ?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    txtJumlah.Enabled = True
                    btnSP.Text = "Simpan Perubahan"
                End If
            End If
        Else
            MsgBox("Semua data wajib diisi !! Harap Periksa Kembali")
        End If
    End Sub

    Private Sub cmbNC2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNC2.SelectedIndexChanged
        Dim query As String
        If conn.State >= 1 Then
            conn.Close()
            conn.Open()
            query = "select " & cmbNC2.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If sisa <= RD.Item(0) Then
                    txtJstock2.Text = RD.Item(0)
                    txtRstock2.Enabled = True
                Else
                    txtRstock2.Enabled = False
                    txtJstock2.Text = ""
                    MsgBox("stock tidak cukup")
                End If
            End While
        Else
            conn.Close()
            conn.Open()
            query = "select " & cmbNC2.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If sisa <= RD.Item(0) Then
                    txtJstock2.Text = RD.Item(0)
                    txtRstock2.Enabled = True
                ElseIf txtJumlah.Text > RD.Item(0) Then
                    txtJstock2.Text = ""
                    txtRstock2.Enabled = False
                    MsgBox("stock tidak cukup")

                End If
            End While

        End If
    End Sub

    Private Sub cmbNc3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNc3.SelectedIndexChanged
        Dim query As String
        If conn.State >= 1 Then
            conn.Close()
            conn.Open()
            query = "select " & cmbNc3.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If sisa <= RD.Item(0) Then
                    txtJstock3.Text = RD.Item(0)
                    txtRstock3.Enabled = True
                Else
                    txtRstock3.Enabled = False
                    txtJstock3.Text = ""
                    MsgBox("stock tidak cukup")
                End If
            End While
        Else
            conn.Close()
            conn.Open()
            query = "select " & cmbNc3.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If txtJumlah.Text < RD.Item(0) Then
                    txtJstock3.Text = RD.Item(0)
                    txtRstock3.Enabled = True
                ElseIf txtJumlah.Text > RD.Item(0) Then
                    txtJstock3.Text = ""
                    txtRstock3.Enabled = False
                    MsgBox("stock tidak cukup")

                End If
            End While

        End If
    End Sub

    Private Sub cmbNC4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNC4.SelectedIndexChanged
        Dim query As String
        If conn.State >= 1 Then
            conn.Close()
            conn.Open()
            query = "select " & cmbNC4.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If sisa <= RD.Item(0) Then
                    txtJstock4.Text = RD.Item(0)
                    txtRstock4.Enabled = True
                Else
                    txtRstock4.Enabled = False
                    txtJstock4.Text = ""
                    MsgBox("stock tidak cukup")
                End If
            End While
        Else
            conn.Close()
            conn.Open()
            query = "select " & cmbNC4.Text & " from dummyStock where kodeBuku='" + txtKb1.Text + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                If txtJumlah.Text < RD.Item(0) Then
                    txtJstock4.Text = RD.Item(0)
                    txtRstock4.Enabled = True
                ElseIf txtJumlah.Text > RD.Item(0) Then
                    txtJstock4.Text = ""
                    txtRstock4.Enabled = False
                    MsgBox("stock tidak cukup")

                End If
            End While

        End If
    End Sub

    Private Sub txtRstock2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRstock2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtRstock2_TextChanged(sender As Object, e As EventArgs) Handles txtRstock2.TextChanged
        If sisa2 <> 0 And txtRstock2.Text.Length > 0 Then
            sisa = sisa2 - CInt(Int(txtRstock2.Text))
            sisaSC = stockC - CInt(Int(txtRstock2.Text))
            sisa3 = sisa
            Label8.Text = sisaSC
            Label9.Text = sisa
        Else
            MsgBox("Jumlah Mutasi Tidak boleh kosong / 0 !!")
            sisa = sisa2
        End If
    End Sub

    Private Sub btnSU2_Click(sender As Object, e As EventArgs) Handles btnSU2.Click
        If txtRstock2.Text <= Label9.Text Or txtRstock2.Text <> 0 Then
            toDB.SimpanDetailPermintaan(txtNoPermintaan.Text, cmbNC2.Text, txtRstock2.Text)
            toDB.updateSC(txtKb1.Text, cmbNC2.Text, txtRstock2.Text)
            toDB.mutasiBuku(txtKodeBuku.Text, cmbNamaCabang.Text, txtRstock2.Text)
            cmbNC2.Enabled = False
            txtRstock2.Enabled = False
            If Label9.Text <> 0 Then
                txtKb3.Text = txtKb1.Text
                cmbNc3.Enabled = True
            End If
            btnSU2.Enabled = False
        ElseIf txtRstock2.Text > sisa Then
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        Else
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        End If
    End Sub

    Private Sub txtRstock3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRstock3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtRstock3_TextChanged(sender As Object, e As EventArgs) Handles txtRstock3.TextChanged
        If txtRstock3.Text.Length > 0 And sisa3 <> 0 Then
            sisa = sisa2 - CInt(Int(txtRstock2.Text))
            sisaSC = stockC - CInt(Int(txtRstock2.Text))
            sisa3 = sisa
            Label8.Text = sisaSC
            Label9.Text = sisa
        Else
            MsgBox("Jumlah Mutasi Tidak boleh kosong / 0 !!")
            sisa = sisa3
        End If
    End Sub

    Private Sub txtRstock4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRstock4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtRstock4_TextChanged(sender As Object, e As EventArgs) Handles txtRstock4.TextChanged
        If txtRstock4.Text.Length > 0 And sisa4 <> 0 Then
            sisa = sisa3 - CInt(Int(txtRstock2.Text))
            sisaSC = stockC - CInt(Int(txtRstock2.Text))
            sisa4 = sisa
            Label8.Text = sisaSC
            Label9.Text = sisa
        Else
            MsgBox("Jumlah Mutasi Tidak boleh kosong / 0 !!")
            sisa = sisa4
        End If
    End Sub

    Private Sub btnSu3_Click(sender As Object, e As EventArgs) Handles btnSu3.Click
        If txtRstock3.Text <= Label9.Text Or txtRstock3.Text <> 0 Then
            toDB.SimpanDetailPermintaan(txtNoPermintaan.Text, cmbNc3.Text, txtRstock3.Text)
            toDB.updateSC(txtKb1.Text, cmbNc3.Text, txtRstock3.Text)
            toDB.mutasiBuku(txtKodeBuku.Text, cmbNamaCabang.Text, txtRstock3.Text)
            cmbNc3.Enabled = False
            txtRstock3.Enabled = False
            If Label9.Text <> 0 Then
                txtKb4.Text = txtKb1.Text
                cmbNC4.Enabled = True
            End If
            btnSu3.Enabled = False
        ElseIf txtRstock3.Text > sisa Then
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        Else
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        End If

    End Sub

    Private Sub btnSu4_Click(sender As Object, e As EventArgs) Handles btnSu4.Click
        If txtRstock4.Text <= Label9.Text Or txtRstock4.Text <> 0 Then
            toDB.SimpanDetailPermintaan(txtNoPermintaan.Text, cmbNC4.Text, txtRstock4.Text)
            toDB.updateSC(txtKb1.Text, cmbNC4.Text, txtRstock4.Text)
            toDB.mutasiBuku(txtKodeBuku.Text, cmbNamaCabang.Text, txtRstock4.Text)
            cmbNC4.Enabled = False
            txtRstock4.Enabled = False
            If Label9.Text <> 0 Then
                txtKb4.Text = txtKb1.Text
                cmbNC4.Enabled = True
            End If
            btnSu4.Enabled = False
        ElseIf txtRstock4.Text > sisa Then
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        Else
            MsgBox("Jumlah Permintaan yang anda input tidak sesuai")
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
      
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        def()
        dis()
        btnCari.Text = "Cari"
    End Sub
    Sub def()

        For Each txt In {txtNoPermintaan, txtNoSurat, txtJumlah, cmbNamaCabang, cmbNC1, cmbNC2, cmbNc3, cmbNC4, txtRstock, txtRstock2, txtRstock3, txtRstock4, txtKb1, txtKb2, txtKb3, txtKb4, txtJstock, txtJstock2, txtJstock3, txtJstock4}
            RemoveHandler txtKb1.TextChanged, AddressOf txtKb1_TextChanged
            RemoveHandler txtRstock.TextChanged, AddressOf txtRstock_TextChanged
            RemoveHandler txtRstock2.TextChanged, AddressOf txtRstock2_TextChanged
            RemoveHandler txtRstock3.TextChanged, AddressOf txtRstock3_TextChanged
            RemoveHandler txtRstock4.TextChanged, AddressOf txtRstock4_TextChanged
            RemoveHandler txtJstock.TextChanged, AddressOf txtJstock_TextChanged
            txt.Text = ""
            btnCari.Text = "Cari"
            AddHandler txtKb1.TextChanged, AddressOf txtKb1_TextChanged
            AddHandler txtRstock.TextChanged, AddressOf txtRstock_TextChanged
            AddHandler txtRstock2.TextChanged, AddressOf txtRstock2_TextChanged
            AddHandler txtRstock3.TextChanged, AddressOf txtRstock3_TextChanged
            RemoveHandler txtRstock4.TextChanged, AddressOf txtRstock4_TextChanged
        Next
    End Sub

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs) Handles Label9.TextChanged
        If Label9.Text = 0 Then
            btnBaru.Enabled = True
        End If
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Me.Close()
        Buku.Show()
    End Sub

    Private Sub CabangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CabangToolStripMenuItem.Click
        Me.Close()
        Cabang.Show()
    End Sub

    Private Sub InputStockCabangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputStockCabangToolStripMenuItem.Click
        Me.Close()
        StockN.Show()
    End Sub

    Private Sub PermintaanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermintaanBukuToolStripMenuItem.Click
        Me.Refresh()
    End Sub
    Sub def2()
        For Each txt In {cmbNC1, cmbNC2, cmbNc3, cmbNC4, txtRstock, txtRstock2, txtRstock3, txtRstock4, txtKb1, txtKb2, txtKb3, txtKb4, txtJstock, txtJstock2, txtJstock3, txtJstock4}
            RemoveHandler txtKb1.TextChanged, AddressOf txtKb1_TextChanged
            RemoveHandler txtRstock.TextChanged, AddressOf txtRstock_TextChanged
            RemoveHandler txtRstock2.TextChanged, AddressOf txtRstock2_TextChanged
            RemoveHandler txtRstock3.TextChanged, AddressOf txtRstock3_TextChanged
            RemoveHandler txtRstock4.TextChanged, AddressOf txtRstock4_TextChanged
            RemoveHandler txtJstock.TextChanged, AddressOf txtJstock_TextChanged
            txt.Text = ""
            txt.enabled = False
            AddHandler txtKb1.TextChanged, AddressOf txtKb1_TextChanged
            AddHandler txtRstock.TextChanged, AddressOf txtRstock_TextChanged
            AddHandler txtRstock2.TextChanged, AddressOf txtRstock2_TextChanged
            AddHandler txtRstock3.TextChanged, AddressOf txtRstock3_TextChanged
            RemoveHandler txtRstock4.TextChanged, AddressOf txtRstock4_TextChanged
        Next
    End Sub

    
    Private Sub LaporanPermintaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPermintaanToolStripMenuItem.Click
        Me.Close()
        LPermintaan.Show()
    End Sub

    Private Sub cmbNamaCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaCabang.SelectedIndexChanged
        itemCombo3(cmbNamaCabang.Text)
    End Sub
End Class