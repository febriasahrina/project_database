Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class DeleteData
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
            query = ("DELETE FROM data_mahasiswa WHERE data_mahasiswa.No_pendaftaran = '" & nopen.Text & "'")

            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Saved", vbInformation, "Pesan")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.nopen.Clear()
        Me.namaM.Clear()
    End Sub

    Private Sub DeleteData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub
End Class