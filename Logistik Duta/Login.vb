Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        cmbHakAkses.Items.Add("Admin")
        cmbHakAkses.Items.Add("Gudang1")
        cmbHakAkses.Items.Add("Gudang2")
        cmbHakAkses.Items.Add("Staff")
        cmbHakAkses.Items.Add("Request Only")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        cekLogin(txtUname.Text, txtPass.Text, cmbHakAkses.Text)
    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Me.Hide()
        Daftar.Show()
    End Sub
End Class