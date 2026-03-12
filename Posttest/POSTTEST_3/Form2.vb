Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNm.Text = Module1.Nama
        lblUmr.Text = Module1.Umur
        lblHb.Text = Module1.Hobi
        lblJk.Text = Module1.JK
        lblAlmt.Text = Module1.Almt
        lblHp.Text = Module1.Hp
        lblTgl.Text = Module1.Tgl
        PictureBox2.Image = Image.FromFile(Module1.Gambar)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblHp.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblAlmt.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class