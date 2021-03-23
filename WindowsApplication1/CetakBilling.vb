Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class CetakBilling
    Public conn As MySqlConnection
    Public data As New DataTable
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public query As MySqlDataReader
    Public da As MySqlDataAdapter
    Public str As String
    Public str2 As String

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub CetakBilling_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        str = "server=localhost; user=root; password=; database=tubes; allow user variables=true"
        conn = New MySqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            'conn.Open()
        End If
        Try
            conn.Open()
            cmd = New MySqlCommand("select No_pendaftaran from data_mahasiswa", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("No_pendaftaran")
                Nopen.Text = str

            Else
                Nopen.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Nama_Mhs from data_mahasiswa", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Nama_Mhs")
                NM.Text = str

            Else
                NM.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Sumber_Biaya from data_mahasiswa", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Sumber_Biaya")
                Sumpem.Text = str

            Else
                Sumpem.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Bidik_Misi from data_mahasiswa", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Bidik_Misi")
                Label28.Text = str

            Else
                Label28.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Tgl_Lahir_Mhs from per_orang", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Tgl_Lahir_Mhs")
                Label22.Text = str

            Else
                Label22.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Jenis_Kel from per_orang", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Jenis_Kel")
                Label25.Text = str

            Else
                Label25.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select NoHP_Mhs from per_orang", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("NoHP_Mhs")
                Label27.Text = str

            Else
                Label27.Text = " "
            End If
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("select Pengajuan_UKT from data_mahasiswa", conn)
            'cmd.ExecuteNonQuery()
            query = cmd.ExecuteReader
            If query.Read Then
                str = query.Item("Pengajuan_UKT")
                Label29.Text = str

            Else
                Label29.Text = " "
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.Close()

        
        Me.Hide()
    End Sub
End Class