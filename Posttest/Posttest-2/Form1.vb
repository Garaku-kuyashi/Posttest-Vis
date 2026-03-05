Public Class Form1
    Private Sub TampilBuku()
        dgvBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahBuku(txtTambah.Text, txtGenre.Text)
        TampilBuku()
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        HapusBuku(txtHapus.Text)
        TampilBuku()
    End Sub


End Class
