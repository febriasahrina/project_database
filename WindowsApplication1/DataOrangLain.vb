Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataOrangLain
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim Gol As String


    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()

        If GolTNIO.Enabled = True Then
            Gol = GolTNIO.Text
        Else
            Gol = GolPNS1O.Text
        End If

        If NamaO.Text = "" Or AlamatO.Text = "" Or LTO.Text = "" Or NJBuO.Text = "" Or LBO.Text = "" Or NJBaO.Text = "" Or TLO.Text = "" Or TglLO.Text = "" Or BlnlO.Text = "" Or ThnLO.Text = "" Or AgamaO.Text = "" Or PekerjaanO.Text = "" Or JabatanO.Text = "" Or Gol = "" Or InstansiO.Text = "" Or MasKerO.Text = "" Or GajiO.Text = "" Or TunjanganO.Text = "" Or InsentifO.Text = "" Or PensiunO.Text = "" Or BonusO.Text = "" Or PengLO.Text = "" Or PengBO.Text = "" Or PendidikanO.Text = "" Or NoTelO.Text = "" Or NPWPO.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into data_orang_lain(Nama_Pembiaya, Tempat_Lahir, Tanggal_Lahir, Agama, No_HP, NPWP, Pendidikan_Terakhir) VALUES ('" & NamaO.Text & "','" & TLO.Text & "','" & ThnLO.Text & "-" & BlnlO.Text & "-" & TglLO.Text & "', '" & AgamaO.Text & "','" & NoTelO.Text & "','" & NPWPO.Text & "','" & PendidikanO.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into alamat(Nama_Pembiaya, Alamat, Luas_Tanah, NJOP_Bumi, Luas_Bangunan, NJOP_Bangunan) VALUES ('" & NamaO.Text & "','" & AlamatO.Text & "','" & LTO.Text & "','" & NJBuO.Text & "','" & LBO.Text & "','" & NJBaO.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into pekerjaan(Nama_Pembiaya, Pekerjaan, Jabatan, Golongan, Instansi, Masa_Kerja) VALUES ('" & NamaO.Text & "','" & PekerjaanO.Text & "','" & JabatanO.Text & "','" & Gol & "','" & InstansiO.Text & "','" & MasKerO.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into penghasilan_dan_pengeluaran(Nama_Pembiaya, Pekerjaan, Gaji, Pensiun, Tunjangan, Bonus, Insentif) VALUES ('" & NamaO.Text & "','" & PekerjaanO.Text & "','" & GajiO.Text & "','" & PensiunO.Text & "','" & TunjanganO.Text & "','" & BonusO.Text & "','" & InsentifO.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        NamaO.Text = ""
        AlamatO.Text = ""
        LTO.Text = ""
        NJBuO.Text = ""
        LBO.Text = ""
        NJBaO.Text = ""
        TLO.Text = ""
        TglLO.Text = ""
        BlnlO.Text = ""
        ThnLO.Text = ""
        AgamaO.Text = ""
        PekerjaanO.Text = ""
        JabatanO.Text = ""
        Gol = ""
        InstansiO.Text = ""
        MasKerO.Text = ""
        GajiO.Text = ""
        TunjanganO.Text = ""
        InsentifO.Text = ""
        PensiunO.Text = ""
        BonusO.Text = ""
        PengLO.Text = ""
        PengBO.Text = ""
        PendidikanO.Text = ""
        NoTelO.Text = ""
        NPWPO.Text = ""
        GolPNS1O.Text = ""
        GolTNIO.Text = ""
        GolPNS1O.Enabled = True
        GolTNIO.Enabled = True
    End Sub

    Private Sub GolPNS1O_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolPNS1O.TextChanged
        GolTNIO.Enabled = False
    End Sub

    Private Sub GolTNIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolTNIO.TextChanged
        GolPNS1O.Enabled = False
    End Sub
End Class