Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Globalization

Module toDB
    Public conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DS, SDS As New DataSet
    Public DA, SDA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public dt As DataTable
    Public lokasiData As String
    Private bindingSource1 As New BindingSource()
    Public Sub koneksi()
        lokasiData = "Server=192.168.1.88;user id=duta;password=duta1234;database=duta;"
        Try
            conn = New MySqlConnection(lokasiData)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub
    Public Sub autoKomplete()
        If conn.State = 1 Then
            conn.Close()
            CMD = New MySqlCommand("select cabang from suratJalan", conn)
            DA = New MySqlDataAdapter(CMD)
            dt = New DataTable
            conn.Open()
            DA.Fill(dt)
            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1
                col.Add(dt.Rows(i)("cabang"))
            Next
            compareMyob.txtNamacabang.AutoCompleteSource = AutoCompleteSource.CustomSource
            compareMyob.txtNamacabang.AutoCompleteCustomSource = col
            compareMyob.txtNamacabang.AutoCompleteMode = AutoCompleteMode.Suggest
        End If
    End Sub
    Public Sub getID(ByVal nc As String)
        Dim query As String
        If conn.State >= 1 Then
            conn.Close()
            conn.Open()
            query = "select idCabang from ListCabang where namaCabang='" + nc + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                StockN.lblID.Text = RD.Item(0)
            End While
        Else
            conn.Close()
            conn.Open()
            query = "select idCabang from ListCabang where namaCabang='" + nc + "'"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                StockN.lblID.Text = RD.Item(0)
            End While
        End If
    End Sub
    Public Sub simpanBuku(ByVal kb As String, ByVal judul As String, ByVal jilid As String, ByVal jenjang As String, ByVal category As String, ByVal perdus As String)
        If conn.State = 1 Then
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from buku where kodeBuku='" & kb & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into buku (kodeBuku,judul,jilid,jenjang,category,perdus) values('" & kb & "','" & judul & "','" & jilid & "','" & jenjang & "','" & category & "','" & perdus & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()
            Else
                conn.Close()
                conn.Open()

                Try
                    Dim edit As String
                    edit = "update buku set judul='" & judul & "', jenjang='" & jenjang & "', jilid='" & jilid & "', category='" & category & "', perdus='" & perdus & "' where kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()
            End If
        Else
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from buku where kodeBuku='" & kb & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into buku  (kodeBuku,judul,jilid,jenjang,category,perdus) values('" & kb & "','" & judul & "','" & jilid & "','" & jenjang & "','" & category & "','" & perdus & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Try
                    Dim edit As String
                    edit = "update buku set judul='" & judul & "', jenjang='" & jenjang & "', jilid='" & jilid & "', category='" & category & "',perdus='" & perdus & "' where kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()
            End If
        End If
    End Sub
    Public Sub SimpanCabang(ByVal nc As String, ByVal ac As String, ByVal tlp As String)
        If conn.State = 1 Then
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from ListCabang where namaCabang LIKE '%" & nc & "%'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into ListCabang values('" & nc & "','" & ac & "','" & tlp & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    Dim com As New MySqlCommand("ALTER TABLE dummyStock ADD " & nc & " decimal", conn)
                    com.ExecuteNonQuery()
                    com.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Try
                    Dim edit As String
                    edit = "update ListCabang set alamat='" & ac & "',telp='" & tlp & "' where namaCabang LIKE '%" & nc & "%'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()


            End If
        Else
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from ListCabang where namaCabang LIKE '%" & nc & "%'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into ListCabang values('" & nc & "','" & ac & "','" & tlp & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    Dim com As New MySqlCommand("ALTER TABLE dummyStock ADD " & nc & " decimal", conn)
                    com.ExecuteNonQuery()
                    com.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Try
                    Dim edit As String
                    edit = "update ListCabang set alamat='" & ac & "',telp='" & tlp & "' where namaCabang LIKE '%" & nc & "%'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()


            End If
        End If
    End Sub
    Public Sub SimpanStockCabang(ByVal kb As String, ByVal ic As String, ByVal qty As String, ByVal field As String)
        If conn.State = 1 Then
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from dummyStock where kodeBuku='" & kb & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into dummyStock (kodeBuku,idCabang," & field & ") values('" & kb & "','" & ic & "','" & qty & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Try
                    Dim edit As String
                    edit = "update dummyStock set " & field & "='" & qty & "' where kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()


            End If
        Else
            conn.Close()
            conn.Open()
            CMD = New MySqlCommand("Select * from dummyStock where kodeBuku='" & kb & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                conn.Close()
                conn.Open()
                Try
                    Dim simpan As String = "insert into dummyStock (kodeBuku,idCabang," & field & ") values('" & kb & "','" & ic & "','" & qty & "')"
                    CMD = New MySqlCommand(simpan, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()
            Else
                conn.Close()
                conn.Open()
                Try
                    Dim edit As String
                    edit = "update dummyStock set " & field & "='" & qty & "' where kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(edit, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                conn.Close()
            End If

        End If


    End Sub
    Public Sub simpanStockNasional(ByVal kb As String, ByVal qty As String, ByVal field As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from dummyStock where kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            conn.Close()
            conn.Open()
            conn.Close()
            conn.Open()
            Try
                Dim edit As String
                edit = "update dummyStock set " & field & "='" & qty & "' where kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            conn.Close()
        End If
    End Sub
    Public Sub itemCombo()

        Dim query As String
        'Dim a As Integer
        query = "select namaCabang from ListCabang ORDER BY namaCabang asc"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            StockN.cmbCabang.Items.Add(RD.Item(0))
        End While


    End Sub
    Public Sub itemCombo2()

        Dim query As String
        'Dim a As Integer
        query = "select namaCabang from ListCabang"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            Permintaan.cmbNamaCabang.Items.Add(RD.Item(0))
        End While


    End Sub
    Public Sub itemCombo3(ByVal req As String)
        RD.Close()
        conn.Open()
        Dim query As String
        'Dim a As Integer
        query = "select namaCabang from ListCabang where namaCabang<>'" & req & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            Permintaan.cmbNC1.Items.Add(RD.Item(0))
            Permintaan.cmbNC2.Items.Add(RD.Item(0))
            Permintaan.cmbNc3.Items.Add(RD.Item(0))
            Permintaan.cmbNC4.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Sub itemCombo4()
        RD.Close()
        conn.Open()
        Dim query As String
        'Dim a As Integer
        query = "select namaCabang from ListCabang ORDER BY namaCabang ASC"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            RequestBook.cmbNamacabang.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Sub RefreshDataView()
        If conn.State = 1 Then
            conn.Close()
            DA = New MySqlDataAdapter(
                                    "select b.kodeBuku,b.judul,b.jenjang,b.category,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Serang,0)+COALESCE(sc.Tanggerang,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) ", conn)
            conn.Open()
            DS.Reset()
            DS.Tables.Clear()
            DS.Clear()
            DA.Fill(DS)
            StockN.DataGridView1.DataSource = DS.Tables(0)
            StockN.DataGridView1.Columns.Remove("id")
            StockN.DataGridView1.Columns.Remove("idCabang")
            StockN.DataGridView1.Columns.Remove("kodeBuku1")
            StockN.DataGridView1.Columns.Remove("Denpasar")
            conn.Close()
        Else
            DA = New MySqlDataAdapter(
                                    "select b.kodeBuku,b.judul,b.jenjang,b.category,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Serang,0)+COALESCE(sc.Tanggerang,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) ", conn)
            conn.Open()
            DS.Reset()
            DS.Tables.Clear()
            DS.Clear()
            DA.Fill(DS)
            StockN.DataGridView1.DataSource = DS.Tables(0)
            StockN.DataGridView1.Columns.Remove("id")
            StockN.DataGridView1.Columns.Remove("idCabang")
            StockN.DataGridView1.Columns.Remove("kodeBuku1")
            StockN.DataGridView1.Columns.Remove("Denpasar")
            conn.Close()
        End If
    End Sub
    Sub ViewBuku()
        If conn.State = 1 Then
            conn.Close()
            DA = New MySqlDataAdapter("select * from buku", conn)
            conn.Open()
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Buku.bukuGridView.DataSource = DS.Tables(0)
            conn.Close()
        Else
            DA = New MySqlDataAdapter("select * from buku", conn)
            conn.Open()
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Buku.bukuGridView.DataSource = DS.Tables(0)
            conn.Close()
        End If
    End Sub
    Sub ViewCabang()
        If conn.State = 1 Then
            conn.Close()
            DA = New MySqlDataAdapter("select * from ListCabang", conn)
            conn.Open()
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Cabang.CabangGridView.DataSource = DS.Tables(0)
            conn.Close()
        Else
            DA = New MySqlDataAdapter("select * from ListCabang", conn)
            conn.Open()
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            Cabang.CabangGridView.DataSource = DS.Tables(0)
            conn.Close()
        End If
    End Sub
    Public Sub Cari(ByVal criteria As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        If StockN.rbtKodeBuku.Checked = True Then
            DA = New MySqlDataAdapter("select b.*,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Serang,0)+COALESCE(sc.Tanggerang,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku=@kb", conn)
            DA.SelectCommand.Parameters.AddWithValue("@kb", criteria)
            Dim dt As New DataTable
            Try
                DS.Reset()
                DS.Clear()
                DS.Tables.Clear()
                DA.Fill(DS)
                StockN.DataGridView1.DataSource = DS.Tables(0)
                StockN.DataGridView1.Columns.Remove("id")
                StockN.DataGridView1.Columns.Remove("idCabang")
                StockN.DataGridView1.Columns.Remove("kodeBuku1")
                StockN.DataGridView1.Columns.Remove("Denpasar")
                StockN.DataGridView1.Columns.Remove("bobot")
                StockN.DataGridView1.Columns.Remove("perdus")
            Catch ex As Exception
                ' tampilkan pesan error
                MessageBox.Show(ex.Message)
            End Try
        ElseIf StockN.RbtnJudulBuku.Checked = True Then

            DA = New MySqlDataAdapter("select b.*,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Serang,0)+COALESCE(sc.Tanggerang,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.judul=@jd", conn)
            DA.SelectCommand.Parameters.AddWithValue("@jd", criteria)

                Dim dt As New DataTable
                ' enclose di dalam try-catch block
                ' untuk menghindari crash jika terjadi kesalahan database
                Try
                    DS.Reset()
                    DS.Clear()
                    DS.Tables.Clear()
                    DA.Fill(DS)
                    StockN.DataGridView1.DataSource = DS.Tables(0)
                StockN.DataGridView1.Columns.Remove("id")
                StockN.DataGridView1.Columns.Remove("idCabang")
                StockN.DataGridView1.Columns.Remove("kodeBuku1")
                StockN.DataGridView1.Columns.Remove("Denpasar")
                StockN.DataGridView1.Columns.Remove("bobot")
                StockN.DataGridView1.Columns.Remove("perdus")
            Catch ex As Exception
                    ' tampilkan pesan error
                    MessageBox.Show(ex.Message)
                End Try
            End If
        conn.Close()

    End Sub
    Public Sub getSum(ByVal kb As String, ByVal jd As String)
        Dim query As String
        If conn.State = 1 Then
            conn.Close()
            conn.Open()
            If kb <> "" And jd <> "" Then

                query = "select sum(stock) as tot from stockCabang sc join buku b on sc.kodeBuku=b.kodeBuku where sc.kodeBuku='" & kb & "' and b.Judul LIKE '%" & jd & "%'"
                CMD = New MySqlCommand(query, conn)
                RD = CMD.ExecuteReader
                RD.Read()
                'StockN.txtSum.Text = RD("tot")
                ' StockN.lblSt.Text = "Stock Nasional buku '" & jd & "' kode '" & kb & "' "
            ElseIf kb <> "" And jd = "" Then
                query = "select sum(stock) as tot from stockCabang sc join buku b on sc.kodeBuku=b.kodeBuku where sc.kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(query, conn)
                RD = CMD.ExecuteReader
                RD.Read()
                'StockN.txtSum.Text = RD("tot")
                'StockN.lblSt.Text = "Stock Nasional buku '" & jd & "' kode '" & kb & "' "
            ElseIf kb = "" And jd <> "" Then
                query = "select sum(stock) as tot from stockCabang sc join buku b on sc.kodeBuku=b.kodeBuku where b.Judul LIKE '%" & jd & "%'"
                CMD = New MySqlCommand(query, conn)
                RD = CMD.ExecuteReader
                RD.Read()
                'StockN.txtSum.Text = RD("tot")
                'StockN.lblSt.Text = "Stock Nasional '" + jd + "' kode '" & kb & "' "
            End If
        End If
    End Sub
    Public Sub CariPermintaan(ByVal kb As String)
        If conn.State = 1 Then
            conn.Close()

            If kb <> "" Then
                conn.Open()
                CMD = New MySqlCommand("select b.kodeBuku,b.judul,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+ISNULL(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+CAOLESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku='" & kb & "' ", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    conn.Close()
                    conn.Open()
                    DA = New MySqlDataAdapter("select b.kodeBuku,b.judul,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku=@kb ", conn)
                    DA.SelectCommand.Parameters.AddWithValue("@kb", kb)
                    Dim dt As New DataTable
                    Try
                        DS.Reset()
                        DS.Clear()
                        DS.Tables.Clear()
                        DA.Fill(DS)
                        Permintaan.DataGridView1.DataSource = DS.Tables(0)
                        Permintaan.DataGridView1.Columns("id").Visible = False
                        Permintaan.DataGridView1.Columns("idCabang").Visible = False
                        Permintaan.DataGridView1.Columns("kodeBuku1").Visible = False
                        Permintaan.DataGridView1.Columns("Denpasar").Visible = False
                    Catch ex As Exception
                        ' tampilkan pesan error
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Periksa Kembali Kode Buku Yang Anda Input", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Kode Buku Harap Diisi", MsgBoxStyle.Information)
            End If
        Else
            conn.Close()
            If kb <> "" Then
                conn.Open()
                CMD = New MySqlCommand("select b.kodeBuku,b.judul,sc.*,(ISNULL(sc.Surabaya,0)+ISNULL(sc.Bandung,0)+ISNULL(sc.solo,0)+ISNULL(sc.pusat,0)+ISNULL(sc.Tasikmalaya,0)+ISNULL(sc.Cirebon,0)+ISNULL(sc.Bali,0)+ISNULL(sc.Praya,0)+ISNULL(sc.Mataram,0)+ISNULL(sc.Jakarta,0)+ISNULL(sc.Bekasi,0)+ISNULL(sc.Bogor,0)+ISNULL(sc.Depok,0)+ISNULL(sc.Jember,0)+ISNULL(sc.Lampung,0)+ISNULL(sc.Madiun,0)+ISNULL(sc.Makassar,0)+ISNULL(sc.Malang,0)+ISNULL(sc.Kediri,0)+ISNULL(sc.Medan,0)+ISNULL(sc.Padang,0)+ISNULL(sc.Palembang,0)+ISNULL(sc.Semarang,0)+ISNULL(sc.Bangkalan,0)+ISNULL(sc.Pamekasan,0)+ISNULL(sc.Sidoarjo,0)+ISNULL(sc.Yogyakarta,0)+ISNULL(sc.Purwokerto,0)+ISNULL(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku='" & kb & "' ", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    conn.Close()
                    conn.Open()
                    DA = New MySqlDataAdapter("select b.kodeBuku,b.judul,sc.*,(ISNULL(sc.Surabaya,0)+ISNULL(sc.Bandung,0)+ISNULL(sc.solo,0)+ISNULL(sc.pusat,0)+ISNULL(sc.Tasikmalaya,0)+ISNULL(sc.Cirebon,0)+ISNULL(sc.Bali,0)+ISNULL(sc.Praya,0)+ISNULL(sc.Mataram,0)+ISNULL(sc.Jakarta,0)+ISNULL(sc.Bekasi,0)+ISNULL(sc.Bogor,0)+ISNULL(sc.Depok,0)+ISNULL(sc.Jember,0)+ISNULL(sc.Lampung,0)+ISNULL(sc.Madiun,0)+ISNULL(sc.Makassar,0)+ISNULL(sc.Malang,0)+ISNULL(sc.Kediri,0)+ISNULL(sc.Medan,0)+ISNULL(sc.Padang,0)+ISNULL(sc.Palembang,0)+ISNULL(sc.Semarang,0)+ISNULL(sc.Bangkalan,0)+ISNULL(sc.Pamekasan,0)+ISNULL(sc.Sidoarjo,0)+ISNULL(sc.Yogyakarta,0)+ISNULL(sc.Purwokerto,0)+ISNULL(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku=@kb ", conn)
                    DA.SelectCommand.Parameters.AddWithValue("@kb", kb)
                    Dim dt As New DataTable
                    Try
                        DS.Reset()
                        DS.Clear()
                        DS.Tables.Clear()
                        DA.Fill(DS)
                        Permintaan.DataGridView1.DataSource = DS.Tables(0)
                        Permintaan.DataGridView1.Columns("id").Visible = False
                        Permintaan.DataGridView1.Columns("idCabang").Visible = False
                        Permintaan.DataGridView1.Columns("kodeBuku1").Visible = False
                        Permintaan.DataGridView1.Columns("Denpasar").Visible = False
                    Catch ex As Exception
                        ' tampilkan pesan error
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Periksa Kembali Kode Buku Yang Anda Input", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Kode Buku Harap Diisi", MsgBoxStyle.Information)
            End If

        End If
        conn.Close()
    End Sub
    Public Sub Kodenomor()
        Dim NomOt As String = ""
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
            Try
                CMD = New MySqlCommand("SELECT noPermintaan as nomor FROM Permintaan2 where SUBSTRING(noPermintaan,1,13)='IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "' ORDER BY nomor DESC LIMIT 1", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    Dim num, ss As String
                    num = RD!nomor
                    ss = num.Substring(14, 3)
                    Select Case Convert.ToDouble(ss)
                        Case Is <= 9
                            NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/00" & Convert.ToDouble(ss) + 1
                        Case Is <= 99
                            NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/0" & Convert.ToDouble(ss) + 1
                    End Select
                Else
                    NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/001"
                End If
                RequestBook.txtNoP.Text = NomOt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            conn.Close()
            conn.Open()
            Try
                CMD = New MySqlCommand("SELECT noPermintaan as nomor FROM Permintaan2 where SUBSTRING(noPermintaan,1,13)='IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "' ORDER BY nomor DESC LIMIT 1", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    Dim num, ss As String
                    num = RD!nomor
                    ss = num.Substring(13, 3)
                    Select Case Convert.ToDouble(ss)
                        Case Is <= 9
                            NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/00" & Convert.ToDouble(ss) + 1
                        Case Is <= 99
                            NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/0" & Convert.ToDouble(ss) + 1
                    End Select
                Else
                    NomOt = "IR/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/001"
                End If
                RequestBook.txtNoP.Text = NomOt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub nomoSurat()
        Dim NomOt As String = ""
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
            Try
                CMD = New MySqlCommand("SELECT noSurat as nomor FROM Permintaan2 where SUBSTRING(noSurat,1,14)='SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "' ORDER BY nomor DESC LIMIT 1 ", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    Dim num, ss As String
                    num = RD!nomor
                    ss = num.Substring(15, 3)
                    Select Case Convert.ToDouble(ss)
                        Case Is <= 9
                            NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/00" & Convert.ToDouble(ss) + 1
                        Case Is <= 99
                            NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/0" & Convert.ToDouble(ss) + 1
                    End Select
                Else
                    NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/001"
                End If
                RequestBook.txtNoSurat.Text = NomOt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            conn.Close()
            conn.Open()
            Try
                CMD = New MySqlCommand("SELECT noSurat as nomor FROM Permintaan2 where SUBSTRING(noSurat,1,14)='SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "' ORDER BY nomor DESC LIMIT 1 ", conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    Dim num, ss As String
                    num = RD!nomor
                    ss = num.Substring(15, 3)
                    Select Case Convert.ToDouble(ss)
                        Case Is <= 9
                            NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/00" & Convert.ToDouble(ss) + 1
                        Case Is <= 99
                            NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/0" & Convert.ToDouble(ss) + 1
                    End Select
                Else
                    NomOt = "SRT/" & Date.Now().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "/001"
                End If
                RequestBook.txtNoSurat.Text = NomOt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub SimpanPermintaan(ByVal np As String, ByVal ns As String, ByVal kb As String, ByVal nc As String, ByVal tgl As Date, ByVal tp As Date, ByVal j As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim result As Integer = MessageBox.Show("Setelah data tersimpan data tidak dapat dirubah apakah anda yakin ?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim simpan As String = "insert into Permintaan values('" & np & "','" & ns & "','" & kb & "','" & nc & "','" & tgl & "','" & tp & "','" & j & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data tersimpan !!")
                Permintaan.txtNoPermintaan.Enabled = False
                Permintaan.txtNoSurat.Enabled = False
                Permintaan.btnSP.Text = "Ubah Data"
                Permintaan.txtJumlah.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub UpdatePermintaan(ByVal np As String, ByVal ns As String, ByVal kb As String, ByVal nc As String, ByVal tgl As Date, ByVal tp As Date, ByVal j As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Try
            Dim update As String = "update permintaan set namaCabang='" & nc & "',jumlah='" & j & "',kodeBuku='" & kb & "',Tanggal='" & tgl & "',tanggalPakai='" & tp & "' where noPermintaan='" & np & "'"
            CMD = New MySqlCommand(update, conn)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Data tersimpan !!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Public Sub SimpanDetailPermintaan(ByVal np As String, ByVal nc As String, ByVal j As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Try
            Dim simpan As String = "insert into detailpermintaan values('" & np & "','" & nc & "','" & j & "')"
            CMD = New MySqlCommand(simpan, conn)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Public Sub updateSC(ByVal kb As String, ByVal nc As String, ByVal j As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select " & nc & " from dummyStock where kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim sc As Double = RD(nc)
        Dim tot As Double = sc - CInt(Int(j))
        If RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim edit As String
                edit = "update dummyStock set " & nc & "='" & tot & "' where kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub mutasiBuku(ByVal kb As String, ByVal nc As String, ByVal j As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select COALESCE(" & nc & ",0) as " & nc & " from dummyStock where kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()

        Dim sc As Double = RD(nc)
        Dim tot As Double = sc + CInt(Int(j))
        If RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim edit As String
                edit = "update dummyStock set " & nc & "='" & tot & "' where kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub ViewPermintaan(ByVal np As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from Permintaan2 p join detaipermintaan2 dp on p.noPermintaan=dp.noPermintaan where p.noPermintaan='" & np & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LPermintaan.txtNoSurat.Text = RD("noSurat")
            LPermintaan.txtNamaCabang.Text = RD("namacabang")
            LPermintaan.txtTanggal.Text = RD("tPermintaan")
            LPermintaan.txtTglPakai.Text = RD("tPakai")
            codeBookL(RD("noPermintaan"))
            RD.Close()
            DA = New MySqlDataAdapter("select b.kodeBuku,b.judul,dp.jPermintaan,dp.keterangan from detaiPermintaan2 dp join buku b on dp.kodeBuku=b.kodeBuku where noPermintaan='" & np & "'", conn)
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            LPermintaan.dgvLPermintaan.DataSource = DS.Tables(0)
            LPermintaan.DataGridView1.DataSource = Nothing
            LPermintaan.cmbKodeBuku.Text = ""
        Else
            MsgBox("No Permintaan Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
        conn.Close()
    End Sub
    Public Sub ViewPermintaanBykodebuku(ByVal kb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim total As Decimal
        DA = New MySqlDataAdapter("select b.kodeBuku,b.judul,p.namaCabang as Nama_Cabang,dp.jPermintaan from Permintaan2 p join detaipermintaan2 dp on p.noPermintaan=dp.noPermintaan join buku b on dp.kodeBuku=b.kodeBuku where dp.kodeBuku='" & kb & "'", conn)
        DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
        LPermintaan.dgvLPermintaan.DataSource = DS.Tables(0)
        For i As Integer = 0 To LPermintaan.dgvLPermintaan.Rows.Count - 1
            total = total + LPermintaan.dgvLPermintaan.Rows(i).Cells(3).Value
        Next
        Dim akhir As Integer = LPermintaan.dgvLPermintaan.RowCount - 1
        LPermintaan.dgvLPermintaan.Rows(akhir).Cells(2).Value = "Total"
        LPermintaan.dgvLPermintaan.Rows(akhir).Cells(3).Value = total
        LPermintaan.DataGridView1.DataSource = Nothing
        conn.Close()
    End Sub
    Public Sub detailMutasiPer(ByVal np As String, ByVal kb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        SDA = New MySqlDataAdapter("select b.kodeBuku,b.judul,dp.cabang as dari,d.namacabang as tujuan,dp.jmutasi as mutasi,b.bobot*dp.jmutasi as Berat,dp.id as Total from MutasiPermintaan dp join buku b on dp.kodeBuku=b.kodeBuku join permintaan2 d on dp.noPermintaan=d.noPermintaan where dp.noPermintaan='" & np & "' and dp.kodeBuku='" & kb & "'", conn)
        SDS.Clear()
        SDS.Tables.Clear()
        SDS.Reset()
        SDA.Fill(SDS)
        LPermintaan.DataGridView1.DataSource = SDS.Tables(0)
        'LPermintaan.btnInputMutasi.Enabled = False
        'If SDS.Tables(0).Rows.Count = 0 Then
        '    LPermintaan.btnInputMutasi.Enabled = True
        'End If
        conn.Close()
    End Sub
    Public Sub detailMutasiPerkomplit(ByVal np As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        SDA = New MySqlDataAdapter("select b.kodeBuku,b.judul,dp.cabang as dari,d.namacabang as tujuan,dp.jmutasi as mutasi,b.bobot*dp.jmutasi as Berat,dp.id as Total from MutasiPermintaan dp join buku b on dp.kodeBuku=b.kodeBuku join permintaan2 d on dp.noPermintaan=d.noPermintaan where dp.noPermintaan='" & np & "'", conn)
        SDS.Clear()
        SDS.Tables.Clear()
        SDS.Reset()
        SDA.Fill(SDS)
        LPermintaan.DataGridView1.DataSource = SDS.Tables(0)
        LPermintaan.btnInputMutasi.Enabled = False
        If SDS.Tables(0).Rows.Count = 0 Then
            LPermintaan.btnInputMutasi.Enabled = True
        End If
        conn.Close()
    End Sub
    Public Sub codeBookL(ByVal np As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select kodeBuku from detaiPermintaan2 where noPermintaan='" & np & "'"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        LPermintaan.cmbKodeBuku.Items.Clear()
        While RD.Read
            LPermintaan.cmbKodeBuku.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Sub permintaandgv()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DA = New MySqlDataAdapter("select b.kodeBuku,b.Judul,b.Jilid,b.jenjang,dp2.jPermintaan as Jumlah from buku b join detaipermintaan2 dp2 on b.kodeBuku=dp2.kodeBuku where noPermintaan='""'", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        RequestBook.dgvPermintaan.DataSource = DS.Tables(0)
        conn.Close()
    End Sub
    Sub ViewBuku2(ByVal param As String, ByVal baris As Integer)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from buku where kodeBuku='" & param & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RequestBook.dgvPermintaan.Rows(baris).Cells(1).Value = RD.Item(1)
            RequestBook.dgvPermintaan.Rows(baris).Cells(2).Value = RD.Item(2)
            RequestBook.dgvPermintaan.Rows(baris).Cells(3).Value = RD.Item(3)
            RequestBook.dgvPermintaan.Rows(baris).Cells(1).ReadOnly = True
            RequestBook.dgvPermintaan.Rows(baris).Cells(2).ReadOnly = True
            RequestBook.dgvPermintaan.Rows(baris).Cells(3).ReadOnly = True
        Else
            MsgBox("No Permintaan Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub savePermin(ByVal np As String, ByVal ns As String, ByVal nc As String, ByVal tper As Date, ByVal tpak As Date)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from permintaan2 where noPermintaan='" & np & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "insert into permintaan2 values('" & np & "','" & ns & "','" & nc & "','" & tper.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "','" & tpak.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "update permintaan2 set namaCabang='" & nc & "', tPermintaan='" & tper.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "',tpakai='" & tpak.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) & "' where noPermintaan='" & np & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub tPermintaan(ByVal np As String, ByVal kb As String, ByVal jp As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from detaipermintaan2 where noPermintaan='" & np & "' and kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "insert into detaipermintaan2(noPermintaan,kodeBuku,jPermintaan,totalMutasi,keterangan) values('" & np & "','" & kb & "','" & jp & "','" & jp & "','Belum Terpenuhi')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "update detaipermintaan2 set jPermintaan='" & jp & "',totalMutasi='" & jp & "' where noPermintaan='" & np & "' and kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub getdataRequest(ByVal np As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from permintaan2 where noPermintaan='" & np & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            BookMutasion.txtNoSurat.Text = RD("noSurat")
            BookMutasion.txtNamaCabang.Text = RD("namaCabang")
            BookMutasion.txtTPer.Text = RD("tPermintaan")
            BookMutasion.txtPakai.Text = RD("tPakai")
            RD.Close()
        Else
            MsgBox("No Surat Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
        conn.Close()
    End Sub
    Public Sub getJper(ByVal np As String, ByVal kb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select jPermintaan,totalMutasi from detaipermintaan2 where noPermintaan='" & np & "' and kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD("jPermintaan") - RD("totalMutasi") = 0 Then
                BookMutasion.txtJPer.Text = RD("jPermintaan")
            Else
                BookMutasion.txtJPer.Text = RD("totalMutasi")
            End If


        Else
                MsgBox("No Surat Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
        conn.Close()
    End Sub
    Public Sub codeBookR(ByVal np As String)
        RD.Close()
        conn.Open()
        Dim query As String
        'Dim a As Integer
        query = "select kodeBuku from detaiPermintaan2 where noPermintaan='" & np & "' and totalMutasi<>0 "
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            BookMutasion.cmbKodeBuku.Items.Clear()
            While RD.Read
                BookMutasion.cmbKodeBuku.Items.Add(RD.Item(0))
            End While
        Else
            BookMutasion.cmbKodeBuku.Items.Clear()
            BookMutasion.btnBatal.Enabled = True
            BookMutasion.btnSimpan.Enabled = False
        End If
        conn.Close()
    End Sub
    Public Sub stockbycodeBook(ByVal kb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DA = New MySqlDataAdapter("select b.kodeBuku,b.judul,sc.*,(COALESCE(sc.Surabaya,0)+COALESCE(sc.Serang,0)+COALESCE(sc.Tanggerang,0)+COALESCE(sc.Bandung,0)+COALESCE(sc.solo,0)+COALESCE(sc.pusat,0)+COALESCE(sc.Tasikmalaya,0)+COALESCE(sc.Cirebon,0)+COALESCE(sc.Bali,0)+COALESCE(sc.Praya,0)+COALESCE(sc.Mataram,0)+COALESCE(sc.Jakarta,0)+COALESCE(sc.Bekasi,0)+COALESCE(sc.Bogor,0)+COALESCE(sc.Depok,0)+COALESCE(sc.Jember,0)+COALESCE(sc.Lampung,0)+COALESCE(sc.Madiun,0)+COALESCE(sc.Makassar,0)+COALESCE(sc.Malang,0)+COALESCE(sc.Kediri,0)+COALESCE(sc.Medan,0)+COALESCE(sc.Padang,0)+COALESCE(sc.Palembang,0)+COALESCE(sc.Semarang,0)+COALESCE(sc.Bangkalan,0)+COALESCE(sc.Pamekasan,0)+COALESCE(sc.Sidoarjo,0)+COALESCE(sc.Yogyakarta,0)+COALESCE(sc.Purwokerto,0)+COALESCE(sc.P_Siantar,0)) as Nasional from buku b join dummyStock sc on(b.kodeBuku=sc.kodeBuku) join ListCabang lb on (sc.idCabang=lb.idcabang) where b.kodeBuku='" & kb & "' ", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        BookMutasion.DataGridView1.DataSource = DS.Tables(0)
        BookMutasion.DataGridView1.Columns("id").Visible = False
        BookMutasion.DataGridView1.Columns("idCabang").Visible = False
        BookMutasion.DataGridView1.Columns("kodeBuku1").Visible = False
        BookMutasion.DataGridView1.Columns("Denpasar").Visible = False
        conn.Close()
    End Sub
    Public Sub mutasidgv()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim cols As New DataGridViewComboBoxColumn
        DA = New MySqlDataAdapter("Select b.kodeBuku,b.Judul,p.namaCabang as Cabang,ds.denpasar as stock,dp.jPermintaan as Permintaan,ds.bandung as mutasi from permintaan2 p join detaipermintaan2 dp on p.noPermintaan=dp.noPermintaan join buku b on dp.kodeBuku=b.kodeBuku join dummystock ds on b.kodeBuku=ds.kodeBuku where p.noPermintaan='""' and b.kodeBuku='""'", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        BookMutasion.dgvMutasi.DataSource = DS.Tables(0)
        BookMutasion.dgvMutasi.Columns.Add(cols)
        conn.Close()
    End Sub
    Public Sub getPermintaan(ByVal field As String, ByVal kb As String, ByVal np As String, ByVal baris As Integer)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select " & field & ",jPermintaan,totalMutasi from detaipermintaan2 dp join dummyStock ds on dp.kodeBuku=ds.kodeBuku where dp.kodeBuku='" & kb & "' and dp.noPermintaan='" & np & "' ", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD("jPermintaan") - RD("totalMutasi") = 0 Then
                BookMutasion.dgvMutasi.Rows(baris).Cells(1).Value = RD.Item(0)
                BookMutasion.dgvMutasi.Rows(baris).Cells(2).Value = RD.Item(1)
                BookMutasion.dgvMutasi.Rows(baris).Cells(1).ReadOnly = True
                BookMutasion.dgvMutasi.Rows(baris).Cells(2).ReadOnly = True
            Else
                BookMutasion.dgvMutasi.Rows(baris).Cells(1).Value = RD.Item(0)
                BookMutasion.dgvMutasi.Rows(baris).Cells(2).Value = RD.Item(2)
                BookMutasion.dgvMutasi.Rows(baris).Cells(1).ReadOnly = True
                BookMutasion.dgvMutasi.Rows(baris).Cells(2).ReadOnly = True
            End If
        Else
                MsgBox("Data Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub InsertMutasi(ByVal np As String, ByVal kb As String, ByVal cb As String, ByVal jm As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from MutasiPermintaan where noPermintaan='" & np & "' and kodeBuku='" & kb & "' and cabang='" & cb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "insert into MutasiPermintaan (noPermintaan,kodeBuku,cabang,jmutasi) values('" & np & "','" & kb & "','" & cb & "','" & jm & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        Else
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "update MutasiPermintaan set jMutasi='" & jm & "',cabang='" & cb & "' where noPermintaan='" & np & "' and kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub updatstat(ByVal kb As String, ByVal np As String, ByVal tm As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from detaipermintaan2 where noPermintaan='" & np & "' and kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim htm As Double
            htm = RD.Item(4)
            If RD.Item(4) - tm = 0 Then
                htm = htm - tm
                Try
                    conn.Close()
                    conn.Open()
                    Dim query As String
                    query = "update detaipermintaan2 set totalMutasi='" & htm & "',keterangan='Terpenuhi' where noPermintaan='" & np & "' and kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(query, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Else
                htm = htm - tm
                Try
                    conn.Close()
                    conn.Open()
                    Dim query As String
                    query = "update detaipermintaan2 set totalMutasi='" & htm & "',keterangan='Stock Kurang " & htm & "' where noPermintaan='" & np & "' and kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(query, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        End If
        conn.Close()
    End Sub
    Public Sub getHarga(ByVal asal As String, ByVal tujuan As String, ByVal baris As Integer)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select harga from ekspedisi where asal LIKE '%" & asal & "%' and tujuan LIKE '%" & tujuan & "%' ", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim tot As Decimal
            ' Returns "($4,456.43)".
            tot = CInt(Int(LPermintaan.DataGridView1.Rows(baris).Cells(5).Value)) * RD("harga")
            LPermintaan.DataGridView1.Rows(baris).Cells(6).Value = tot.ToString
        Else
            MsgBox("Data Tidak Ditemukan !!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub simpanCompare(ByVal nsj As String, ByVal tgl As Date, ByVal th As String, ByVal kota As String, ByVal kb As String, ByVal jd As String, ByVal jm As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from suratJalan where nsj='" & nsj & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "insert into suratJalan (nsj,cabang,tanggal,tahun) values('" & nsj & "','" & kota & "','" & tgl.ToString & "','" & th & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "update suratJalan set cabang='" & kota & "',tanggal='" & tgl.ToString & "',tahun='" & th & "' where nsj='" & nsj & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub tDistribusi(ByVal nsj As String, ByVal tgl As Date, ByVal th As String, ByVal kota As String, ByVal kb As String, ByVal jd As String, ByVal jm As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from Distribusi where nsj='" & nsj & "' and kodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim trigger As String
                trigger = "insert into Distribusi (kodeBuku,nsj,judul,jumlah) values('" & kb & "','" & nsj & "','" & jd & "','" & jm & "')"
                CMD = New MySqlCommand(trigger, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            conn.Close()
            conn.Open()
            Try
                Dim trigger As String
                trigger = "update Distribusi set judul='" & jd & "',jumlah='" & jm & "' where nsj='" & nsj & "' and kodeBuku='" & kb & "'"
                CMD = New MySqlCommand(trigger, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
    Public Sub hasilCompare(ByVal nsj As String, ByVal kb As String, ByVal jm As Double, ByVal cb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("Select * from suratJalan sj join Distribusi ds on sj.nsj=ds.nsj where ds.nsj='" & nsj & "' and ds.kodeBuku='" & kb & "' and sj.cabang='" & cb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim trigger As String
            If jm = RD("jumlah") Then
                Try
                    conn.Close()
                    conn.Open()
                    trigger = "update Distribusi set ket='sesuai',jMyob='" & jm & "' where nsj='" & nsj & "' and kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(trigger, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            ElseIf jm <> RD("jumlah") Then
                Try
                    conn.Close()
                    conn.Open()
                    trigger = "update Distribusi set ket='tidak sesuai',jMyob='" & jm & "' where nsj='" & nsj & "' and kodeBuku='" & kb & "'"
                    CMD = New MySqlCommand(trigger, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        Else
            Try
                Dim trigger As String
                conn.Close()
                conn.Open()
                trigger = "update Distribusi set ket='Kode Buku tidak di temukan' where nsj='" & nsj & "' and ket is NULL"
                CMD = New MySqlCommand(trigger, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
    Public Sub compareHasil(ByVal cb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DS.Clear()
        DS.Reset()
        DS.Tables.Clear()
        DA = New MySqlDataAdapter("select sj.nsj,sj.Tanggal,sj.cabang,ds.kodeBuku,ds.judul,ds.jumlah,ds.jMyob as Myob,ds.ket from suratJalan sj join Distribusi ds on sj.nsj=ds.nsj where cabang='" & cb & "' ORDER By sj.nsj ASC", conn)
        DA.Fill(DS)
        compareMyob.dgvHasilCompare.DataSource = DS.Tables(0)
        conn.Close()
    End Sub
    Public Sub cekLogin(ByVal uname As String, ByVal pwd As String, ByVal ha As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Try
            CMD = New MySqlCommand("select * from login where userName='" & uname & "' and pwd='" & pwd & "' and status='aktif'", conn)
            RD = CMD.ExecuteReader()
            RD.Read()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        If RD.HasRows = True Then
            If RD("hakAkses") = "Admin" And ha = "Admin" Then
                MenuAwal.Show()
                Login.Hide()
            ElseIf RD("hakAkses") = "Staff" And ha = "Staff" Then
                MenuAwal.Show()
                Login.Hide()
                MenuAwal.BukuToolStripMenuItem.Enabled = False
                MenuAwal.CabangToolStripMenuItem.Enabled = False
                MenuAwal.InputStockCabangToolStripMenuItem.Enabled = False
                MenuAwal.Permintaan2ToolStripMenuItem.Enabled = False
                MenuAwal.LaporanPermintaanToolStripMenuItem.Enabled = False
                MenuAwal.DistribusiToolStripMenuItem.Enabled = False
                MenuAwal.UserManagementToolStripMenuItem.Enabled = False
            ElseIf RD("hakAkses") = "Gudang1" And ha = "Gudang1" Then
                MenuAwal.Show()
                Login.Hide()
                MenuAwal.BukuToolStripMenuItem.Enabled = False
                MenuAwal.CabangToolStripMenuItem.Enabled = False
                MenuAwal.DistribusiToolStripMenuItem.Enabled = False
                MenuAwal.UserManagementToolStripMenuItem.Enabled = False
                MenuAwal.LaporanToolStripMenuItem.Enabled = False
                MenuAwal.Permintaan2ToolStripMenuItem.Enabled = False
                MenuAwal.CompareSalesDistribusiToolStripMenuItem.Enabled = False
            ElseIf RD("hakAkses") = "Gudang2" And ha = "Gudang2" Then
                MenuAwal.Show()
                Login.Hide()
                MenuAwal.BukuToolStripMenuItem.Enabled = False
                MenuAwal.CabangToolStripMenuItem.Enabled = False
                MenuAwal.UserManagementToolStripMenuItem.Enabled = False
                MenuAwal.LaporanToolStripMenuItem.Enabled = False
                MenuAwal.Permintaan2ToolStripMenuItem.Enabled = False
                MenuAwal.CompareSalesDistribusiToolStripMenuItem.Enabled = False
                MenuAwal.InputStockCabangToolStripMenuItem.Enabled = False
            ElseIf RD("hakAkses") = "Request Only" And ha = "Request Only" Then
                MenuAwal.Show()
                Login.Hide()
                MenuAwal.BukuToolStripMenuItem.Enabled = False
                MenuAwal.CabangToolStripMenuItem.Enabled = False
                MenuAwal.UserManagementToolStripMenuItem.Enabled = False
                MenuAwal.CompareSalesDistribusiToolStripMenuItem.Enabled = False
                MenuAwal.InputStockCabangToolStripMenuItem.Enabled = False
                MenuAwal.DistribusiToolStripMenuItem.Enabled = False
            Else
                MessageBox.Show("Hak akses Salah ", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Kombinasi Username, Password dan Hak akses Salah ", "Konfrimasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub daftarUser(ByVal uname As String, ByVal pwd As String, ByVal ha As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from login where userName='" & uname & "' and pwd='" & pwd & "'", conn)
        RD = CMD.ExecuteReader()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim trigger As String
                trigger = "insert into Login (userName,pwd,hakAkses) values('" & uname & "','" & pwd & "','" & ha & "')"
                CMD = New MySqlCommand(trigger, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MessageBox.Show("Data Tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Daftar.Close()
                Login.Show()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MessageBox.Show("Username Sudah ada", "Konfrimasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub user()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DS.Clear()
        DS.Reset()
        DS.Tables.Clear()
        DA = New MySqlDataAdapter("select * from login", conn)
        DA.Fill(DS)
        UserManagement.dgvUser.DataSource = DS.Tables(0)
        conn.Close()
    End Sub
    Public Sub UserActivasion(ByVal stat As String, ByVal uname As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from login where userName='" & uname & "'", conn)
        RD = CMD.ExecuteReader()
        If RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim status As String
                If stat = "Active" Then
                    status = "Aktif"
                ElseIf stat = "Suspend" Then
                    status = "Suspend"
                End If
                Dim query As String
                query = "update login set status='" & stat & "' where userName='" & uname & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MessageBox.Show("User '" & stat & "' ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
End Module
