Imports System.Data.Odbc
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class form
    Dim conn As New MySqlConnection
    Const DSN_ODBC = "DSN=tubes"
    'Dim connection As OdbcConnection
    Dim command As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim table As DataTable
    Public query As MySqlDataReader
    Public str As String


    'Public cmd As MySqlCommand

    'Public conn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public strsql As String

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        'Dim connection As New 
        'Dim str As String

        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
        ' dengan Using, object akan auto dispose
        Using cmd As New MySqlCommand("SELECT * FROM data_mahasiswa", conn)
            Using adapter As New MySqlDataAdapter(cmd)
                Using dataset As New DataSet()
                    adapter.Fill(dataset)
                    DGVDetail.DataSource = dataset.Tables(0)
                End Using
            End Using
        End Using
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
        ' dengan Using, object akan auto dispose
        Using cmd As New MySqlCommand("SELECT Nama_Pembiaya,gaji from penghasilan_dan_pengeluaran WHERE gaji BETWEEN 5000000 AND 10000000", conn)
            Using adapter As New MySqlDataAdapter(cmd)
                Using dataset As New DataSet()
                    adapter.Fill(dataset)
                    DGVDetail.DataSource = dataset.Tables(0)
                End Using
            End Using
        End Using
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
        ' dengan Using, object akan auto dispose
        Using cmd As New MySqlCommand("select Nama_Mhs,Pengajuan_UKT, count(*) as Jumlah_Pengajuan_UKT from data_mahasiswa group by Pengajuan_UKT", conn)
            Using adapter As New MySqlDataAdapter(cmd)
                Using dataset As New DataSet()
                    adapter.Fill(dataset)
                    DGVDetail.DataSource = dataset.Tables(0)
                End Using
            End Using
        End Using
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
        ' dengan Using, object akan auto dispose
        Using cmd As New MySqlCommand("SELECT COUNT(No_pendaftaran) as program_bidikmisi from data_mahasiswa where Bidik_Misi = 'Ya'", conn)
            Using adapter As New MySqlDataAdapter(cmd)
                Using dataset As New DataSet()
                    adapter.Fill(dataset)
                    DGVDetail.DataSource = dataset.Tables(0)
                End Using
            End Using
        End Using
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()
        ' dengan Using, object akan auto dispose
        Using cmd As New MySqlCommand("SELECT *FROM data_mahasiswa WHERE Nama_Mhs LIKE '%f'", conn)
            Using adapter As New MySqlDataAdapter(cmd)
                Using dataset As New DataSet()
                    adapter.Fill(dataset)
                    DGVDetail.DataSource = dataset.Tables(0)
                End Using
            End Using
        End Using
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub
End Class