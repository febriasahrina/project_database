Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DataAyah
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

        If GolTNIA.Enabled = True Then
            Gol = GolTNIA.Text
        Else
            Gol = GolPNS1A.Text
        End If

        If NamaA.Text = "" Or AlamatA.Text = "" Or LTA.Text = "" Or NJBuA.Text = "" Or LBA.Text = "" Or NJBaA.Text = "" Or TLA.Text = "" Or TglLA.Text = "" Or BlnlA.Text = "" Or ThnLA.Text = "" Or AgamaA.Text = "" Or PekerjaanA.Text = "" Or JabatanA.Text = "" Or Gol = "" Or InstansiA.Text = "" Or MasKerA.Text = "" Or GajiA.Text = "" Or TunjanganA.Text = "" Or InsentifA.Text = "" Or PensiunA.Text = "" Or BonusA.Text = "" Or PengLA.Text = "" Or PengBA.Text = "" Or PendidikanA.Text = "" Or NoTelA.Text = "" Or NPWPA.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into data_ayah(Nama_Pembiaya, Tempat_Lahir, Tanggal_Lahir, Agama, No_HP, NPWP, Pendidikan_Terakhir) VALUES ('" & NamaA.Text & "','" & TLA.Text & "','" & ThnLA.Text & "-" & BlnlA.Text & "-" & TglLA.Text & "', '" & AgamaA.Text & "','" & NoTelA.Text & "','" & NPWPA.Text & "','" & PendidikanA.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into alamat(Nama_Pembiaya, Alamat, Luas_Tanah, NJOP_Bumi, Luas_Bangunan, NJOP_Bangunan) VALUES ('" & NamaA.Text & "','" & AlamatA.Text & "','" & LTA.Text & "','" & NJBuA.Text & "','" & LBA.Text & "','" & NJBaA.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into pekerjaan(Nama_Pembiaya, Pekerjaan, Jabatan, Golongan, Instansi, Masa_Kerja) VALUES ('" & NamaA.Text & "','" & PekerjaanA.Text & "','" & JabatanA.Text & "','" & Gol & "','" & InstansiA.Text & "','" & MasKerA.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into penghasilan_dan_pengeluaran(Nama_Pembiaya, Pekerjaan, Gaji, Pensiun, Tunjangan, Bonus, Insentif) VALUES ('" & NamaA.Text & "','" & PekerjaanA.Text & "','" & GajiA.Text & "','" & PensiunA.Text & "','" & TunjanganA.Text & "','" & BonusA.Text & "','" & InsentifA.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into perusahaan(Nama_Pembiaya, Nama_Instansi) VALUES ('" & NamaA.Text & "','" & InstansiA.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub GolPNS1A_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolPNS1A.TextChanged
        GolTNIA.Enabled = False
    End Sub

    Private Sub GolTNIA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolTNIA.TextChanged
        GolPNS1A.Enabled = False
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        NamaA.Text = ""
        AlamatA.Text = ""
        LTA.Text = ""
        NJBuA.Text = ""
        LBA.Text = ""
        NJBaA.Text = ""
        TLA.Text = ""
        TglLA.Text = ""
        BlnlA.Text = ""
        ThnLA.Text = ""
        AgamaA.Text = ""
        PekerjaanA.Text = ""
        JabatanA.Text = ""
        Gol = ""
        InstansiA.Text = ""
        MasKerA.Text = ""
        GajiA.Text = ""
        TunjanganA.Text = ""
        InsentifA.Text = ""
        PensiunA.Text = ""
        BonusA.Text = ""
        PengLA.Text = ""
        PengBA.Text = ""
        PendidikanA.Text = ""
        NoTelA.Text = ""
        NPWPA.Text = ""
        GolPNS1A.Text = ""
        GolTNIA.Text = ""
        GolPNS1A.Enabled = True
        GolTNIA.Enabled = True

    End Sub
End Class