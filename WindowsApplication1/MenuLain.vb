Public Class MenuLain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form As New UpdateData
        form.Show()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim form As New DeleteData
        form.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub Cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cetak.Click
        Dim form As New JenisUKT
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form As New CetakBilling
        form.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim form As New form
        form.Show()
    End Sub
End Class