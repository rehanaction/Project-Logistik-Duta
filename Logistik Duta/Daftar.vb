Public Class Daftar
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPass.Text <> "" And txtUname.Text <> "" And cmbHakAkses.Text <> "" Then
            daftarUser(txtUname.Text, txtPass.Text, cmbHakAkses.Text)
        Else
            MessageBox.Show("Username,Password Dan Hak Akses Wajib Diisi", "Konfrimasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        cmbHakAkses.Items.Add("Gudang1")
        cmbHakAkses.Items.Add("Gudang2")
        cmbHakAkses.Items.Add("Staff")
        cmbHakAkses.Items.Add("Request Only")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class