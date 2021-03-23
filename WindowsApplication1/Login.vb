Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As New MySqlConnection

    Public Sub connect()
        Dim DatabaseName As String = "tubes_database"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()

            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            conn.Open()
            Dim command As MySqlCommand
            Dim reader As MySqlDataReader
            Dim Query As String
            Query = "select * from users where Nomor_pendaftaran= '" & Nopeserta.Text & "' and Password= '" & Pass.Text & "' "
            command = New MySqlCommand(Query, conn)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While

            If count = 1 Then
                Dim form As New MenuLain
                form.Show()
                Me.Hide()
                'MessageBox.Show("Username and password are correct")
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate")
            Else
                MessageBox.Show("Username and password are wrong")
            End If
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Nopeserta.Text = ""
        Pass.Text = ""
        Label3.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub
End Class
