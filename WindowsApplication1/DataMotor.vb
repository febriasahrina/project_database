Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DataMotor
    Dim conn As New MySqlConnection
    Dim myconnection As SqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim ni As String
    Dim jm2 As Integer
    Dim im2 As Integer = 0

    Private Sub load_()
        If im2 < jm2 Then
            im2 += 1

            If Asal1M.Checked = True Then
                ni = Asal1M.Text
            End If
            If Asal2M.Checked = True Then
                ni = Asal2M.Text
            End If
            If Asal3M.Checked = True Then
                ni = Asal3M.Text
            End If
            If Asal4M.Checked = True Then
                ni = Asal4M.Text
            End If

        End If
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Convert.ToInt32(JlhMotor.Text)
        jm2 = JlhMotor.Text
        load_()

        Dim DatabaseName As String = "tubes"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        JlhMotor.Enabled = False
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.Open()

        If JlhMotor.Text = "" Or ni = "" Or IsiSM.Text = "" Or ThnPemM.Text = "" Then
            MsgBox("Silahkan Lengkapi Field yang harus diisi")

        Else
            query = ("Insert into fasilitas_motor(Item_Motor, Asal_Motor, IsiSilinder_Motor, ThnPembuatan_Motor, Jlh_Motor, Jlh_Pajak_Motor) VALUES ('" & im2 & "','" & ni & "','" & IsiSM.Text & "','" & ThnPemM.Text & "','" & JlhMotor.Text & "','" & PajakMot.Text & "')")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            If im2 < jm2 Then
                MessageBox.Show("Sukses! silahkan isi data data motor ke-" & im2 + 1&)

            Else
                MessageBox.Show("Sukses! silahkan isi data yang lainnya")
                Me.Hide()
            End If
        End If
        If im2 = 1 Then
            query = ("Update fasilitas set Item_Motor= '" & JlhMotor.Text & "'")
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        End If
        Asal1M.Checked = False
        Asal2M.Checked = False
        Asal3M.Checked = False
        Asal4M.Checked = False
        Asal1M.Enabled = True
        Asal2M.Enabled = True
        Asal3M.Enabled = True
        Asal4M.Enabled = True
        IsiSM.Text = ""
        ThnPemM.Text = ""
        PajakMot.Text = ""
    End Sub

    Private Sub Asal1M_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal1M.CheckedChanged
        Asal2M.Enabled = False
        Asal3M.Enabled = False
        Asal4M.Enabled = False
    End Sub

    Private Sub Asal2M_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal2M.CheckedChanged
        Asal1M.Enabled = False
        Asal3M.Enabled = False
        Asal4M.Enabled = False
    End Sub

    Private Sub Asal3M_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal3M.CheckedChanged
        Asal1M.Enabled = False
        Asal2M.Enabled = False
        Asal4M.Enabled = False
    End Sub

    Private Sub Asal4M_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asal4M.CheckedChanged
        Asal1M.Enabled = False
        Asal2M.Enabled = False
        Asal3M.Enabled = False
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        Asal1M.Checked = False
        Asal2M.Checked = False
        Asal3M.Checked = False
        Asal4M.Checked = False
        Asal1M.Enabled = True
        Asal2M.Enabled = True
        Asal3M.Enabled = True
        Asal4M.Enabled = True
        IsiSM.Text = ""
        ThnPemM.Text = ""
        PajakMot.Text = ""
    End Sub
End Class