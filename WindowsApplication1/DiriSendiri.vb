Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DiriSendiri
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


        If GajPen.Text = "" Or Tunjangan.Text = "" Or Insentif.Text = "" Or Bonus.Text = "" Or PengL.Text = "" Or PengB.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into data_diri(Gaji, Tunjangan, Insentif, Bonus, Penghasilan_Lainnya, Pengeluaran_per_Bulan) VALUES ('" & GajPen.Text & "','" & Tunjangan.Text & "','" & Insentif.Text & "','" & Bonus.Text & "','" & PengL.Text & "','" & PengB.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()


            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            conn.Close()
            Me.Hide()
        End If

    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        GajPen.Text = ""
        Tunjangan.Text = ""
        Insentif.Text = ""
        Bonus.Text = ""
        PengL.Text = ""
        PengB.Text = ""
    End Sub
End Class