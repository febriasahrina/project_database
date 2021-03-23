Public Class SuratPernyataan

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

        MessageBox.Show("Terima Kasih")
        Me.Hide()
        Dim form As New MenuLain
        form.Show()
    End Sub
End Class