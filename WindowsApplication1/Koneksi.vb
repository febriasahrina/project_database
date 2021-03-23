Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module Koneksi
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim na As String
    Dim jm As Integer
    Dim im As Integer = 0

    Public Sub login()

        Dim DatabaseName As String = "tubes_database"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
    End Sub

    Public Sub close()
        With conn
            .Dispose()
            .Close()
        End With

    End Sub

End Module
