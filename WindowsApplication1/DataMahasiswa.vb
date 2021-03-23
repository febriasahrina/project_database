Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DataMahasiswa
    Dim myconnection As SqlConnection
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim query2 As String
    Dim query3 As String
    Dim pu As String
    Dim jp As String
    Dim bm As String
    Dim jk As String
    Dim gd As String
    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"

        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()

        If Jenprod1P.Checked = True Then
            jp = Jenprod1P.Text
        End If
        If Jenprod2P.Checked = True Then
            jp = Jenprod2P.Text
        End If

        If CheckBoxPeng1P.Checked = True Then
            pu = CheckBoxPeng1P.Text
        End If

        If CheckBoxPeng2P.Checked = True Then
            pu = CheckBoxPeng2P.Text
        End If

        If CheckBoxPeng3P.Checked = True Then
            pu = CheckBoxPeng3P.Text
        End If

        If CheckBoxBid1P.Checked = True Then
            bm = CheckBoxBid1P.Text
        End If
        If CheckBoxBid2P.Checked = True Then
            bm = CheckBoxBid2P.Text
        End If

        If CheckBoxKel1P.Checked = True Then
            jk = CheckBoxKel1P.Text
        End If
        If CheckBoxKel2P.Checked = True Then
            jk = CheckBoxKel2P.Text
        End If

        If Goldar1P.Checked = True Then
            gd = Goldar1P.Text
        End If

        If Goldar2P.Checked = True Then
            gd = Goldar2P.Text
        End If

        If Goldar3P.Checked = True Then
            gd = Goldar3P.Text
        End If

        If Goldar4P.Checked = True Then
            gd = Goldar4P.Text
        End If


        If Nopenp.Text = "" Or NamaP.Text = "" Or NISNP.Text = "" Or jp = "" Or bm = "" Or jk = "" Or gd = "" Or TglLMP.Text = "" Or BlnlMP.Text = "" Or ThnLMP.Text = "" Or AgamaP.Text = "" Or AnakkeP.Text = "" Or JlhberP.Text = "" Or JlhsauP.Text = "" Or NotelP.Text = "" Or pu = "" Or SumbiayaP.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else

            query = ("Insert into data_mahasiswa(No_pendaftaran, Nama_Mhs, NISN, Jenjang_prodi, Bidik_Misi, Pengajuan_UKT, Sumber_Biaya) VALUES ('" & Nopenp.Text & "','" & NamaP.Text & "','" & NISNP.Text & "','" & jp & "','" & bm & "','" & pu & "','" & SumbiayaP.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into per_orang(Nama_Mhs, Jenis_Kel, Gol_Darah, Tgl_Lahir_Mhs, Agama_Mhs, NoHP_Mhs) VALUES ('" & NamaP.Text & "','" & jk & "','" & gd & "','" & ThnLMP.Text & "-" & BlnlMP.Text & "-" & TglLMP.Text & "', '" & AgamaP.Text & "','" & NotelP.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into saudara_mahasiswa(No_pendaftaran, AnakKeberapa, jlhSaudara, jlhSaudaraKuliah) VALUES ('" & Nopenp.Text & "','" & AnakkeP.Text & "','" & JlhberP.Text & "','" & JlhsauP.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("Insert into tabel_utama(No_pendaftaran, Nama_Mhs, Sumber_Biaya) VALUES ('" & Nopenp.Text & "','" & NamaP.Text & "','" & SumbiayaP.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()


            MessageBox.Show("Sukses! silahkan isi data lain")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        Nopenp.Text = ""
        NamaP.Text = ""
        NISNP.Text = ""
        Jenprod1P.Checked = False
        Jenprod2P.Checked = False
        Jenprod1P.Enabled = True
        Jenprod2P.Enabled = True
        CheckBoxBid1P.Checked = False
        CheckBoxBid2P.Checked = False
        CheckBoxKel1P.Checked = False
        CheckBoxKel2P.Checked = False
        CheckBoxBid1P.Enabled = True
        CheckBoxBid2P.Enabled = True
        CheckBoxKel1P.Enabled = True
        CheckBoxKel2P.Enabled = True
        Goldar1P.Checked = False
        Goldar2P.Checked = False
        Goldar3P.Checked = False
        Goldar4P.Checked = False
        Goldar1P.Enabled = True
        Goldar2P.Enabled = True
        Goldar3P.Enabled = True
        Goldar4P.Enabled = True
        TglLMP.Text = ""
        BlnlMP.Text = ""
        ThnLMP.Text = ""
        AgamaP.Text = ""
        AnakkeP.Text = ""
        JlhberP.Text = ""
        JlhsauP.Text = ""
        NotelP.Text = ""
        CheckBoxPeng1P.Checked = False
        CheckBoxPeng2P.Checked = False
        CheckBoxPeng3P.Checked = False
        CheckBoxPeng1P.Enabled = True
        CheckBoxPeng2P.Enabled = True
        CheckBoxPeng3P.Enabled = True
        SumbiayaP.Text = ""
        jp = ""
        jk = ""
        pu = ""
        pu = ""
        bm = ""
    End Sub

    Private Sub CheckBoxPeng3P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPeng3P.CheckedChanged
        CheckBoxPeng1P.Enabled = False
        CheckBoxPeng2P.Enabled = False
    End Sub

    Private Sub CheckBoxPeng2P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPeng2P.CheckedChanged
        CheckBoxPeng1P.Enabled = False
        CheckBoxPeng3P.Enabled = False
    End Sub

    Private Sub CheckBoxPeng1P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPeng1P.CheckedChanged
        CheckBoxPeng3P.Enabled = False
        CheckBoxPeng2P.Enabled = False
    End Sub

    Private Sub Jenprod1P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jenprod1P.CheckedChanged
        Jenprod2P.Enabled = False
    End Sub

    Private Sub Jenprod2P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jenprod2P.CheckedChanged
        Jenprod1P.Enabled = False
    End Sub

    Private Sub CheckBoxKel1P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxKel1P.CheckedChanged
        CheckBoxKel2P.Enabled = False
    End Sub

    Private Sub CheckBoxKel2P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxKel2P.CheckedChanged
        CheckBoxKel1P.Enabled = False
    End Sub

    Private Sub Goldar1P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Goldar1P.CheckedChanged
        Goldar2P.Enabled = False
        Goldar3P.Enabled = False
        Goldar4P.Enabled = False
    End Sub

    Private Sub Goldar3P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Goldar3P.CheckedChanged
        Goldar2P.Enabled = False
        Goldar1P.Enabled = False
        Goldar4P.Enabled = False
    End Sub

    Private Sub Goldar2P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Goldar2P.CheckedChanged
        Goldar1P.Enabled = False
        Goldar3P.Enabled = False
        Goldar4P.Enabled = False
    End Sub

    Private Sub Goldar4P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Goldar4P.CheckedChanged
        Goldar2P.Enabled = False
        Goldar3P.Enabled = False
        Goldar1P.Enabled = False
    End Sub

    Private Sub CheckBoxBid1P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxBid1P.CheckedChanged
        CheckBoxBid2P.Enabled = False
    End Sub

    Private Sub CheckBoxBid2P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxBid2P.CheckedChanged
        CheckBoxBid1P.Enabled = False
    End Sub

    Private Sub DataMahasiswa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class