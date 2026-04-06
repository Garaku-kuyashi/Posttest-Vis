Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblNama.Text = Module1.Nama.ToUpper()
            lblId.Text = Module1.Id
            lblJk.Text = Module1.JK.ToUpper()
            lblHp.Text = Module1.Hp
            lblAlmt.Text = Module1.Almt
            lblHobi.Text = Module1.Hobi.ToUpper()
            lblDivisi.Text = Module1.Divisi.ToUpper()
            lblEmail.Text = Module1.Email
            lblTgl.Text = Module1.Tgl.ToString("dd MMMM yyyy").ToUpper()

            If Not String.IsNullOrEmpty(Module1.Gambar) AndAlso File.Exists(Module1.Gambar) Then
                Using fs As New FileStream(Module1.Gambar, FileMode.Open, FileAccess.Read)
                    PictureBox3.Image = Image.FromStream(fs)
                End Using
                PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat visual kartu: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub
End Class