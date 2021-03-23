Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class formBerkeadilan
    Dim myconnection As SqlConnection
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim pu As String
    Dim jp As String
    Dim bm As String
    Dim jk As String
    Dim gd As String

    Private Sub DiriSendiri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiriSendiri.Click
        DiriSendiri.Enabled = False
        Dim form As New DiriSendiri
        form.Show()
    End Sub

    Private Sub AyahKandung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyahKandung.Click
        AyahKandung.Enabled = False
        Dim form As New DataAyah
        form.Show()
    End Sub

    Private Sub IbuKandung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IbuKandung.Click
        IbuKandung.Enabled = False
        Dim form As New DataIbu
        form.Show()
    End Sub

    Private Sub OrangLain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrangLain.Click
        OrangLain.Enabled = False
        Dim form As New DataOrangLain
        form.Show()
    End Sub

    Private Sub Instansi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instansi.Click
        Dim form As New DataPerusahaan
        form.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Dim form As New DataMobil
        form.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Dim form As New DataMotor
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Dim form As New Sumber
        form.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim form As New InvestasiPajak
        form.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Dim form As New Berkas
        form.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Dim form As New SuratPernyataan
        form.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Dim form As New DataMahasiswa
        form.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub
End Class