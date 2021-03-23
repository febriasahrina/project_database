Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataMobil
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim na As String
    Dim jm As Integer
    Dim im As Integer = 0

    Private Sub load_()
        If im < jm Then
            im += 1

            If Asal1.Checked = True Then
                na = Asal1.Text
            End If
            If Asal2.Checked = True Then
                na = Asal2.Text
            End If
            If Asal3.Checked = True Then
                na = Asal3.Text
            End If
            If Asal4.Checked = True Then
                na = Asal4.Text

            End If
        End If
    End Sub


    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Convert.ToInt32(JlhMobil.Text)
        jm = JlhMobil.Text
        load_()

        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        JlhMobil.Enabled = False
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()

        If JlhMobil.Text = "" Or na = "" Or IsiS.Text = "" Or ThnPem.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into fasilitas_mobil(Item_Mobil, Asal_Merk_Mobil, IsiSilinder_Mobil, ThnPembuatan_Mobil, Jlh_Mobil, Jlh_Pajak_Mobil) VALUES ('" & im & "','" & na & "','" & IsiS.Text & "','" & ThnPem.Text & "','" & JlhMobil.Text & "','" & PajakMob.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            If im < jm Then
                MessageBox.Show("Sukses! silahkan isi data data mobil ke-" & im + 1&)

            else
                MessageBox.Show("Sukses! silahkan isi data yang lainnya")
                Me.Hide()
            End If
        End If
        If im = 1 Then
            query = ("Insert into fasilitas(Item_Mobil) VALUES ('" & JlhMobil.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        End If
        Asal1.Checked = False
        Asal2.Checked = False
        Asal3.Checked = False
        Asal4.Checked = False
        Asal1.Enabled = True
        Asal2.Enabled = True
        Asal3.Enabled = True
        Asal4.Enabled = True
        IsiS.Text = ""
        ThnPem.Text = ""
        PajakMob.Text = ""

    End Sub

    Private Sub Asal1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal1.CheckedChanged
        Asal2.Enabled = False
        Asal3.Enabled = False
        Asal4.Enabled = False
    End Sub

    Private Sub Asal2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal2.CheckedChanged
        Asal1.Enabled = False
        Asal3.Enabled = False
        Asal4.Enabled = False
    End Sub

    Private Sub Asal3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal3.CheckedChanged
        Asal1.Enabled = False
        Asal2.Enabled = False
        Asal4.Enabled = False
    End Sub

    Private Sub Asal4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal4.CheckedChanged
        Asal1.Enabled = False
        Asal2.Enabled = False
        Asal3.Enabled = False
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        Asal1.Checked = False
        Asal2.Checked = False
        Asal3.Checked = False
        Asal4.Checked = False
        Asal1.Enabled = True
        Asal2.Enabled = True
        Asal3.Enabled = True
        Asal4.Enabled = True
        IsiS.Text = ""
        ThnPem.Text = ""
        PajakMob.Text = ""
    End Sub
End Class