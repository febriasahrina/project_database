Imports System.Data.Odbc
Imports System.IO
Imports Microsoft.VisualBasic
Namespace accesdata
    Public Class koneksi
        Dim conn As New Odbc.OdbcConnection("DSN=presensi")
        Protected cmd As Odbc.OdbcCommand
        Protected da As Odbc.OdbcDataAdapter
        Protected ds As DataSet
        Protected dt As DataTable

        Private Property dcservertgl As String

        Public Function executeQuery(ByVal Query As String) As DataTable
            cmd = New OdbcCommand(Query, conn)
            da = New OdbcDataAdapter(cmd)
            da.SelectCommand = cmd
            ds = New Data.DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            Return dt
            dt = Nothing
            da = Nothing
            ds = Nothing
            cmd = Nothing
        End Function
        Public Function buka() As OdbcConnection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return conn
        End Function
        Public Function tutup() As OdbcConnection
            conn = Nothing
            Return conn
        End Function
        Public Function ambiltgl()
            buka()
            buka()
            Dim strsql As String = "select current_date tgl;"
            Dim mycmd As New OdbcCommand(strsql, conn)
            Dim rdr As OdbcDataReader = mycmd.ExecuteReader
            If rdr.Read Then
                dcservertgl = rdr("tgl").ToString()
            End If
            rdr.Close()
            rdr = Nothing
            mycmd = Nothing
            Return conn
        End Function
    End Class
End Namespace
