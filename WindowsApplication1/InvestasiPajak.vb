Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class InvestasiPajak
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

        If BenBeg.Text = "" Or BenTbeg.Text = "" Or Netto.Text = "" Or PPH21.Text = "" Or PPH23.Text = "" Or PPN.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into investasi_dan_beban_pajak(No_Inves_Pajak, Benda_Bergerak, Benda_Tak_Bergerak, Netto, PPN, PPh23, PPh21 ) VALUES ('1','" & BenBeg.Text & "','" & BenTbeg.Text & "','" & Netto.Text & "','" & PPN.Text & "','" & PPH23.Text & "','" & PPH21.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("update tabel_utama set No_Inves_Pajak='1'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        BenBeg.Text = ""
        BenTbeg.Text = ""
        Netto.Text = ""
        PPH21.Text = ""
        PPH23.Text = ""
        PPN.Text = ""
    End Sub
End Class