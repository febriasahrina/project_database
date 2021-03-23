Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataPerusahaan
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()

        If NamaP.Text = "" Or AlamatP.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("update perusahaan set Alamat_Instansi = '" & AlamatP.Text & "' where Nama_Instansi = '" & NamaP.Text & "'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        NamaP.Text = ""
        AlamatP.Text = ""
    End Sub
End Class