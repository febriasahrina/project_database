Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataIbu
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

        If GolTNII.Enabled = True Then
            Gol = GolTNII.Text
        Else
            Gol = GolPNS1I.Text
        End If

        If NamaI.Text = "" Or AlamatI.Text = "" Or LTI.Text = "" Or NJBuI.Text = "" Or LBI.Text = "" Or NJBaI.Text = "" Or TLI.Text = "" Or TglLI.Text = "" Or BlnlI.Text = "" Or ThnLI.Text = "" Or AgamaI.Text = "" Or PekerjaanI.Text = "" Or JabatanI.Text = "" Or Gol = "" Or InstansiI.Text = "" Or MasKerI.Text = "" Or GajiI.Text = "" Or TunjanganI.Text = "" Or InsentifI.Text = "" Or PensiunI.Text = "" Or BonusI.Text = "" Or PengLI.Text = "" Or PengBI.Text = "" Or PendidikanI.Text = "" Or NoTelI.Text = "" Or NPWPI.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into data_ibu(Nama_Pembiaya, Tempat_Lahir, TanggalLahir, Agama, No_HP, NPWP, Pendidikan_Terakhir) VALUES ('" & NamaI.Text & "','" & TLI.Text & "','" & ThnLI.Text & "-" & BlnlI.Text & "-" & TglLI.Text & "', '" & AgamaI.Text & "','" & NoTelI.Text & "','" & NPWPI.Text & "','" & PendidikanI.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into alamat(Nama_Pembiaya, Alamat, Luas_Tanah, NJOP_Bumi, Luas_Bangunan, NJOP_Bangunan) VALUES ('" & NamaI.Text & "','" & AlamatI.Text & "','" & LTI.Text & "','" & NJBuI.Text & "','" & LBI.Text & "','" & NJBaI.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into pekerjaan(Nama_Pembiaya, Pekerjaan, Jabatan, Golongan, Instansi, Masa_Kerja) VALUES ('" & NamaI.Text & "','" & PekerjaanI.Text & "','" & JabatanI.Text & "','" & Gol & "','" & InstansiI.Text & "','" & MasKerI.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into penghasilan_dan_pengeluaran(Nama_Pembiaya, Pekerjaan, Gaji, Pensiun, Tunjangan, Bonus, Insentif) VALUES ('" & NamaI.Text & "','" & PekerjaanI.Text & "','" & GajiI.Text & "','" & PensiunI.Text & "','" & TunjanganI.Text & "','" & BonusI.Text & "','" & InsentifI.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into perusahaan(Nama_Pembiaya, Nama_Instansi) VALUES ('" & NamaI.Text & "','" & InstansiI.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub GolPNS1I_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolPNS1I.TextChanged
        GolTNII.Enabled = False
    End Sub

    Private Sub GolTNII_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GolTNII.TextChanged
        GolPNS1I.Enabled = False
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        NamaI.Text = ""
        AlamatI.Text = ""
        LTI.Text = ""
        NJBuI.Text = ""
        LBI.Text = ""
        NJBaI.Text = ""
        TLI.Text = ""
        TglLI.Text = ""
        BlnlI.Text = ""
        ThnLI.Text = ""
        AgamaI.Text = ""
        PekerjaanI.Text = ""
        JabatanI.Text = ""
        Gol = ""
        InstansiI.Text = ""
        MasKerI.Text = ""
        GajiI.Text = ""
        TunjanganI.Text = ""
        InsentifI.Text = ""
        PensiunI.Text = ""
        BonusI.Text = ""
        PengLI.Text = ""
        PengBI.Text = ""
        PendidikanI.Text = ""
        NoTelI.Text = ""
        NPWPI.Text = ""
        GolPNS1I.Text = ""
        GolTNII.Text = ""
        GolPNS1I.Enabled = True
        GolTNII.Enabled = True
    End Sub
End Class