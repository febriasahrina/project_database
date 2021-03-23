Imports MySql.Data
Imports System.Data.SqlClient

Public Class Berkas
    Private conn As New MySqlClient.MySqlConnection
    Private strSql As String = String.Empty
    Private PathFile As String = Nothing
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' kode untuk melakukan koneksi mulai dari sini
        Dim strConn As String = "server=127.0.0.1;uid=root;database=tubes"
        conn.ConnectionString = strConn
        conn.Open()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Button3.Enabled = True
            PathFile = OpenFileDialog1.FileName
            TextBox1.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            Label1.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(Label1.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        OpenFileDialog2.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog2.FileName = ""
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = New Bitmap(OpenFileDialog2.FileName)
            Button3.Enabled = True
            PathFile = OpenFileDialog2.FileName
            TextBox2.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            Label2.Text = OpenFileDialog2.FileName
            PictureBox2.Image = Image.FromFile(Label2.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        PictureBox2.Image = Nothing
        TextBox2.Text = ""
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            strSql = "Update tabel_utama set Berkas1 = @2"
            Using cmd As New MySqlClient.MySqlCommand(strSql, conn)
                With cmd
                    .Parameters.Clear()
                    '.Parameters.AddWithValue("@1", ("Surket")) ' nama
                    .Parameters.AddWithValue("@2", IO.File.ReadAllBytes(OpenFileDialog1.FileName)) ' gambar
                    .ExecuteNonQuery()
                End With
            End Using
            strSql = "Update tabel_utama set Berkas2 = @2"
            Using cmd As New MySqlClient.MySqlCommand(strSql, conn)
                With cmd
                    .Parameters.Clear()
                    '.Parameters.AddWithValue("@1", ("Fotkop Ktp")) ' nama
                    .Parameters.AddWithValue("@2", IO.File.ReadAllBytes(OpenFileDialog2.FileName)) ' gambar
                    .ExecuteNonQuery()
                End With
            End Using
            MessageBox.Show("Sukses! silahkan isi data yang lainnya")
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        PictureBox2.Image = Nothing
        TextBox2.Text = ""
        Label1.Text = ""
        Label2.Text = ""
    End Sub

End Class