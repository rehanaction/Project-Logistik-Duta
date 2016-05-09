Public Class MenuAwal
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Buku.Show()
    End Sub

    Private Sub CabangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CabangToolStripMenuItem.Click
        Cabang.Show()
    End Sub

    Private Sub InputStockCabangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputStockCabangToolStripMenuItem.Click
        StockN.Show()
    End Sub
    Private Sub MenuAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim q As String
        Try
            q = "Select Current_Date"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(q, conn)
            RD = CMD.ExecuteReader()
            RD.Read()
            Dim tgl, exp As New Date
            tgl = Date.Now.Date.ToString
            exp = "2016-08-17"
            If RD("CURRENT_DATE") > exp Then
                MsgBox("Aplikasi Sudah Expired harap hubungi Developer :)")
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Private Sub DataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMasterToolStripMenuItem.Click

    End Sub
    Private Sub MenuAwal_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub
    Private Sub PermintaanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Permintaan.Show()
    End Sub

    Private Sub LaporanPermintaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPermintaanToolStripMenuItem.Click
        LPermintaan.Show()
    End Sub
    Private Sub Permintaan2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Permintaan2ToolStripMenuItem.Click
        RequestBook.Show()
    End Sub

    Private Sub CompareSalesDistribusiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompareSalesDistribusiToolStripMenuItem.Click
        compareMyob.Show()
    End Sub
    Private Sub DistribusiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribusiToolStripMenuItem.Click
        Compare.Show()
    End Sub

    Private Sub MenuAwal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub UserActivityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserActivityToolStripMenuItem.Click
        UserManagement.Show()
    End Sub
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Date.Now().ToString("dd MMM yyyy - HH:mm:ss")
    End Sub


End Class