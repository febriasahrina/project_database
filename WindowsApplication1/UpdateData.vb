Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class UpdateData
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Try

            Dim DatabaseName As String = "tubes"
            Dim server As String = "127.0.0.1"
            Dim userName As String = "root"

            Dim password As String = ""
            If Not conn Is Nothing Then conn.Close()
            conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
            conn.Open()
            'cmd = conn.CreateCommand
            query = ("UPDATE data_mahasiswa SET Nama_Mhs = '" & namaM.Text & "',NISN = '" & nisn.Text & "',Pengajuan_UKT= '" & pengukt.Text & "' where No_pendaftaran = '" & nopen.Text & "'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("UPDATE per_orang SET Nama_Mhs = '" & namaM.Text & "'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            query = ("UPDATE per_orang SET Tgl_Lahir_Mhs= '" & ThnLM.Text & "-" & BlnlM.Text & "-" & TglLM.Text & "',NoHP_Mhs= '" & notelM.Text & "' where Nama_Mhs = '" & namaM.Text & "'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Saved", vbInformation, "Pesan")
            conn.Close()
            nopen.Clear()
            namaM.Clear()
            nisn.Clear()
            pengukt.Text = ""
            TglLM.Text = ""
            BlnlM.Text = ""
            ThnLM.Text = ""
            notelM.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        nopen.Clear()
        namaM.Clear()
        nisn.Clear()
        pengukt.Text = ""
        TglLM.Text = ""
        BlnlM.Text = ""
        ThnLM.Text = ""
        notelM.Clear()
    End Sub

    Private Sub UpdateData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class