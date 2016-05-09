Public Class UserManagement
    Private Sub btnSuspend_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click
        If txtUname.Text <> "" Then
            UserActivasion(btnSuspend.Text, txtUname.Text)
            user()
        Else
            MessageBox.Show("Pilih terlebih Dahulus User Yang akan Di Suspend ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub PrivilageList()
        Dim cols As New DataGridViewComboBoxColumn
        cols.MaxDropDownItems = 5
        cols.Items.Add("Admin")
        cols.Items.Add("Gudang1")
        cols.Items.Add("Gudang2")
        cols.Items.Add("Staff")
        cols.Items.Add("Request Only")
        dgvUser.Columns.Add(cols)
        cols.HeaderText = "User Privilage"
        ' buat header text
        cols.Width = 75
        ' atur lebar kolom

    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toDB.koneksi()
        user()
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick

    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Dim i As Integer
        i = dgvUser.CurrentRow.Index
        txtUname.Text = dgvUser.Item(0, i).Value
    End Sub

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtUname.TextChanged
        btnSuspend.Enabled = True
        BtnActive.Enabled = True
    End Sub

    Private Sub BtnActive_Click(sender As Object, e As EventArgs) Handles BtnActive.Click
        If txtUname.Text <> "" Then
            UserActivasion(BtnActive.Text, txtUname.Text)
            user()
        Else
            MessageBox.Show("Pilih terlebih Dahulus User Yang akan Di Aktifkan ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class